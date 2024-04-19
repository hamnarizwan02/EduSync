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
    public partial class QuizBookMark : Form
    {
        private int courseID, userID;
        public QuizBookMark()
        {
            InitializeComponent();
        }
        public QuizBookMark(int courseID, int userID) : this()
        {
            this.courseID = courseID;
            this.userID = userID;
        }

        public void QuizBookMark_Load(object sender, EventArgs e)
        {
            dataPrint();
        }
        public void dataPrint()
        {
            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT Quiz.QuizID AS [Quiz number], \r\n                Quiz.QuizFilePath AS download, \r\n                Bookmarks.ValueBookmark AS Bookmarks\r\nFROM Bookmarks \r\nJOIN Quiz ON Bookmarks.QuizID = Quiz.QuizID \r\nWHERE Bookmarks.UserID = @userID \r\n  AND Bookmarks.CourseID = @courseID\r\n  AND Bookmarks.ValueBookmark = 1; \r\n";
                //string query = "SELECT * FROM Bookmarks";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameter value
                    command.Parameters.AddWithValue("@courseID", courseID);
                    command.Parameters.AddWithValue("@userID", this.userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {



                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;


                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bookmark bookmark = new Bookmark(courseID,userID);
            bookmark.Show();
            this.Hide();
        }
    }
}
