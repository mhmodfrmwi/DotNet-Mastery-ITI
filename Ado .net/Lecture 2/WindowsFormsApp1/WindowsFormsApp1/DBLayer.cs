using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     class DBLayer
    {
        public static DataTable select(string cmd)
        {
            SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["itiCon"].ConnectionString);
            SqlCommand cmm=new SqlCommand(cmd, con);
            SqlDataAdapter adbt=new SqlDataAdapter(cmm);
            DataTable dataTable = new DataTable();
            adbt.Fill(dataTable);
            return dataTable;
        }
        public static int dml(string cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["itiCon"].ConnectionString);
            SqlCommand cmm= new SqlCommand(cmd, con);
            con.Open();
             int rowEffected=cmm.ExecuteNonQuery();
            con.Close();
            return rowEffected;
        }
    }
}
