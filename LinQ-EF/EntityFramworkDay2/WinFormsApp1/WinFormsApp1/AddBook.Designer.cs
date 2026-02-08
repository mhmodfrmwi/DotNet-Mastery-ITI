namespace WinFormsApp1
{
    using WinFormsApp1.Controls;
    using WinFormsApp1.Helpers;

    partial class AddBook
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
            txt_title = new ModernTextBox();
            txt_desc = new ModernTextBox();
            txt_price = new ModernTextBox();
            txt_qty = new ModernTextBox();
            txt_brief = new ModernTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btn_upload_image = new RoundedButton();
            btn_add = new RoundedButton();
            pic_cover = new PictureBox();
            cb_categories = new ComboBox();
            dtp_publishDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pic_cover).BeginInit();
            SuspendLayout();
            // 
            // txt_title
            // 
            txt_title.BackColor = SystemColors.Window;
            txt_title.BorderColor = Color.MediumSlateBlue;
            txt_title.BorderFocusColor = Color.HotPink;
            txt_title.BorderRadius = 15;
            txt_title.BorderSize = 2;
            txt_title.ForeColor = Color.DimGray;
            txt_title.Location = new Point(133, 65);
            txt_title.Multiline = false;
            txt_title.Name = "txt_title";
            txt_title.Padding = new Padding(10, 7, 10, 7);
            txt_title.PasswordChar = false;
            txt_title.PlaceholderColor = Color.DarkGray;
            txt_title.PlaceholderText = "Book Title";
            txt_title.Size = new Size(200, 35);
            txt_title.TabIndex = 0;
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
            txt_desc.ForeColor = Color.DimGray;
            txt_desc.Location = new Point(133, 132);
            txt_desc.Multiline = false;
            txt_desc.Name = "txt_desc";
            txt_desc.Padding = new Padding(10, 7, 10, 7);
            txt_desc.PasswordChar = false;
            txt_desc.PlaceholderColor = Color.DarkGray;
            txt_desc.PlaceholderText = "Description";
            txt_desc.Size = new Size(200, 35);
            txt_desc.TabIndex = 1;
            txt_desc.Texts = "";
            txt_desc.UnderlinedStyle = false;
            // 
            // txt_price
            // 
            txt_price.BackColor = SystemColors.Window;
            txt_price.BorderColor = Color.MediumSlateBlue;
            txt_price.BorderFocusColor = Color.HotPink;
            txt_price.BorderRadius = 15;
            txt_price.BorderSize = 2;
            txt_price.ForeColor = Color.DimGray;
            txt_price.Location = new Point(133, 209);
            txt_price.Multiline = false;
            txt_price.Name = "txt_price";
            txt_price.Padding = new Padding(10, 7, 10, 7);
            txt_price.PasswordChar = false;
            txt_price.PlaceholderColor = Color.DarkGray;
            txt_price.PlaceholderText = "Price";
            txt_price.Size = new Size(125, 35);
            txt_price.TabIndex = 2;
            txt_price.Texts = "";
            txt_price.UnderlinedStyle = false;
            // 
            // txt_qty
            // 
            txt_qty.BackColor = SystemColors.Window;
            txt_qty.BorderColor = Color.MediumSlateBlue;
            txt_qty.BorderFocusColor = Color.HotPink;
            txt_qty.BorderRadius = 15;
            txt_qty.BorderSize = 2;
            txt_qty.ForeColor = Color.DimGray;
            txt_qty.Location = new Point(133, 275);
            txt_qty.Multiline = false;
            txt_qty.Name = "txt_qty";
            txt_qty.Padding = new Padding(10, 7, 10, 7);
            txt_qty.PasswordChar = false;
            txt_qty.PlaceholderColor = Color.DarkGray;
            txt_qty.PlaceholderText = "Qty";
            txt_qty.Size = new Size(125, 35);
            txt_qty.TabIndex = 3;
            txt_qty.Texts = "";
            txt_qty.UnderlinedStyle = false;
            // 
            // txt_brief
            // 
            txt_brief.BackColor = SystemColors.Window;
            txt_brief.BorderColor = Color.MediumSlateBlue;
            txt_brief.BorderFocusColor = Color.HotPink;
            txt_brief.BorderRadius = 15;
            txt_brief.BorderSize = 2;
            txt_brief.ForeColor = Color.DimGray;
            txt_brief.Location = new Point(550, 65);
            txt_brief.Multiline = false;
            txt_brief.Name = "txt_brief";
            txt_brief.Padding = new Padding(10, 7, 10, 7);
            txt_brief.PasswordChar = false;
            txt_brief.PlaceholderColor = Color.DarkGray;
            txt_brief.PlaceholderText = "Brief Summary";
            txt_brief.Size = new Size(200, 35);
            txt_brief.TabIndex = 4;
            txt_brief.Texts = "";
            txt_brief.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 72);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 8;
            label1.Text = "Brief";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 144);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 9;
            label2.Text = "Publish Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 216);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "Category";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(6, 72);
            label.Name = "label";
            label.Size = new Size(38, 20);
            label.TabIndex = 12;
            label.Text = "Title";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 140);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 13;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 212);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 14;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 290);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 15;
            label8.Text = "Quantity";
            // 
            // btn_upload_image
            // 
            btn_upload_image.BackColor = Color.FromArgb(71, 85, 105);
            btn_upload_image.BorderColor = Color.Transparent;
            btn_upload_image.BorderRadius = 20;
            btn_upload_image.BorderSize = 0;
            btn_upload_image.FlatStyle = FlatStyle.Flat;
            btn_upload_image.ForeColor = Color.White;
            btn_upload_image.Location = new Point(301, 548);
            btn_upload_image.Name = "btn_upload_image";
            btn_upload_image.Size = new Size(150, 40);
            btn_upload_image.TabIndex = 16;
            btn_upload_image.Text = "Upload Image";
            btn_upload_image.UseVisualStyleBackColor = false;
            btn_upload_image.Click += btn_upload_image_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(37, 99, 235);
            btn_add.BorderColor = Color.Transparent;
            btn_add.BorderRadius = 20;
            btn_add.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(301, 596);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(150, 40);
            btn_add.TabIndex = 17;
            btn_add.Text = "Add Book";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_save_book_Click;
            // 
            // pic_cover
            // 
            pic_cover.Location = new Point(250, 347);
            pic_cover.Name = "pic_cover";
            pic_cover.Size = new Size(234, 178);
            pic_cover.TabIndex = 18;
            pic_cover.TabStop = false;
            // 
            // cb_categories
            // 
            cb_categories.FormattingEnabled = true;
            cb_categories.Location = new Point(550, 216);
            cb_categories.Name = "cb_categories";
            cb_categories.Size = new Size(151, 28);
            cb_categories.TabIndex = 19;
            // 
            // dtp_publishDate
            // 
            dtp_publishDate.Location = new Point(550, 140);
            dtp_publishDate.Name = "dtp_publishDate";
            dtp_publishDate.Size = new Size(250, 27);
            dtp_publishDate.TabIndex = 20;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 688);
            Controls.Add(dtp_publishDate);
            Controls.Add(cb_categories);
            Controls.Add(pic_cover);
            Controls.Add(btn_add);
            Controls.Add(btn_upload_image);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_brief);
            Controls.Add(txt_qty);
            Controls.Add(txt_price);
            Controls.Add(txt_desc);
            Controls.Add(txt_title);
            Name = "AddBook";
            Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)pic_cover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ModernTextBox txt_title;
        private ModernTextBox txt_desc;
        private ModernTextBox txt_price;
        private ModernTextBox txt_qty;
        private ModernTextBox txt_brief;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label;
        private Label label6;
        private Label label7;
        private Label label8;
        private RoundedButton btn_upload_image;
        private RoundedButton btn_add;
        private PictureBox pic_cover;
        private ComboBox cb_categories;
        private DateTimePicker dtp_publishDate;
    }
}