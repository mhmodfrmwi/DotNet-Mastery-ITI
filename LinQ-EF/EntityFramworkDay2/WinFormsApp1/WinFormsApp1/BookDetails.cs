using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Models;

using WinFormsApp1.Helpers;

namespace WinFormsApp1
{
    public partial class BookDetails : Form
    {
        int bookId;
        LibraryContext LibraryContext;
        public BookDetails(int id)
        {
            InitializeComponent();
            LibraryContext = new LibraryContext();
            bookId= id;
            UIHelper.ApplyTheme(this);
            loadBook();
        }
        private void loadBook()
        {
            var book = LibraryContext.Books
            .Include(b => b.Author)   
            .Include(b => b.Category) 
            .SingleOrDefault(b => b.Id == bookId); 

            if (book != null)
            {
                txt_title.Texts = book.Title;
                txt_desc.Texts = book.Description;
                txt_brief.Texts = book.Brief;

                
                txt_author.Texts = book.Author?.Name;
                txt_category.Texts = book.Category?.Name;

                txt_price.Texts = book.Price.ToString();
                txt_quantity.Texts = book.Quantity.ToString();
                txt_date.Texts = book.PublishDate.ToShortDateString(); 

                if (!string.IsNullOrEmpty(book.photoSourceString) && File.Exists(book.photoSourceString))
                {
                    pic_book.ImageLocation = book.photoSourceString;
                    pic_book.SizeMode = PictureBoxSizeMode.StretchImage; 
                }
                else
                {
                    pic_book.Image = null;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
