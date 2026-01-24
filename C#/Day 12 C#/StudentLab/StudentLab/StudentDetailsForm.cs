using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace StudentLab
{
    public partial class StudentDetailsForm : Form
    {
        private void StudentDetailsForm_Load(object sender, EventArgs e)
        {
        }
        public StudentDetailsForm(Student s)
        {
            InitializeComponent();

            lblId.Text = s.Id.ToString();
            lblName.Text = s.Name;
            lblDept.Text = s.Department;
            lblGender.Text = s.Gender;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
