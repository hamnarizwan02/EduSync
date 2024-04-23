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
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Bookmark : Form
    {
        private int courseID, userID;
        public Bookmark()
        {
            InitializeComponent();
        }

        public Bookmark(int courseID, int userID) : this()
        {
            this.courseID = courseID;
            this.userID = userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void Bookmark_Load(object sender, EventArgs e)
        {
            DataPrint();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataPrint()   //assignment bookmarks
        {
            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT Assignment.AssignmentID AS [Assignment number], \r\n                Assignment.Deadline, \r\n                Assignment.AssignmentFilePath AS download, \r\n                Bookmarks.ValueBookmark AS Bookmarks \r\nFROM Enrollment \r\nJOIN Assignment ON Enrollment.CourseID = Assignment.CourseID \r\n                   AND Enrollment.Section = Assignment.Section\r\nLEFT JOIN Bookmarks ON Assignment.AssignmentID = Bookmarks.AssignmentID \r\n                       AND Bookmarks.UserID = @userID \r\nWHERE Enrollment.UserID = @userID \r\n      AND Enrollment.CourseID = @courseID\r\n      AND Bookmarks.ValueBookmark = 1; \r\n";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameter value
                    command.Parameters.AddWithValue("@courseID", courseID); // Replace courseId with the actual ID 
                    command.Parameters.AddWithValue("@userID", this.userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                        //checkBoxColumn.HeaderText = "testingg";

                        //dataGridView1.Columns.Add(checkBoxColumn);
                        //dataGridView1.Rows.Add(false);
                        //dataGridView1.Rows.Add(false);
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;


                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuizBookMark quizBookMark = new QuizBookMark(courseID, userID);
            quizBookMark.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userID);
            dashboard.Show();
            this.Hide();
        }
    }
}
