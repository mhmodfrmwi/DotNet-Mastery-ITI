using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con=new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {

            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void fillgrid()
        {
            // SQL JOIN to get student data with department name
            cmd = new SqlCommand(@"
                SELECT Crs_Id,Crs_Name,Crs_Duration,Top_Name
                from dbo.Course c,dbo.Topic t
                where c.Top_Id=t.Top_Id;
                ",
                con
            );

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            List<Course>courses = new List<Course>();

            while (dr.Read())
            {
                Course course = new Course();
                course.Id = (int)dr["Crs_Id"];
                course.Name=(string)dr["Crs_Name"];
                course.Duration = (int)dr["Crs_Duration"];
                course.Topic = (string)dr["Top_Name"];
                courses.Add(course);
                

            }

            // Bind to DataGridView
            dvg_courses.DataSource= courses;

            // Also populate FullName ComboBox
            cb_FullName.ValueMember = "id";
            cb_FullName.DisplayMember = "FullName";
            cb_FullName.DataSource = students;

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
