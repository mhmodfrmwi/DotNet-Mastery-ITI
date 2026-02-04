using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CourseLayers : Form
    {
        public CourseLayers()
        {
            InitializeComponent();
        }

        private void CourseLayers_Load(object sender, EventArgs e)
        {
            DataTable dataTable = CourseBussinessLayer.getAllCourses();
            dgv_courses.DataSource = dataTable;

            DataTable topicDt = DBLayer.select("select * from Topic");
            topic_box.DataSource = topicDt;
            topic_box.DisplayMember = "Top_Name"; 
            topic_box.ValueMember = "Top_Id";
        }

        private void dgv_courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            

            int roweffected = CourseBussinessLayer.addCourse(int.Parse(txt_id.Text),txt_name.Text,int.Parse(txt_duration.Text),int.Parse(topic_box.SelectedText));
            if (roweffected > 0)
            {
                DataTable dataTable = CourseBussinessLayer.getAllCourses();
                dgv_courses.DataSource = dataTable;

                txt_id.Text = "";
                txt_name.Text = "";
                MessageBox.Show("Course added successfully!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            int roweffected = CourseBussinessLayer.updateCourse(
                int.Parse(txt_id.Text),
                txt_name.Text,
                int.Parse(txt_duration.Text),
                Convert.ToInt32(topic_box.SelectedValue)
            );

            if (roweffected > 0)
            {
                dgv_courses.DataSource = CourseBussinessLayer.getAllCourses();
                MessageBox.Show("Course updated successfully!");

                txt_id.Text = "";
                txt_name.Text = "";
                txt_duration.Text = "";
            }
            else
            {
                MessageBox.Show("Update failed. Make sure the ID exists.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this course?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int roweffected = CourseBussinessLayer.deleteCourse(int.Parse(txt_id.Text));

                if (roweffected > 0)
                {
                    dgv_courses.DataSource = CourseBussinessLayer.getAllCourses();
                    txt_id.Text = "";
                    txt_name.Text = "";
                    txt_duration.Text = "";
                    MessageBox.Show("Course deleted successfully!");
                }
            }
        }

        private void dgv_courses_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgv_courses.Rows[e.RowIndex];

            txt_id.Text = row.Cells["Crs_Id"].Value.ToString();
            txt_name.Text = row.Cells["Crs_Name"].Value.ToString();
            txt_duration.Text = row.Cells["Crs_Duration"].Value.ToString();

            topic_box.SelectedValue = row.Cells["Top_Id"].Value;
        }
    }
}
