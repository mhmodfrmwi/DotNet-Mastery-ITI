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
    public partial class Profile : Form
    {
        LibraryContext libraryContext;
        int currentAuthorId;
        public Profile(int id)
        {
            InitializeComponent();
            libraryContext = new LibraryContext();
            currentAuthorId = id;
            UIHelper.ApplyTheme(this);
            loadUser();
        }
        private void update_profile_Click(object sender, EventArgs e)
        {
            var existingAuthor = libraryContext.Authors.Find(currentAuthorId);

            if (existingAuthor != null)
            {
                existingAuthor.Name = txt_name.Texts;
                existingAuthor.Email = txt_email.Texts;
                existingAuthor.Password = txt_password.Texts;
                existingAuthor.Age=int.Parse(txt_age.Texts);
                existingAuthor.Brief = txt_brief.Texts;
                existingAuthor.Address = txt_address.Texts;
                existingAuthor.Phone = txt_phone.Texts;
                existingAuthor.userName = txt_username.Texts;

                libraryContext.SaveChanges();

                MessageBox.Show("Profile updated successfully!");
            }
            else
            {
                MessageBox.Show("user is not found");
            }

        }
        private void loadUser()
        {
            var author = libraryContext.Authors.Find(currentAuthorId);
            if (author != null)
            {
                txt_name.Texts = author.Name;
                txt_email.Texts = author.Email;
                txt_password.Texts = author.Password;
                txt_age.Texts = author.Age.ToString();
                txt_brief.Texts = author.Brief;
                txt_address.Texts = author.Address;
                txt_phone.Texts = author.Phone;
                txt_username.Texts = author.userName;
            }
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(currentAuthorId);
            home.Show();
        }
    }
}
