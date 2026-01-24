using System;
using System.Windows.Forms;

namespace StudentLab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void btnOpenAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();

            this.Hide();

            addForm.ShowDialog();

            this.Show();
        }

        private void btnOpenList_Click(object sender, EventArgs e)
        {
            StudentListForm listForm = new StudentListForm();

            this.Hide();

            listForm.ShowDialog();

            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}