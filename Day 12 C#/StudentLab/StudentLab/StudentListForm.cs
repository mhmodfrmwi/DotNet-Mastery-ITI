using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentLab
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = StudentRepository.Students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                Student selectedStudent = (Student)dgvStudents.SelectedRows[0].DataBoundItem;

                StudentDetailsForm detailsForm = new StudentDetailsForm(selectedStudent);

                this.Hide();
                detailsForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("select the first student");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                Student selectedStudent = (Student)dgvStudents.SelectedRows[0].DataBoundItem;

                StudentRepository.Students.Remove(selectedStudent);

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = StudentRepository.Students;

                MessageBox.Show("Student Deleted");
            }
            else
            {
                MessageBox.Show("Select a student first");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = StudentRepository.Students;
            }
            else
            {
                List<Student> filteredList = new List<Student>();

                foreach (Student s in StudentRepository.Students)
                {
                    if (s.Name.ToLower().Contains(searchText))
                    {
                        filteredList.Add(s);
                    }
                }

                dgvStudents.DataSource = null;
                dgvStudents.DataSource = filteredList;
            }
        }
    }
}
