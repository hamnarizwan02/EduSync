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
using System.IO;


namespace WinFormsApp1
{
    public partial class QuizStudent : Form
    {
        private int courseID, userID;
        public QuizStudent()
        {
            InitializeComponent();
            flowLayoutPanel1.Height = button2.Height;
            flowLayoutPanel1.Top = button2.Top;
        }
        public QuizStudent(int courseID) : this()
        {
            this.courseID = courseID;
        }
        public QuizStudent(int courseID, int userID) : this()
        {
            this.userID = userID;
            this.courseID = courseID;
        }
        public void DataPrint(int courseID)
        {
            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // last sahi string query = "SELECT QuizID AS [Quiz number], QuizFilePath AS download FROM Quiz WHERE CourseID = @courseID"; 
                // 2.0 string query = "SELECT Quiz.QuizID AS [Quiz number], \r\n       Quiz.QuizFilePath AS download \r\nFROM Enrollment \r\nJOIN Quiz ON Enrollment.CourseID = Quiz.CourseID \r\n             AND Enrollment.Section = Quiz.Section -- Assuming Quiz has a Section column \r\nWHERE Enrollment.UserID = @userID \r\n      AND Enrollment.CourseID = @courseID; \r\n";
                string query = "SELECT Quiz.QuizID AS [Quiz number], \r\n       Quiz.QuizFilePath AS download,\r\n       Bookmarks.ValueBookmark AS Bookmark\r\nFROM Enrollment \r\nJOIN Quiz ON Enrollment.CourseID = Quiz.CourseID \r\n         AND Enrollment.Section = Quiz.Section \r\nLEFT JOIN Bookmarks ON Enrollment.UserID = Bookmarks.UserID\r\n                   AND Enrollment.CourseID = Bookmarks.CourseID\r\n                   AND Quiz.QuizID = Bookmarks.QuizID -- Join condition for Quiz bookmarks\r\nWHERE Enrollment.UserID = @userID \r\n      AND Enrollment.CourseID = @courseID; \r\n";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //parameter value
                    command.Parameters.AddWithValue("@courseID", courseID);
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

        private void QuizStudent_Load(object sender, EventArgs e)
        {
            DataPrint(courseID);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["download"].Index)
            {
                // User clicked on the download column of a row
                string quizFilePath = dataGridView1.Rows[e.RowIndex].Cells["download"].Value.ToString();
                // Now you have the QuizFilePath value in the 'quizFilePath' variable

                var startInfo = new ProcessStartInfo
                {
                    FileName = @quizFilePath,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button1.Height;
            flowLayoutPanel1.Top = button1.Top;

            Assignment_View Assign = new Assignment_View(courseID, userID);
            Assign.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button3.Height;
            flowLayoutPanel1.Top = button3.Top;

            LectureNotes lec = new LectureNotes(courseID, userID);
            lec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button4.Height;
            flowLayoutPanel1.Top = button4.Top;

            AnnouncementView ann = new AnnouncementView(courseID, userID);
            ann.Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button2.Height;
            flowLayoutPanel1.Top = button2.Top;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            string path = "F:\\file.pdf";
            var startInfo = new ProcessStartInfo
            {
                FileName = @path,
                UseShellExecute = true
            };
            Process.Start(startInfo);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button8.Height;
            flowLayoutPanel1.Top = button8.Top;

            StudentNotes Assign = new StudentNotes();
            Assign.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveToDatabase();
        }

        private void saveToDatabase()
        {

            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    bool isBookmarked = row.Cells["Bookmark"].Value != null && row.Cells["Bookmark"].Value != DBNull.Value && (bool)row.Cells["Bookmark"].Value;
                    int quizID = Convert.ToInt32(row.Cells["Quiz number"].Value);
                    //int courseID = Convert.ToInt32(row.Cells["Course ID"].Value);

                    // Update the queries to use QuizID and CourseID
                    string checkExistingQuery = "SELECT COUNT(*) FROM Bookmarks WHERE QuizID = @quizID AND UserID = @userID AND CourseID = @courseID";
                    using (SqlCommand checkCommand = new SqlCommand(checkExistingQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@quizID", quizID);
                        checkCommand.Parameters.AddWithValue("@userID", this.userID);
                        checkCommand.Parameters.AddWithValue("@courseID", courseID);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            string updateQuery = "UPDATE Bookmarks SET ValueBookmark = @valueBookmark WHERE QuizID = @quizID AND UserID = @userID AND CourseID = @courseID";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@quizID", quizID);
                                updateCommand.Parameters.AddWithValue("@userID", this.userID);
                                updateCommand.Parameters.AddWithValue("@valueBookmark", isBookmarked);
                                updateCommand.Parameters.AddWithValue("@courseID", courseID);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO Bookmarks (QuizID, UserID, ValueBookmark, CourseID) VALUES (@quizID, @userID, @valueBookmark, @courseID)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@quizID", quizID);
                                insertCommand.Parameters.AddWithValue("@userID", this.userID);
                                insertCommand.Parameters.AddWithValue("@valueBookmark", isBookmarked);
                                insertCommand.Parameters.AddWithValue("@courseID", courseID);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            MessageBox.Show("Bookmark saved successfully.");

            /* string connectionString = Constant.ConnectionString;
             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 connection.Open();

                 for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                 {
                     DataGridViewRow row = dataGridView1.Rows[i];
                     bool isBookmarked = row.Cells["Bookmark"].Value != null && row.Cells["Bookmark"].Value != DBNull.Value && (bool)row.Cells["Bookmark"].Value;

                     // Get quizID instead of assignmentID 
                     int quizID = Convert.ToInt32(row.Cells["Quiz number"].Value);

                     // Update the queries to use QuizID 
                     string checkExistingQuery = "SELECT COUNT(*) FROM Bookmarks WHERE QuizID = @quizID AND UserID = @userID";
                     using (SqlCommand checkCommand = new SqlCommand(checkExistingQuery, connection))
                     {
                         checkCommand.Parameters.AddWithValue("@quizID", quizID); // Parameter name changed
                         checkCommand.Parameters.AddWithValue("@userID", this.userID);
                         int count = (int)checkCommand.ExecuteScalar();

                         if (count > 0)
                         {
                             string updateQuery = "UPDATE Bookmarks SET ValueBookmark = @valueBookmark WHERE QuizID = @quizID AND UserID = @userID";
                             using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                             {
                                 updateCommand.Parameters.AddWithValue("@quizID", quizID); // Parameter name changed
                                 updateCommand.Parameters.AddWithValue("@userID", this.userID);
                                 updateCommand.Parameters.AddWithValue("@valueBookmark", isBookmarked);
                                 updateCommand.ExecuteNonQuery();
                             }
                         }
                         else
                         {
                             string insertQuery = "INSERT INTO Bookmarks (QuizID, UserID, ValueBookmark) VALUES (@quizID, @userID, @valueBookmark)"; // Column name changed
                             using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                             {
                                 insertCommand.Parameters.AddWithValue("@quizID", quizID); // Parameter name changed
                                 insertCommand.Parameters.AddWithValue("@userID", this.userID);
                                 insertCommand.Parameters.AddWithValue("@valueBookmark", isBookmarked);
                                 insertCommand.ExecuteNonQuery();
                             }
                         }
                     }
                 } 
             }

             MessageBox.Show("Bookmark saved successfully."); */

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bookmark bookmark = new Bookmark(courseID,userID);
            bookmark.Show();
            this.Hide();
        }
    }
}
