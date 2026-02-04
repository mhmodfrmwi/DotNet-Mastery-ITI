namespace EnitityFramwork
{
    partial class CoursesForm
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
            DVG_Course = new DataGridView();
            txt_name = new TextBox();
            txt_duration = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmp_topic = new ComboBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)DVG_Course).BeginInit();
            SuspendLayout();
            // 
            // DVG_Course
            // 
            DVG_Course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVG_Course.Location = new Point(12, 299);
            DVG_Course.Name = "DVG_Course";
            DVG_Course.RowHeadersWidth = 51;
            DVG_Course.Size = new Size(1152, 278);
            DVG_Course.TabIndex = 0;
            DVG_Course.RowHeaderMouseDoubleClick += DVG_Course_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(919, 57);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 1;
            // 
            // txt_duration
            // 
            txt_duration.Location = new Point(690, 58);
            txt_duration.Name = "txt_duration";
            txt_duration.Size = new Size(125, 27);
            txt_duration.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(953, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(713, 29);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 29);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 6;
            label3.Text = "Topic";
            // 
            // cmp_topic
            // 
            cmp_topic.FormattingEnabled = true;
            cmp_topic.Location = new Point(470, 58);
            cmp_topic.Name = "cmp_topic";
            cmp_topic.Size = new Size(151, 28);
            cmp_topic.TabIndex = 7;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(1002, 250);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 8;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(824, 250);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(652, 250);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 589);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(cmp_topic);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_duration);
            Controls.Add(txt_name);
            Controls.Add(DVG_Course);
            Name = "CoursesForm";
            Text = "CoursesForm";
            ((System.ComponentModel.ISupportInitialize)DVG_Course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DVG_Course;
        private TextBox txt_name;
        private TextBox txt_duration;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmp_topic;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
    }
}