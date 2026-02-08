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
    public partial class Login : Form
    {
        LibraryContext libraryContext;
        public Login()
        {
            InitializeComponent();
            libraryContext=new LibraryContext();
            UIHelper.ApplyTheme(this);
            UIHelper.StyleSecondaryButton(btn_register); // Make register button secondary style
            UIHelper.StyleHeaderLabel(label1); // "Email" label
            UIHelper.StyleHeaderLabel(label2); // "Password" label
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                Email = txt_email.Texts, // Use Texts property for ModernTextBox
                Password = txt_password.Texts, // Use Texts property
            };
            var auth=libraryContext.Authors.Where(a=>a.Email.Equals(author.Email) && a.Password.Equals(author.Password)).SingleOrDefault();
            if (auth == null) {
                MessageBox.Show("Email or Password is not correct");
            }
            else
            {
                this.Hide();
                Home home = new Home(auth.Id);
                home.Show();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
