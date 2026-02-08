using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Helpers;
using WinFormsApp1.Controls;

namespace WinFormsApp1
{
    public partial class Card : UserControl
    {
        Book book = new Book();
        public Card(Book book)
        {
            InitializeComponent();
            this.book = book;
            
            // Apply card styling
            this.Size = new Size(260, 360); 
            this.BackColor = UIHelper.SurfaceColor;
            this.Padding = new Padding(15);
            this.Cursor = Cursors.Hand;
            this.Margin = new Padding(15);

            // 1. Image
            picBook.Location = new Point(15, 15);
            picBook.Size = new Size(230, 160);
            picBook.SizeMode = PictureBoxSizeMode.Zoom;
            if (!string.IsNullOrEmpty(book.photoSourceString) && System.IO.File.Exists(book.photoSourceString))
            {
                picBook.Image = Image.FromFile(book.photoSourceString);
            }
            else
            {
                 picBook.BackColor = Color.FromArgb(240, 240, 240); // Grey placeholder
            }

            // 2. Title
            lblTitle.AutoSize = false;
            lblTitle.Location = new Point(10, 185);
            lblTitle.Size = new Size(240, 50); // Fixed height for 2 lines
            lblTitle.Text = book.Title;
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            UIHelper.StyleHeaderLabel(lblTitle);
            lblTitle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold); // Ensure font size fits
            
            // 3. Author
            lblAuthor.AutoSize = false;
            lblAuthor.Location = new Point(10, 235);
            lblAuthor.Size = new Size(240, 25);
            lblAuthor.Text = "by " + book.Author.Name;
            lblAuthor.TextAlign = ContentAlignment.TopCenter;
            lblAuthor.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            lblAuthor.ForeColor = UIHelper.TextSecondaryColor;

            // 4. View Button
            RoundedButton btnView = new RoundedButton();
            btnView.Text = "View";
            btnView.Size = new Size(100, 35);
            btnView.Location = new Point((this.Width - btnView.Width) / 2, 300); // Centered bottom
            UIHelper.StylePrimaryButton(btnView);
            btnView.Click += BookCard_Click;
            this.Controls.Add(btnView);

            // Events
            this.Click += BookCard_Click;
            picBook.Click += BookCard_Click;
            lblTitle.Click += BookCard_Click;
            lblAuthor.Click += BookCard_Click;

            // Hover effects
            this.MouseEnter += (s, e) => { this.BackColor = Color.FromArgb(240, 245, 255); }; 
            this.MouseLeave += (s, e) => { this.BackColor = UIHelper.SurfaceColor; };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Draw a subtle border
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }

        private void BookCard_Click(object sender, EventArgs e)
        {
            BookDetails detailsForm = new BookDetails(book.Id);
            detailsForm.Show();
        }
    }
}
