using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1; 

namespace WinFormsApp1
{
    internal class Function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            //kissa's
            //con.ConnectionString = "Data Source=KISSASIUM\\SQLEXPRESS;Database=lmsp;Integrated Security=True";

            //hamna's
            //con.ConnectionString = "Data Source=LAPTOP-S1HUQ0ID\\\\SQLEXPRESS;Database = LMS; Integrated Security=True";

            //arham's
            con.ConnectionString = "data source = DESKTOP-88SEP50\\SQLEXPRESS;database = EduSync; integrated security = True";

            return con;
        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public void setData(String query, String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(msg, "lessgoo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}