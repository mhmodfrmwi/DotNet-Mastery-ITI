using EnitityFramwork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnitityFramwork
{
    public partial class CoursesForm : Form
    {
        ItiContext context;
        public CoursesForm()
        {
            InitializeComponent();
            context = new ItiContext();
            dgv_fill();
            cmp_topic.DataSource = context.Courses.Select(c => new
            {
                TopId = c.TopId,
                TopName = c.Top.TopName
            }).ToList();
            cmp_topic.DisplayMember = "TopName";
            cmp_topic.ValueMember = "TopId";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Course crs = new Course()
            {
                CrsName = txt_name.Text,
                CrsDuration = int.Parse(txt_duration.Text),
                TopId = (int)cmp_topic.SelectedValue,
            };
            context.Courses.Add(crs);
            context.SaveChanges();
            dgv_view("Added");
        }
        private void dgv_fill()
        {
            DVG_Course.DataSource = context.Courses.Select(c => new { Id = c.CrsId, Name = c.CrsName, Duration = c.CrsDuration, Topic = c.Top.TopName }).ToList();
        }
        private void dgv_view(string operation)
        {
            dgv_fill();
            txt_name.Text = txt_duration.Text = "";
            MessageBox.Show($"Course {operation} successfully");
        }
        int id;

        private void btn_update_Click(object sender, EventArgs e)
        {
            Course course = context.Courses.Where(c => c.CrsId == id).SingleOrDefault();
            if (course != null)
            {
                course.CrsName = txt_name.Text;
                course.CrsDuration = int.Parse(txt_duration.Text);
                course.TopId = (int)cmp_topic.SelectedValue;
                context.SaveChanges();
                dgv_view("Updated");
            }
        }

        private void DVG_Course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)DVG_Course.SelectedRows[0].Cells[0].Value;

            Course course = context.Courses.Where(c => c.CrsId == id).SingleOrDefault();
            if (course != null)
            {
                txt_name.Text = course.CrsName;
                txt_duration.Text = course.CrsDuration.ToString();
                cmp_topic.SelectedValue = course.TopId;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Course course=context.Courses.Where(c=>c.CrsId == id).SingleOrDefault();
            if (course != null) { 
                context.Courses.Remove(course);
                context.SaveChanges();
                dgv_view("Delete");
            }
        }
    }
}
