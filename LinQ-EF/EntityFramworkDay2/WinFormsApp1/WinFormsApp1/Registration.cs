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
    public partial class Registration : Form
    {
        LibraryContext libraryContext;
        public Registration()
        {
            InitializeComponent();
            libraryContext = new LibraryContext();
            UIHelper.ApplyTheme(this);
            UIHelper.StyleSecondaryButton(btn_login);
        }

        private void btn_regiter_Click(object sender, EventArgs e)
        {
            string randomSuffix = Guid.NewGuid().ToString("n").Substring(0, 4);
            string finalUserName = txt_name.Texts.Replace(" ", "") + randomSuffix; // use Texts
            Author author = new Author()
            {
                Name = txt_name.Texts,
                Age = int.Parse(txt_age.Texts),
                Address = txt_address.Texts,
                Email = txt_email.Texts,
                Password = txt_password.Texts,
                Brief = txt_brief.Texts,
                Phone = txt_phone.Texts,
                userName = finalUserName,
            };
            libraryContext.Authors.Add(author);
            libraryContext.SaveChanges();
            MessageBox.Show("Registration made successfully");
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
