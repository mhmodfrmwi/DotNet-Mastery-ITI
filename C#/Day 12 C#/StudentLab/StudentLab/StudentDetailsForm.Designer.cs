namespace StudentLab
{
    partial class StudentDetailsForm
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
            lblName = new Label();
            lblDept = new Label();
            lblId = new Label();
            lblGender = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(248, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new Point(484, 45);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(50, 20);
            lblDept.TabIndex = 1;
            lblDept.Text = "label2";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(55, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(50, 20);
            lblId.TabIndex = 2;
            lblId.Text = "label3";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(658, 45);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(50, 20);
            lblGender.TabIndex = 3;
            lblGender.Text = "label4";
            // 
            // StudentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGender);
            Controls.Add(lblId);
            Controls.Add(lblDept);
            Controls.Add(lblName);
            Name = "StudentDetailsForm";
            Text = "StudentDetailsForm";
            Load += StudentDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDept;
        private Label lblId;
        private Label lblGender;
    }
}