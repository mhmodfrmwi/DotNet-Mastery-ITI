namespace WinFormsApp1
{
    using WinFormsApp1.Controls;

    partial class BookDetails
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
            pic_book = new PictureBox();
            txt_title = new ModernTextBox();
            txt_desc = new ModernTextBox();
            txt_brief = new ModernTextBox();
            txt_date = new ModernTextBox();
            txt_price = new ModernTextBox();
            lblName = new Label();
            txt_quantity = new ModernTextBox();
            txt_author = new ModernTextBox();
            txt_category = new ModernTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_book).BeginInit();
            SuspendLayout();
            // 
            // pic_book
            // 
            pic_book.Location = new Point(146, 22);
            pic_book.Name = "pic_book";
            pic_book.Size = new Size(482, 181);
            pic_book.TabIndex = 0;
            pic_book.TabStop = false;
            // 
            // txt_title
            // 
            txt_title.BackColor = SystemColors.Window;
            txt_title.BorderColor = Color.MediumSlateBlue;
            txt_title.BorderFocusColor = Color.HotPink;
            txt_title.BorderRadius = 15;
            txt_title.BorderSize = 2;
            txt_title.Enabled = false;
            txt_title.ForeColor = Color.DimGray;
            txt_title.Location = new Point(146, 244);
            txt_title.Multiline = false;
            txt_title.Name = "txt_title";
            txt_title.Padding = new Padding(10, 7, 10, 7);
            txt_title.PasswordChar = false;
            txt_title.PlaceholderColor = Color.DarkGray;
            txt_title.PlaceholderText = "Title";
            txt_title.Size = new Size(249, 35);
            txt_title.TabIndex = 1;
            txt_title.Texts = "";
            txt_title.UnderlinedStyle = false;
            // 
            // txt_desc
            // 
            txt_desc.BackColor = SystemColors.Window;
            txt_desc.BorderColor = Color.MediumSlateBlue;
            txt_desc.BorderFocusColor = Color.HotPink;
            txt_desc.BorderRadius = 15;
            txt_desc.BorderSize = 2;
            txt_desc.Enabled = false;
            txt_desc.ForeColor = Color.DimGray;
            txt_desc.Location = new Point(146, 304);
            txt_desc.Multiline = false;
            txt_desc.Name = "txt_desc";
            txt_desc.Padding = new Padding(10, 7, 10, 7);
            txt_desc.PasswordChar = false;
            txt_desc.PlaceholderColor = Color.DarkGray;
            txt_desc.PlaceholderText = "Description";
            txt_desc.Size = new Size(249, 35);
            txt_desc.TabIndex = 2;
            txt_desc.Texts = "";
            txt_desc.UnderlinedStyle = false;
            // 
            // txt_brief
            // 
            txt_brief.BackColor = SystemColors.Window;
            txt_brief.BorderColor = Color.MediumSlateBlue;
            txt_brief.BorderFocusColor = Color.HotPink;
            txt_brief.BorderRadius = 15;
            txt_brief.BorderSize = 2;
            txt_brief.Enabled = false;
            txt_brief.ForeColor = Color.DimGray;
            txt_brief.Location = new Point(146, 365);
            txt_brief.Multiline = false;
            txt_brief.Name = "txt_brief";
            txt_brief.Padding = new Padding(10, 7, 10, 7);
            txt_brief.PasswordChar = false;
            txt_brief.PlaceholderColor = Color.DarkGray;
            txt_brief.PlaceholderText = "Brief";
            txt_brief.Size = new Size(249, 35);
            txt_brief.TabIndex = 3;
            txt_brief.Texts = "";
            txt_brief.UnderlinedStyle = false;
            // 
            // txt_date
            // 
            txt_date.BackColor = SystemColors.Window;
            txt_date.BorderColor = Color.MediumSlateBlue;
            txt_date.BorderFocusColor = Color.HotPink;
            txt_date.BorderRadius = 15;
            txt_date.BorderSize = 2;
            txt_date.Enabled = false;
            txt_date.ForeColor = Color.DimGray;
            txt_date.Location = new Point(146, 435);
            txt_date.Multiline = false;
            txt_date.Name = "txt_date";
            txt_date.Padding = new Padding(10, 7, 10, 7);
            txt_date.PasswordChar = false;
            txt_date.PlaceholderColor = Color.DarkGray;
            txt_date.PlaceholderText = "Date";
            txt_date.Size = new Size(249, 35);
            txt_date.TabIndex = 4;
            txt_date.Texts = "";
            txt_date.UnderlinedStyle = false;
            // 
            // txt_price
            // 
            txt_price.BackColor = SystemColors.Window;
            txt_price.BorderColor = Color.MediumSlateBlue;
            txt_price.BorderFocusColor = Color.HotPink;
            txt_price.BorderRadius = 15;
            txt_price.BorderSize = 2;
            txt_price.Enabled = false;
            txt_price.ForeColor = Color.DimGray;
            txt_price.Location = new Point(485, 244);
            txt_price.Multiline = false;
            txt_price.Name = "txt_price";
            txt_price.Padding = new Padding(10, 7, 10, 7);
            txt_price.PasswordChar = false;
            txt_price.PlaceholderColor = Color.DarkGray;
            txt_price.PlaceholderText = "Price";
            txt_price.Size = new Size(249, 35);
            txt_price.TabIndex = 5;
            txt_price.Texts = "";
            txt_price.UnderlinedStyle = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(29, 247);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Title";
            // 
            // txt_quantity
            // 
            txt_quantity.BackColor = SystemColors.Window;
            txt_quantity.BorderColor = Color.MediumSlateBlue;
            txt_quantity.BorderFocusColor = Color.HotPink;
            txt_quantity.BorderRadius = 15;
            txt_quantity.BorderSize = 2;
            txt_quantity.Enabled = false;
            txt_quantity.ForeColor = Color.DimGray;
            txt_quantity.Location = new Point(485, 304);
            txt_quantity.Multiline = false;
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Padding = new Padding(10, 7, 10, 7);
            txt_quantity.PasswordChar = false;
            txt_quantity.PlaceholderColor = Color.DarkGray;
            txt_quantity.PlaceholderText = "Quantity";
            txt_quantity.Size = new Size(249, 35);
            txt_quantity.TabIndex = 7;
            txt_quantity.Texts = "";
            txt_quantity.UnderlinedStyle = false;
            // 
            // txt_author
            // 
            txt_author.BackColor = SystemColors.Window;
            txt_author.BorderColor = Color.MediumSlateBlue;
            txt_author.BorderFocusColor = Color.HotPink;
            txt_author.BorderRadius = 15;
            txt_author.BorderSize = 2;
            txt_author.Enabled = false;
            txt_author.ForeColor = Color.DimGray;
            txt_author.Location = new Point(485, 365);
            txt_author.Multiline = false;
            txt_author.Name = "txt_author";
            txt_author.Padding = new Padding(10, 7, 10, 7);
            txt_author.PasswordChar = false;
            txt_author.PlaceholderColor = Color.DarkGray;
            txt_author.PlaceholderText = "Author";
            txt_author.Size = new Size(249, 35);
            txt_author.TabIndex = 8;
            txt_author.Texts = "";
            txt_author.UnderlinedStyle = false;
            // 
            // txt_category
            // 
            txt_category.BackColor = SystemColors.Window;
            txt_category.BorderColor = Color.MediumSlateBlue;
            txt_category.BorderFocusColor = Color.HotPink;
            txt_category.BorderRadius = 15;
            txt_category.BorderSize = 2;
            txt_category.Enabled = false;
            txt_category.ForeColor = Color.DimGray;
            txt_category.Location = new Point(485, 435);
            txt_category.Multiline = false;
            txt_category.Name = "txt_category";
            txt_category.Padding = new Padding(10, 7, 10, 7);
            txt_category.PasswordChar = false;
            txt_category.PlaceholderColor = Color.DarkGray;
            txt_category.PlaceholderText = "Category";
            txt_category.Size = new Size(249, 35);
            txt_category.TabIndex = 9;
            txt_category.Texts = "";
            txt_category.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 307);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 10;
            label1.Text = "Description";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 365);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 11;
            label2.Text = "Brief";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 435);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 12;
            label3.Text = "Publish Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 247);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 13;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 307);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 14;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 368);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 15;
            label6.Text = "Author";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(412, 435);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 16;
            label7.Text = "Category";
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_category);
            Controls.Add(txt_author);
            Controls.Add(txt_quantity);
            Controls.Add(lblName);
            Controls.Add(txt_price);
            Controls.Add(txt_date);
            Controls.Add(txt_brief);
            Controls.Add(txt_desc);
            Controls.Add(txt_title);
            Controls.Add(pic_book);
            Name = "BookDetails";
            Text = "BookDetails";
            ((System.ComponentModel.ISupportInitialize)pic_book).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_book;
        private ModernTextBox txt_title;
        private ModernTextBox txt_desc;
        private ModernTextBox txt_brief;
        private ModernTextBox txt_date;
        private ModernTextBox txt_price;
        private Label lblName;
        private ModernTextBox txt_quantity;
        private ModernTextBox txt_author;
        private ModernTextBox txt_category;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}