using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ADODay01
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["iticon"].ConnectionString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_update.Visible  = false;
            fillgrid();

            cmd = new SqlCommand("select * from Department", con);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            List<Department> depts = new List<Department>();
            while (dr.Read())
            {
                Department d = new Department();
                d.id = (int)dr["Dept_Id"];
                d.name = dr["Dept_Name"].ToString();
                depts.Add(d);
            }

            //display data

            cb_dept.ValueMember = "id";
            cb_dept.DisplayMember = "name";
            cb_dept.DataSource = depts;

            con.Close();
        }

        void fillgrid()
        {
            //define connection
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True";
            //con.ConnectionString = "Server=.;Database=ITI;Integrated Security=True";


            //define command

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from student";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = con;          


            cmd = new SqlCommand("select St_Id,St_Fname,St_Lname,St_Age,St_Address,Dept_Name from student s, department d where s.Dept_Id = d.Dept_Id", con);





            //open connection
            con.Open();


            //execute command (query)   

            SqlDataReader dr = cmd.ExecuteReader();
            List<Student> students = new List<Student>();


            while (dr.Read())
            {
                Student s = new Student();
                s.id = (int)dr["St_Id"];
                s.first_name = dr["St_Fname"].ToString();
                s.last_name = dr["St_Lname"].ToString();
                s.age = (int)( dr["St_Age"]);
                s.address = dr["St_Address"].ToString();
                s.dept_name = dr["Dept_Name"].ToString();
                s.FullName = s.first_name + " " + s.last_name;
                students.Add(s);
            }
            //display data
            dgv_student.DataSource = students;

            cb_FullName.ValueMember = "id";
            cb_FullName.DisplayMember = "FullName";
            cb_FullName.DataSource = students;

            //Close connection
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into student(St_Fname,St_Lname,St_Age,St_Address,Dept_Id) values (@fname,@lname,@age,@address,@dept_id)",con);
            //cmd.Parameters.AddWithValue("id", int.Parse(txt_Id.Text));
            cmd.Parameters.AddWithValue("fname", txt_Fname.Text);
            cmd.Parameters.AddWithValue("lname", txt_Lname.Text);
            cmd.Parameters.AddWithValue("age", int.Parse(txt_age.Text));
            cmd.Parameters.AddWithValue("address", txt_address.Text);
            cmd.Parameters.AddWithValue("dept_id", (int)cb_dept.SelectedValue);


            con.Open();

            int res = cmd.ExecuteNonQuery();

            con.Close();

            if (res > 0)
            {
                txt_Fname.Text = txt_Lname.Text = txt_age.Text = txt_address.Text = "";
                lbl_status.Text = "Student Added Successfully";
                fillgrid();
            }
            

        }

        private void btn_deleteStudent_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("are you sure to delete this student","Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
            cmd = new SqlCommand("delete from student where St_Id=@id", con);
            cmd.Parameters.AddWithValue("id", cb_FullName.SelectedValue);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            fillgrid();
            }
        }

        private void dgv_student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Fname.Text = dgv_student.SelectedRows[0].Cells[1].Value.ToString();
            txt_Lname.Text = dgv_student.SelectedRows[0].Cells[2].Value.ToString();
            txt_age.Text = dgv_student.SelectedRows[0].Cells[3].Value.ToString();
            txt_address.Text = dgv_student.SelectedRows[0].Cells[4].Value.ToString();
            cb_dept.SelectedText = dgv_student.SelectedRows[0].Cells[5].Value.ToString();


            cmd = new SqlCommand("select Dept_Id from student where St_Id=@id",con);
            cmd.Parameters.AddWithValue("id", dgv_student.SelectedRows[0].Cells[0].Value);

            con.Open();
            object obj = cmd.ExecuteScalar();

            cb_dept.SelectedValue  = obj;

            con.Close() ;

            btn_update.Visible = true;
            btn_add.Visible = false;



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update  student set St_Fname = @fname , St_Lname=@lname,St_Age=@age,St_Address=@address, Dept_Id = @dept_id where St_Id=@id", con);
            cmd.Parameters.AddWithValue("id", dgv_student.SelectedRows[0].Cells[0].Value);
            cmd.Parameters.AddWithValue("fname", txt_Fname.Text);
            cmd.Parameters.AddWithValue("lname", txt_Lname.Text);
            cmd.Parameters.AddWithValue("age", int.Parse(txt_age.Text));
            cmd.Parameters.AddWithValue("address", txt_address.Text);
            cmd.Parameters.AddWithValue("dept_id", (int)cb_dept.SelectedValue);

            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();


            if(result > 0)
            {
                txt_Fname.Text = txt_Lname.Text = txt_age.Text = txt_address.Text = "";
                lbl_updateStatus.Text = "Student Updated Successfully";
                fillgrid();

                btn_update.Visible = false;
                btn_add.Visible = true;
            }


        }
    }
}
