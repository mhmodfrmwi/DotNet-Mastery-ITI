using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentLab
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter an ID");
                return;
            }

            int id;
            bool isNumber = int.TryParse(txtId.Text, out id);

            if (isNumber == false)
            {
                MessageBox.Show("ID must be a number");
                return;
            }

            Student newStudent = new Student();
            newStudent.Id = id;
            newStudent.Name = txtName.Text;
            newStudent.Department = cbDepartment.Text;

            if (rbMale.Checked)
            {
                newStudent.Gender = "Male";
            }
            else
            {
                newStudent.Gender = "Female";
            }

            StudentRepository.Students.Add(newStudent);

            MessageBox.Show("Student Added Successfully");

            this.Close();
        }



        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}