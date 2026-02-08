namespace WinFormsApp1
{
    using WinFormsApp1.Controls;
    using WinFormsApp1.Helpers;

    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txt_email = new ModernTextBox();
            txt_password = new ModernTextBox();
            label1 = new Label();
            label2 = new Label();
            btn_login = new RoundedButton();
            btn_register = new RoundedButton(); // Use RoundedButton
            SuspendLayout();
            // 
            // txt_email
            // 
            txt_email.Location = new Point(204, 85);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(361, 35);
            txt_email.PlaceholderText = "Enter your email";
            txt_email.BorderRadius = 15;
            txt_email.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(204, 181);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(361, 35);
            txt_password.PlaceholderText = "Enter your password";
            txt_password.PasswordChar = true;
            txt_password.BorderRadius = 15;
            txt_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 45);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 144);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BackColor = UIHelper.PrimaryColor;
            btn_login.BorderColor = Color.Transparent;
            btn_login.BorderRadius = 20;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(204, 264);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(150, 40);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = UIHelper.SecondaryColor; // Emerald
            btn_register.BorderColor = Color.Transparent;
            btn_register.BorderRadius = 20;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(415, 264);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(150, 40);
            btn_register.TabIndex = 5;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }


        private ModernTextBox txt_email;
        private ModernTextBox txt_password;
        private Label label1;
        private Label label2;
        private RoundedButton btn_login;
        private RoundedButton btn_register;
    }
}