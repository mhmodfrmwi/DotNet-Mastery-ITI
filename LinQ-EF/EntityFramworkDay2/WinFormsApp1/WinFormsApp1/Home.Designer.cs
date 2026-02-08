namespace WinFormsApp1
{
    partial class Home
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
            button1 = new Button();
            flowLayoutPanelBooks = new FlowLayoutPanel();
            btn_add = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 38);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 0;
            button1.Text = "Show profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanelBooks
            // 
            flowLayoutPanelBooks.AutoScroll = true;
            flowLayoutPanelBooks.Location = new Point(24, 113);
            flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            flowLayoutPanelBooks.Size = new Size(751, 325);
            flowLayoutPanelBooks.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(174, 38);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add Book";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add);
            Controls.Add(flowLayoutPanelBooks);
            Controls.Add(button1);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanelBooks;
        private Button btn_add;
    }
}