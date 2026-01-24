namespace StudentLab
{
    partial class AddStudentForm
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
            txtName = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbDepartment = new ComboBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            Department = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(137, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(137, 39);
            txtId.Name = "txtId";
            txtId.Size = new Size(183, 27);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 104);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 46);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 3;
            label2.Text = "Id";
            label2.Click += label2_Click;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Items.AddRange(new object[] { "PD", "OS" });
            cbDepartment.Location = new Point(137, 185);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(151, 28);
            cbDepartment.TabIndex = 4;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(137, 244);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 5;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(293, 244);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(70, 24);
            rbFemale.TabIndex = 6;
            rbFemale.TabStop = true;
            rbFemale.Text = "Femal";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.Location = new Point(23, 193);
            Department.Name = "Department";
            Department.Size = new Size(89, 20);
            Department.TabIndex = 7;
            Department.Text = "Department";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(137, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 450);
            Controls.Add(btnAdd);
            Controls.Add(Department);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(cbDepartment);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            Load += AddStudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtId;
        private Label label1;
        private Label label2;
        private ComboBox cbDepartment;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label Department;
        private Button btnAdd;
    }
}