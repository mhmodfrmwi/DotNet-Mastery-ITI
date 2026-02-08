using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; 
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Models;

using WinFormsApp1.Helpers;

namespace WinFormsApp1
{
    public partial class AddBook : Form
    {
        int currentAuthorId;
        LibraryContext libraryContext;

        public AddBook(int id)
        {
            InitializeComponent();
            libraryContext = new LibraryContext();
            currentAuthorId = id;
            UIHelper.ApplyTheme(this);
            UIHelper.StyleSecondaryButton(btn_upload_image);
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = libraryContext.Categories.ToList();
            cb_categories.DataSource = categories;
            cb_categories.DisplayMember = "Name";
            cb_categories.ValueMember = "Id";
            cb_categories.SelectedIndex = -1;
        }

        string sourceFilePath = "";
        private void btn_upload_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sourceFilePath = openFileDialog.FileName;
                pic_cover.ImageLocation = sourceFilePath;
            }
        }

        private void btn_save_book_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_title.Texts) || string.IsNullOrWhiteSpace(txt_price.Texts))
            {
                MessageBox.Show("Please fill at least the Title and Price.");
                return;
            }

            if (cb_categories.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            decimal price;
            int qty;
            bool isPriceValid = decimal.TryParse(txt_price.Texts, out price);
            bool isQtyValid = int.TryParse(txt_qty.Texts, out qty);

            if (!isPriceValid || !isQtyValid)
            {
                MessageBox.Show("Please enter valid numbers for Price and Quantity.");
                return;
            }


            string imagesDirectory = Path.Combine(Application.StartupPath, "photos");
            if (!Directory.Exists(imagesDirectory))
            {
                Directory.CreateDirectory(imagesDirectory);
            }

            string finalImagePath = "";

            if (!string.IsNullOrEmpty(sourceFilePath))
            {
                string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(sourceFilePath);
                string destinationPath = Path.Combine(imagesDirectory, newFileName);
                File.Copy(sourceFilePath, destinationPath);
                finalImagePath = destinationPath;
            }

            Book newBook = new Book()
            {
                Title = txt_title.Texts,
                Price = price, 
                Quantity = qty,
                Description = txt_desc.Texts,
                Brief = txt_brief.Texts,
                PublishDate = dtp_publishDate.Value,

                categoryId = (int)cb_categories.SelectedValue,
                authorId = currentAuthorId,
                photoSourceString = finalImagePath
            };

            libraryContext.Books.Add(newBook);
            libraryContext.SaveChanges();

            MessageBox.Show("Book Added Successfully!");
            this.Hide();
            Home home = new Home(currentAuthorId);
            home.Show();
        }
    }
}