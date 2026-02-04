namespace ADODay01
{
    partial class Form1
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
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.cb_dept = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.Lbl_Fname = new System.Windows.Forms.Label();
            this.Lbl_Lname = new System.Windows.Forms.Label();
            this.Lbl_Age = new System.Windows.Forms.Label();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.Lbl_Dept = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cb_FullName = new System.Windows.Forms.ComboBox();
            this.btn_deleteStudent = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_updateStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_student
            // 
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Location = new System.Drawing.Point(12, 349);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.RowHeadersWidth = 51;
            this.dgv_student.RowTemplate.Height = 24;
            this.dgv_student.Size = new System.Drawing.Size(921, 224);
            this.dgv_student.TabIndex = 0;
            this.dgv_student.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_student_RowHeaderMouseDoubleClick);
            // 
            // txt_Fname
            // 
            this.txt_Fname.Location = new System.Drawing.Point(696, 69);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(139, 22);
            this.txt_Fname.TabIndex = 2;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(696, 154);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(139, 22);
            this.txt_age.TabIndex = 4;
            // 
            // txt_Lname
            // 
            this.txt_Lname.Location = new System.Drawing.Point(696, 111);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(139, 22);
            this.txt_Lname.TabIndex = 3;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(696, 198);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(139, 22);
            this.txt_address.TabIndex = 5;
            // 
            // cb_dept
            // 
            this.cb_dept.FormattingEnabled = true;
            this.cb_dept.Location = new System.Drawing.Point(696, 236);
            this.cb_dept.Name = "cb_dept";
            this.cb_dept.Size = new System.Drawing.Size(139, 24);
            this.cb_dept.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(760, 281);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Lbl_Fname
            // 
            this.Lbl_Fname.AutoSize = true;
            this.Lbl_Fname.Location = new System.Drawing.Point(620, 75);
            this.Lbl_Fname.Name = "Lbl_Fname";
            this.Lbl_Fname.Size = new System.Drawing.Size(69, 16);
            this.Lbl_Fname.TabIndex = 9;
            this.Lbl_Fname.Text = "FirstName";
            // 
            // Lbl_Lname
            // 
            this.Lbl_Lname.AutoSize = true;
            this.Lbl_Lname.Location = new System.Drawing.Point(620, 117);
            this.Lbl_Lname.Name = "Lbl_Lname";
            this.Lbl_Lname.Size = new System.Drawing.Size(69, 16);
            this.Lbl_Lname.TabIndex = 10;
            this.Lbl_Lname.Text = "LastName";
            // 
            // Lbl_Age
            // 
            this.Lbl_Age.AutoSize = true;
            this.Lbl_Age.Location = new System.Drawing.Point(620, 157);
            this.Lbl_Age.Name = "Lbl_Age";
            this.Lbl_Age.Size = new System.Drawing.Size(32, 16);
            this.Lbl_Age.TabIndex = 11;
            this.Lbl_Age.Text = "Age";
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Location = new System.Drawing.Point(620, 198);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.Size = new System.Drawing.Size(58, 16);
            this.Lbl_Address.TabIndex = 12;
            this.Lbl_Address.Text = "Address";
            // 
            // Lbl_Dept
            // 
            this.Lbl_Dept.AutoSize = true;
            this.Lbl_Dept.Location = new System.Drawing.Point(612, 239);
            this.Lbl_Dept.Name = "Lbl_Dept";
            this.Lbl_Dept.Size = new System.Drawing.Size(77, 16);
            this.Lbl_Dept.TabIndex = 13;
            this.Lbl_Dept.Text = "Department";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.ForeColor = System.Drawing.Color.Lime;
            this.lbl_status.Location = new System.Drawing.Point(791, 319);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 16);
            this.lbl_status.TabIndex = 14;
            // 
            // cb_FullName
            // 
            this.cb_FullName.FormattingEnabled = true;
            this.cb_FullName.Location = new System.Drawing.Point(45, 39);
            this.cb_FullName.Name = "cb_FullName";
            this.cb_FullName.Size = new System.Drawing.Size(141, 24);
            this.cb_FullName.TabIndex = 15;
            // 
            // btn_deleteStudent
            // 
            this.btn_deleteStudent.Location = new System.Drawing.Point(226, 39);
            this.btn_deleteStudent.Name = "btn_deleteStudent";
            this.btn_deleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteStudent.TabIndex = 16;
            this.btn_deleteStudent.Text = "Delete";
            this.btn_deleteStudent.UseVisualStyleBackColor = true;
            this.btn_deleteStudent.Click += new System.EventHandler(this.btn_deleteStudent_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(666, 281);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(673, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 18;
            // 
            // lbl_updateStatus
            // 
            this.lbl_updateStatus.AutoSize = true;
            this.lbl_updateStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_updateStatus.Location = new System.Drawing.Point(663, 319);
            this.lbl_updateStatus.Name = "lbl_updateStatus";
            this.lbl_updateStatus.Size = new System.Drawing.Size(0, 16);
            this.lbl_updateStatus.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 585);
            this.Controls.Add(this.lbl_updateStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_deleteStudent);
            this.Controls.Add(this.cb_FullName);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.Lbl_Dept);
            this.Controls.Add(this.Lbl_Address);
            this.Controls.Add(this.Lbl_Age);
            this.Controls.Add(this.Lbl_Lname);
            this.Controls.Add(this.Lbl_Fname);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_dept);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.dgv_student);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.ComboBox cb_dept;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label Lbl_Fname;
        private System.Windows.Forms.Label Lbl_Lname;
        private System.Windows.Forms.Label Lbl_Age;
        private System.Windows.Forms.Label Lbl_Address;
        private System.Windows.Forms.Label Lbl_Dept;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cb_FullName;
        private System.Windows.Forms.Button btn_deleteStudent;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_updateStatus;
    }
}

