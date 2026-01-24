namespace StudentLab
{
    partial class StudentListForm
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
            dgvStudents = new DataGridView();
            btnShowDetails = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(104, 102);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(572, 238);
            dgvStudents.TabIndex = 0;
            // 
            // btnShowDetails
            // 
            btnShowDetails.Location = new Point(134, 376);
            btnShowDetails.Name = "btnShowDetails";
            btnShowDetails.Size = new Size(117, 29);
            btnShowDetails.TabIndex = 1;
            btnShowDetails.Text = "Show details";
            btnShowDetails.UseVisualStyleBackColor = true;
            btnShowDetails.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(518, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(104, 47);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(147, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(543, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 450);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnShowDetails);
            Controls.Add(dgvStudents);
            Name = "StudentListForm";
            Text = "StudentListForm";
            Load += StudentListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private Button btnShowDetails;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}