using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     class CourseBussinessLayer
    {
        public static DataTable getAllCourses()
        {
            return DBLayer.select("select * from Course");
        }
        public static DataTable getCourseById(int id) {
            return DBLayer.select($"select * from Course where Crs_Id = {id}");
        }
        public static int addCourse(int id, string courseName, int duration, int topId) {

            return DBLayer.dml($"insert into course values({id}, '{courseName}',{duration}, {topId})");
        }
        public static int updateCourse(int id, string courseName, int duration, int topId)
        {
            return DBLayer.dml($"update course set Crs_Name='{courseName}',Crs_Duration={duration},Top_Id={topId} where Crs_Id={id}");
        }
        public static int deleteCourse(int id) {
            return DBLayer.dml($"delete from course where Crs_Id={id}");
        }
    }
}
