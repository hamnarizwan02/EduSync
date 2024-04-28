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
using Microsoft.Identity.Client;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        private int userID;
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(int userID):this()
        {
            this.userID = userID;
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
        public void DataPrint()
        {

            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //using (SqlCommand command = new SqlCommand("SELECT CourseID , c.CourseName AS [Course Name], u.uname AS [Instuctor Name ] FROM Courses c JOIN Users u ON c.InstructorID = u.UserID", connection)) // replace with your SQL query
                // using (SqlCommand command = new SqlCommand("SELECT Enrollment.CourseID, \r\n       c.CourseName AS [Course Name], \r\n       u.uname AS [Instructor Name] \r\nFROM Enrollment \r\nJOIN Courses c ON Enrollment.CourseID = c.CourseID\r\nJOIN Users u ON c.InstructorID = u.UserID\r\nWHERE Enrollment.UserID = @userID; ",connection))
                //using(SqlCommand command = new SqlCommand("Select distinct e.CourseID,  c.CourseName AS [Course Name], u.uname AS [Instuctor Name ] \r\nFROM Enrollment AS E\r\nINNER JOIN Users AS U ON E.UserID = U.UserID AND U.UserType = 'Instructor'\r\nINNER JOIN Courses AS C ON E.CourseID = C.CourseID\r\nWHERE EXISTS (\r\n    SELECT 1\r\n    FROM Enrollment AS E2\r\n    WHERE E2.Section = E.Section\r\n    AND E2.UserID IN (\r\n        SELECT UserID\r\n        FROM Users\r\n        WHERE UserType = 'Student'\r\n        AND UserID =@userID\r\n    )\r\n);", connection))
                using(SqlCommand command = new SqlCommand("Select distinct e.CourseID,  c.CourseName AS [Course Name], u.uname AS [Instuctor Name ] \r\nFROM Enrollment AS E\r\nINNER JOIN Users AS U ON E.UserID = U.UserID AND U.UserType = 'Instructor'\r\nINNER JOIN Courses AS C ON E.CourseID = C.CourseID\r\nWHERE EXISTS (\r\n    SELECT 1\r\n    FROM Enrollment AS E2\r\n    WHERE E2.Section = E.Section and\r\n\tE2.CourseID = E.CourseID\r\n    AND E2.UserID IN (\r\n        SELECT UserID\r\n        FROM Users\r\n        WHERE UserType = 'Student'\r\n        AND UserID =@userID\r\n    )\r\n);", connection))

                {
                    command.Parameters.AddWithValue("@userID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataPrint();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["CourseID"].Value);

                Assignment_View detailsForm = new Assignment_View(id, userID);
                detailsForm.Show(); // This line will display the Form1
                this.Hide();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }
    }
}
        
