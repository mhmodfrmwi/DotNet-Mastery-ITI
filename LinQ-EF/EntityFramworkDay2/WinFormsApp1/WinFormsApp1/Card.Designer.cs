namespace WinFormsApp1
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picBook = new PictureBox();
            lblTitle = new Label();
            lblAuthor = new Label();
            ((System.ComponentModel.ISupportInitialize)picBook).BeginInit();
            SuspendLayout();
            // 
            // picBook
            // 
            picBook.Location = new Point(23, 19);
            picBook.Name = "picBook";
            picBook.Size = new Size(240, 182);
            picBook.TabIndex = 0;
            picBook.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(23, 232);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "label1";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(23, 266);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(50, 20);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "label1";
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(picBook);
            Name = "Card";
            Size = new Size(297, 335);
            ((System.ComponentModel.ISupportInitialize)picBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBook;
        private Label lblTitle;
        private Label lblAuthor;
    }
}
