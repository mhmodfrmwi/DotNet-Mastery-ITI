namespace EnitityFramwork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DVG_Students = new DataGridView();
            St_Fname = new TextBox();
            St_Lname = new TextBox();
            St_Age = new TextBox();
            St_Adress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dept_cmp = new ComboBox();
            supr_cmp = new ComboBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)DVG_Students).BeginInit();
            SuspendLayout();
            // 
            // DVG_Students
            // 
            DVG_Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVG_Students.Location = new Point(28, 250);
            DVG_Students.Name = "DVG_Students";
            DVG_Students.RowHeadersWidth = 51;
            DVG_Students.Size = new Size(1142, 382);
            DVG_Students.TabIndex = 0;
            DVG_Students.CellContentClick += dataGridView1_CellContentClick;
            DVG_Students.RowHeaderMouseDoubleClick += DVG_Students_RowHeaderMouseDoubleClick;
            // 
            // St_Fname
            // 
            St_Fname.Location = new Point(28, 30);
            St_Fname.Name = "St_Fname";
            St_Fname.Size = new Size(125, 27);
            St_Fname.TabIndex = 1;
            // 
            // St_Lname
            // 
            St_Lname.Location = new Point(173, 30);
            St_Lname.Name = "St_Lname";
            St_Lname.Size = new Size(125, 27);
            St_Lname.TabIndex = 2;
            // 
            // St_Age
            // 
            St_Age.Location = new Point(339, 30);
            St_Age.Name = "St_Age";
            St_Age.Size = new Size(125, 27);
            St_Age.TabIndex = 3;
            // 
            // St_Adress
            // 
            St_Adress.Location = new Point(490, 30);
            St_Adress.Name = "St_Adress";
            St_Adress.Size = new Size(125, 27);
            St_Adress.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 6);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 4);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 6);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 9;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 5);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 10;
            label4.Text = "Adress";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(660, 4);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 11;
            label5.Text = "Departments";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(825, 4);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 12;
            label6.Text = "Supervisor";
            // 
            // dept_cmp
            // 
            dept_cmp.FormattingEnabled = true;
            dept_cmp.Location = new Point(642, 30);
            dept_cmp.Name = "dept_cmp";
            dept_cmp.Size = new Size(151, 28);
            dept_cmp.TabIndex = 13;
            // 
            // supr_cmp
            // 
            supr_cmp.FormattingEnabled = true;
            supr_cmp.Location = new Point(813, 30);
            supr_cmp.Name = "supr_cmp";
            supr_cmp.Size = new Size(151, 28);
            supr_cmp.TabIndex = 14;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(812, 149);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 15;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(661, 149);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 16;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(521, 149);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 17;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 644);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(supr_cmp);
            Controls.Add(dept_cmp);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(St_Adress);
            Controls.Add(St_Age);
            Controls.Add(St_Lname);
            Controls.Add(St_Fname);
            Controls.Add(DVG_Students);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DVG_Students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DVG_Students;
        private TextBox St_Fname;
        private TextBox St_Lname;
        private TextBox St_Age;
        private TextBox St_Adress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox dept_cmp;
        private ComboBox supr_cmp;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
    }
}
