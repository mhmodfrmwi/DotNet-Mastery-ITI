using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace ADO_Task01
{
    public partial class Form1 : Form
    {
        SqlConnection con=new SqlConnection();
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Company_SDConnect"].ConnectionString;
        }
        void fillgrid()
        {
            cmd = new SqlCommand("select SSN, Fname, Lname, Salary, Dno from Employee",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Employee> empList = new List<Employee>();
            while (dr.Read())
            {
                Employee emp = new Employee();
                emp.SSN = dr["SSN"].ToString();
                emp.Fname = dr["Fname"].ToString();
                emp.Lname = dr["Lname"].ToString();
                if (dr["Salary"] != DBNull.Value)
                    emp.Salary = int.Parse(dr["Salary"].ToString());
                else
                    emp.Salary = 0;
                if (dr["Dno"] != DBNull.Value)
                    emp.Dno = int.Parse(dr["Dno"].ToString());
                empList.Add(emp);
            }
            dgv_emp.DataSource = empList;
            cb_del.DataSource = empList;
            cb_del.DisplayMember = "FullName";
            cb_del.ValueMember = "SSN";
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillgrid();
            cmd = new SqlCommand("select Dnum,Dname from Departments",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Department> deptlist= new List<Department>();
            while (dr.Read()) 
            {
                Department dept = new Department();
                dept.Dname = dr["Dname"].ToString() ;
                dept.Dnum = (int)dr["Dnum"];
                deptlist.Add(dept);
            }
           
            con.Close();
            cb_dept.DataSource = deptlist;
            cb_dept.DisplayMember = "Dname";
            cb_dept.ValueMember = "Dnum";
            btn_update.Visible=false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Employee (SSN,Fname, Lname, Salary, Dno) values(@ssn, @fn, @ln, @sal, @dno)", con);
            cmd.Parameters.AddWithValue("@ssn", txt_ssn.Text);
            cmd.Parameters.AddWithValue("@fn", txt_fname.Text);
            cmd.Parameters.AddWithValue("@ln", txt_lname.Text);
            cmd.Parameters.AddWithValue("@sal", int.Parse(txt_salary.Text));
            cmd.Parameters.AddWithValue("@dno", cb_dept.SelectedValue);
            if (con.State == ConnectionState.Closed)
                con.Open();
            int res=cmd.ExecuteNonQuery();
            con.Close();
            if(res>0)
            {
                txt_ssn.Text = txt_fname.Text = txt_lname.Text = txt_salary.Text = "";
                lbl_msg.Text = "Employee Added Successfully";
                lbl_msg.ForeColor = Color.Green;
                fillgrid();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                try
                {
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM Works_for WHERE ESSn = @ssn", con);
                    cmd1.Parameters.AddWithValue("@ssn", cb_del.SelectedValue);
                    cmd1.ExecuteNonQuery();

  
                    SqlCommand cmd2 = new SqlCommand("UPDATE Employee SET Superssn = NULL WHERE Superssn = @ssn", con);
                    cmd2.Parameters.AddWithValue("@ssn", cb_del.SelectedValue);
                    cmd2.ExecuteNonQuery();

                   
                    SqlCommand cmd3 = new SqlCommand("UPDATE Departments SET MGRSSN = NULL WHERE MGRSSN = @ssn", con);
                    cmd3.Parameters.AddWithValue("@ssn", cb_del.SelectedValue);
                    cmd3.ExecuteNonQuery();


                    cmd = new SqlCommand("DELETE FROM Employee WHERE SSN = @ssn", con);
                    cmd.Parameters.AddWithValue("@ssn", cb_del.SelectedValue);

                    int res = cmd.ExecuteNonQuery();

                    if (res > 0)
                    {
                        lbl_msg.Text = "Employee Deleted Successfully";
                        lbl_msg.ForeColor = Color.Red;

                        
                        con.Close();

                        fillgrid();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }


        private void dgv_emp_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_ssn.Text = dgv_emp.SelectedRows[0].Cells[0].Value.ToString();
            txt_fname.Text = dgv_emp.SelectedRows[0].Cells[1].Value.ToString();
            txt_lname.Text = dgv_emp.SelectedRows[0].Cells[2].Value.ToString();
            txt_salary.Text = dgv_emp.SelectedRows[0].Cells[3].Value.ToString();
            cmd = new SqlCommand("select Dno from Employee where SSN=@ssn", con);
            cmd.Parameters.AddWithValue("@ssn", txt_ssn.Text);
            if (con.State == ConnectionState.Closed) 
                con.Open();
            object obj = cmd.ExecuteScalar();
            con.Close();
            cb_dept.SelectedValue = obj;
            btn_update.Visible = true;
            btn_add.Visible = false;
            txt_ssn.ReadOnly = true;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update Employee set Fname=@fn, Lname=@ln, Salary=@sal, Dno=@dno where SSN=@ssn", con);
            cmd.Parameters.AddWithValue("@ssn", txt_ssn.Text);
            cmd.Parameters.AddWithValue("@fn", txt_fname.Text);
            cmd.Parameters.AddWithValue("@ln", txt_lname.Text);
            cmd.Parameters.AddWithValue("@sal", int.Parse(txt_salary.Text));
            cmd.Parameters.AddWithValue("@dno", cb_dept.SelectedValue);
            if (con.State == ConnectionState.Closed)
                con.Open();
            int res = cmd.ExecuteNonQuery();

            if (res > 0)
            {
                lbl_msg.Text = "Employee Deleted Successfully";
                lbl_msg.ForeColor = Color.Red;

                con.Close();

                fillgrid(); 
            }
        }
    }
}
