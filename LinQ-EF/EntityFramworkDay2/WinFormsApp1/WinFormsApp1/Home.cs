using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Controls;
using WinFormsApp1.Helpers;
using WinFormsApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class Home : Form
    {
        int currentAuthorId;
        LibraryContext libraryContext;
        
        // Dashboard Components
        private Panel sidebarPanel;
        private Panel headerPanel;
        private Panel contentPanel;
        private Label lblTitle;
        private RoundedButton btnProfile;
        private RoundedButton btnAddBook;
        private RoundedButton btnLogout;
        private ModernTextBox txtSearch;

        public Home(int id)
        {
            InitializeComponent();
            libraryContext = new LibraryContext();
            currentAuthorId = id;
            
            // Setup Dashboard Layout
            SetupDashboard();
            loadBooks();
        }

        private void SetupDashboard()
        {
            // Hide old designer controls - they're replaced by dashboard
            button1.Visible = false;
            btn_add.Visible = false;
            
            // Form Defaults
            this.Size = new Size(1280, 800); // Larger default
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None; 
            this.BackColor = UIHelper.BackgroundColor;

            // 1. Sidebar (Left)
            sidebarPanel = new Panel();
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Width = 250; // Wider sidebar
            sidebarPanel.BackColor = UIHelper.SurfaceColor;
            sidebarPanel.Padding = new Padding(15, 30, 15, 30);
            
            Panel shadow = new Panel();
            shadow.Width = 1;
            shadow.Dock = DockStyle.Right;
            shadow.BackColor = Color.FromArgb(229, 231, 235); // Tailwind Gray-200
            sidebarPanel.Controls.Add(shadow);

            // LOGO
            Label lblBrand = new Label();
            lblBrand.Text = "📚 LibraryApp";
            lblBrand.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblBrand.ForeColor = UIHelper.PrimaryColor;
            lblBrand.Dock = DockStyle.Top;
            lblBrand.Height = 80;
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            sidebarPanel.Controls.Add(lblBrand);

            // Menus
            btnAddBook = CreateSidebarButton("➕  Add New Book", UIHelper.PrimaryColor);
            btnAddBook.Click += btn_add_Click;
            
            btnProfile = CreateSidebarButton("👤  My Profile", UIHelper.TextSecondaryColor);
            btnProfile.Click += button1_Click;

            btnLogout = CreateSidebarButton("🚪  Logout", UIHelper.TextSecondaryColor);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.ForeColor = Color.Crimson; 
            btnLogout.Click += (s, e) => { this.Hide(); new Login().Show(); };

            // Spacer
            Panel spacer = new Panel();
            spacer.Dock = DockStyle.Top;
            spacer.Height = 20;

            sidebarPanel.Controls.Add(btnProfile);
            sidebarPanel.Controls.Add(spacer); 
            sidebarPanel.Controls.Add(btnAddBook);
            sidebarPanel.Controls.Add(btnLogout);

            // 2. Header (Top)
            headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 80;
            headerPanel.BackColor = UIHelper.BackgroundColor; // Match background for seamless look, or Surface for distinct
            headerPanel.Padding = new Padding(30, 20, 30, 20);

            lblTitle = new Label();
            lblTitle.Text = "Dashboard";
            lblTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblTitle.ForeColor = UIHelper.TextColor;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(30, 20);
            
            txtSearch = new ModernTextBox();
            txtSearch.PlaceholderText = "Search books...";
            txtSearch.Size = new Size(350, 40);
            txtSearch.Location = new Point(this.Width - 420, 20); // Initial pos, will anchor
            txtSearch.BorderRadius = 20;
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            
            // Close button
            RoundedButton btnClose = new RoundedButton();
            btnClose.Text = "✕";
            btnClose.Size = new Size(40, 40);
            btnClose.Location = new Point(this.Width - 60, 20);
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = UIHelper.TextSecondaryColor; 
            btnClose.BorderRadius = 10;
            btnClose.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Click += (s, e) => Application.Exit();
            btnClose.MouseEnter += (s, e) => { btnClose.BackColor = Color.Crimson; btnClose.ForeColor = Color.White; };
            btnClose.MouseLeave += (s, e) => { btnClose.BackColor = Color.Transparent; btnClose.ForeColor = UIHelper.TextSecondaryColor; };
            
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(txtSearch);
            headerPanel.Controls.Add(btnClose);

            // 3. Content (Center)
            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Padding = new Padding(30); // More breathing room
            
            flowLayoutPanelBooks.Parent = null; 
            flowLayoutPanelBooks.Dock = DockStyle.Fill;
            flowLayoutPanelBooks.BackColor = Color.Transparent;
            contentPanel.Controls.Add(flowLayoutPanelBooks);

            this.Controls.Add(contentPanel);
            this.Controls.Add(headerPanel);
            this.Controls.Add(sidebarPanel);
        }

        private RoundedButton CreateSidebarButton(string text, Color color)
        {
            RoundedButton btn = new RoundedButton();
            btn.Text = text;
            btn.Dock = DockStyle.Top;
            btn.Height = 50;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = UIHelper.TextColor;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Margin = new Padding(5, 5, 5, 5);
            btn.Padding = new Padding(15, 0, 0, 0); // Left padding for text
            btn.BorderRadius = 10;
            
            // Hover effects
            btn.MouseEnter += (s, e) => {
                btn.BackColor = Color.FromArgb(243, 244, 246);
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = Color.Transparent;
            };

            return btn;
        }

        private void loadBooks()
        {
            var books = libraryContext.Books.Include(b => b.Author)
                                            .Where(b => b.authorId == currentAuthorId)
                                            .ToList();
            flowLayoutPanelBooks.Controls.Clear();
            foreach (var book in books)
            {
                Card card = new Card(book);
                // Style the card using Helper + MakeRounded
                card.BackColor = UIHelper.SurfaceColor;
                card.Margin = new Padding(15); // Better spacing
                UIHelper.MakeRounded(card, 20); // Rounded Cards
                flowLayoutPanelBooks.Controls.Add(card);
            }
        }

        // Fix CS0103: Add missing event handlers
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddBook addBookForm = new AddBook(currentAuthorId);
            addBookForm.ShowDialog();
            loadBooks(); // Refresh list after adding
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(currentAuthorId);
            profileForm.ShowDialog();
        }
    }
}
