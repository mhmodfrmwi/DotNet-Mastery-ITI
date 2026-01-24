namespace StudentLab
{
    partial class MainForm
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
            btnAddStudent = new Button();
            btnListStudents = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(153, 238);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(156, 29);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnOpenAdd_Click;
            // 
            // btnListStudents
            // 
            btnListStudents.Location = new Point(554, 238);
            btnListStudents.Name = "btnListStudents";
            btnListStudents.Size = new Size(118, 29);
            btnListStudents.TabIndex = 1;
            btnListStudents.Text = "List Students";
            btnListStudents.UseVisualStyleBackColor = true;
            btnListStudents.Click += btnOpenList_Click;
            // 
            // button1
            // 
            button1.Location = new Point(370, 389);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 542);
            Controls.Add(button1);
            Controls.Add(btnListStudents);
            Controls.Add(btnAddStudent);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddStudent;
        private Button btnListStudents;
        private Button button1;
    }
}
