using EnitityFramwork.Models;

namespace EnitityFramwork
{
    public partial class Form1 : Form
    {
        ItiContext context;
        public Form1()
        {
            InitializeComponent();
            context = new ItiContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DVG_Students.DataSource = context.Students.Select(s => new { Id = s.StId, Full_Name = s.StFname + " " + s.StLname, Age = s.StAge, Address = s.StAddress, Department = s.Dept.DeptName, Supervisor = s.StSuperNavigation.StFname + " " + s.StSuperNavigation.StLname }).ToList();
            dept_cmp.DataSource = context.Departments.ToList();
            dept_cmp.ValueMember = "DeptId";
            dept_cmp.DisplayMember = "DeptName";
            supr_cmp.DataSource = context.Students.Select(s => new { s.StId, FullName = s.StFname + " " + s.StLname }).ToList();
            supr_cmp.DisplayMember = "FullName";
            supr_cmp.ValueMember = "StId";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var student = new Student()
            {
                StFname = St_Fname.Text,
                StLname = St_Lname.Text,
                StAge = int.Parse(St_Age.Text),
                StAddress = St_Adress.Text,
                DeptId = (int)dept_cmp.SelectedValue,
                StSuper = (int)supr_cmp.SelectedValue
            };
            context.Students.Add(student);
            context.SaveChanges();
            dvg_view("added");
        }
        int id;
        private void DVG_Students_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)DVG_Students.SelectedRows[0].Cells[0].Value;
            Student st= context.Students.Where(s=>s.StId==id).SingleOrDefault();
            St_Fname.Text = st.StFname;
            St_Lname.Text=st.StLname;
            St_Age.Text =  st.StAge.ToString();
            St_Adress.Text = st.StAddress;
            dept_cmp.SelectedValue = st.DeptId;
            supr_cmp.SelectedValue = st.StSuper;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Student st=context.Students.Where(s=>s.StId == id).SingleOrDefault();
            st.StFname = St_Fname.Text;
            st.StLname = St_Lname.Text;
            st.StAge= int.Parse( St_Age.Text);
            st.StAddress=St_Adress.Text;
            st.DeptId=(int)dept_cmp.SelectedValue;
            st.StSuper=(int)supr_cmp.SelectedValue;
            context.SaveChanges();
            dvg_view("updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Student st=context.Students.Where(s=>s.StId==id).SingleOrDefault();
            context.Students.Remove(st);
            context.SaveChanges();
            dvg_view("deleted");
        }
        private void dvg_view(string operation)
        {
            DVG_Students.DataSource = context.Students.Select(s => new { Id = s.StId, Full_Name = s.StFname + " " + s.StLname, Age = s.StAge, Address = s.StAddress, Department = s.Dept.DeptName, Supervisor = s.StSuperNavigation.StFname + " " + s.StSuperNavigation.StLname }).ToList();
            St_Fname.Text = St_Lname.Text = St_Age.Text = St_Adress.Text = "";
            MessageBox.Show($"student {operation} successfully");
        }
    }
}
