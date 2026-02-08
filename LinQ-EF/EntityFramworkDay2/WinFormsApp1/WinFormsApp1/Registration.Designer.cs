namespace WinFormsApp1
{
    using WinFormsApp1.Controls;
    using WinFormsApp1.Helpers;

    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_name = new ModernTextBox();
            txt_email = new ModernTextBox();
            txt_password = new ModernTextBox();
            txt_phone = new ModernTextBox();
            txt_brief = new ModernTextBox();
            txt_address = new ModernTextBox();
            txt_age = new ModernTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_regiter = new RoundedButton();
            btn_login = new RoundedButton();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.Window;
            txt_name.BorderColor = Color.MediumSlateBlue;
            txt_name.BorderFocusColor = Color.HotPink;
            txt_name.BorderRadius = 15;
            txt_name.BorderSize = 2;
            txt_name.ForeColor = Color.DimGray;
            txt_name.Location = new Point(190, 48);
            txt_name.Multiline = false;
            txt_name.Name = "txt_name";
            txt_name.Padding = new Padding(10, 7, 10, 7);
            txt_name.PasswordChar = false;
            txt_name.PlaceholderColor = Color.DarkGray;
            txt_name.PlaceholderText = "Full Name";
            txt_name.Size = new Size(200, 35);
            txt_name.TabIndex = 0;
            txt_name.Texts = "";
            txt_name.UnderlinedStyle = false;
            // 
            // txt_email
            // 
            txt_email.BackColor = SystemColors.Window;
            txt_email.BorderColor = Color.MediumSlateBlue;
            txt_email.BorderFocusColor = Color.HotPink;
            txt_email.BorderRadius = 15;
            txt_email.BorderSize = 2;
            txt_email.ForeColor = Color.DimGray;
            txt_email.Location = new Point(190, 93);
            txt_email.Multiline = false;
            txt_email.Name = "txt_email";
            txt_email.Padding = new Padding(10, 7, 10, 7);
            txt_email.PasswordChar = false;
            txt_email.PlaceholderColor = Color.DarkGray;
            txt_email.PlaceholderText = "Email Address";
            txt_email.Size = new Size(200, 35);
            txt_email.TabIndex = 1;
            txt_email.Texts = "";
            txt_email.UnderlinedStyle = false;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.Window;
            txt_password.BorderColor = Color.MediumSlateBlue;
            txt_password.BorderFocusColor = Color.HotPink;
            txt_password.BorderRadius = 15;
            txt_password.BorderSize = 2;
            txt_password.ForeColor = Color.DimGray;
            txt_password.Location = new Point(190, 194);
            txt_password.Multiline = false;
            txt_password.Name = "txt_password";
            txt_password.Padding = new Padding(10, 7, 10, 7);
            txt_password.PasswordChar = true;
            txt_password.PlaceholderColor = Color.DarkGray;
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(200, 35);
            txt_password.TabIndex = 2;
            txt_password.Texts = "";
            txt_password.UnderlinedStyle = false;
            // 
            // txt_phone
            // 
            txt_phone.BackColor = SystemColors.Window;
            txt_phone.BorderColor = Color.MediumSlateBlue;
            txt_phone.BorderFocusColor = Color.HotPink;
            txt_phone.BorderRadius = 15;
            txt_phone.BorderSize = 2;
            txt_phone.ForeColor = Color.DimGray;
            txt_phone.Location = new Point(190, 279);
            txt_phone.Multiline = false;
            txt_phone.Name = "txt_phone";
            txt_phone.Padding = new Padding(10, 7, 10, 7);
            txt_phone.PasswordChar = false;
            txt_phone.PlaceholderColor = Color.DarkGray;
            txt_phone.PlaceholderText = "Phone Number";
            txt_phone.Size = new Size(200, 35);
            txt_phone.TabIndex = 3;
            txt_phone.Texts = "";
            txt_phone.UnderlinedStyle = false;
            // 
            // txt_brief
            // 
            txt_brief.BackColor = SystemColors.Window;
            txt_brief.BorderColor = Color.MediumSlateBlue;
            txt_brief.BorderFocusColor = Color.HotPink;
            txt_brief.BorderRadius = 15;
            txt_brief.BorderSize = 2;
            txt_brief.ForeColor = Color.DimGray;
            txt_brief.Location = new Point(190, 331);
            txt_brief.Multiline = true;
            txt_brief.Name = "txt_brief";
            txt_brief.Padding = new Padding(10, 7, 10, 7);
            txt_brief.PasswordChar = false;
            txt_brief.PlaceholderColor = Color.DarkGray;
            txt_brief.PlaceholderText = "Short Bio";
            txt_brief.Size = new Size(200, 35);
            txt_brief.TabIndex = 4;
            txt_brief.Texts = "";
            txt_brief.UnderlinedStyle = false;
            // 
            // txt_address
            // 
            txt_address.BackColor = SystemColors.Window;
            txt_address.BorderColor = Color.MediumSlateBlue;
            txt_address.BorderFocusColor = Color.HotPink;
            txt_address.BorderRadius = 15;
            txt_address.BorderSize = 2;
            txt_address.ForeColor = Color.DimGray;
            txt_address.Location = new Point(190, 237);
            txt_address.Multiline = false;
            txt_address.Name = "txt_address";
            txt_address.Padding = new Padding(10, 7, 10, 7);
            txt_address.PasswordChar = false;
            txt_address.PlaceholderColor = Color.DarkGray;
            txt_address.PlaceholderText = "Address";
            txt_address.Size = new Size(200, 35);
            txt_address.TabIndex = 5;
            txt_address.Texts = "";
            txt_address.UnderlinedStyle = false;
            // 
            // txt_age
            // 
            txt_age.BackColor = SystemColors.Window;
            txt_age.BorderColor = Color.MediumSlateBlue;
            txt_age.BorderFocusColor = Color.HotPink;
            txt_age.BorderRadius = 15;
            txt_age.BorderSize = 2;
            txt_age.ForeColor = Color.DimGray;
            txt_age.Location = new Point(190, 142);
            txt_age.Multiline = false;
            txt_age.Name = "txt_age";
            txt_age.Padding = new Padding(10, 7, 10, 7);
            txt_age.PasswordChar = false;
            txt_age.PlaceholderColor = Color.DarkGray;
            txt_age.PlaceholderText = "Age";
            txt_age.Size = new Size(100, 35);
            txt_age.TabIndex = 6;
            txt_age.Texts = "";
            txt_age.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 55);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 100);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 150);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 9;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 200);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 245);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 11;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(80, 285);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 12;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 340);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 13;
            label7.Text = "Brief";
            // 
            // btn_regiter
            // 
            btn_regiter.BackColor = Color.FromArgb(37, 99, 235);
            btn_regiter.BorderColor = Color.Transparent;
            btn_regiter.BorderRadius = 20;
            btn_regiter.BorderSize = 0;
            btn_regiter.FlatStyle = FlatStyle.Flat;
            btn_regiter.ForeColor = Color.White;
            btn_regiter.Location = new Point(190, 430);
            btn_regiter.Name = "btn_regiter";
            btn_regiter.Size = new Size(130, 40);
            btn_regiter.TabIndex = 14;
            btn_regiter.Text = "Register";
            btn_regiter.UseVisualStyleBackColor = false;
            btn_regiter.Click += btn_regiter_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(100, 116, 139);
            btn_login.BorderColor = Color.Transparent;
            btn_login.BorderRadius = 20;
            btn_login.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(340, 430);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(130, 40);
            btn_login.TabIndex = 15;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 591);
            Controls.Add(btn_login);
            Controls.Add(btn_regiter);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_age);
            Controls.Add(txt_address);
            Controls.Add(txt_brief);
            Controls.Add(txt_phone);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ModernTextBox txt_name;
        private ModernTextBox txt_email;
        private ModernTextBox txt_password;
        private ModernTextBox txt_phone;
        private ModernTextBox txt_brief;
        private ModernTextBox txt_address;
        private ModernTextBox txt_age;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RoundedButton btn_regiter;
        private RoundedButton btn_login;
    }
}