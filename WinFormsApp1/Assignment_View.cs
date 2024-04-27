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
    public partial class Assignment_View : Form
    {
        private int courseID, userID;

        public Assignment_View()
        {
            InitializeComponent();

            panel.Height = button1.Height;
            panel.Top = button1.Top;


            //this.WindowState = FormWindowState.Maximized;
        }

        public Assignment_View(int courseID, int userID) : this()
        {
            this.courseID = courseID;
            this.userID = userID;
        }

        public Assignment_View(int courseID) : this()
        {
            this.courseID = courseID;

        }

        public void DataPrint(int courseID)
        {
            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT Assignment.AssignmentID AS [Assignment number], \r\n                Assignment.Deadline, \r\n                Assignment.AssignmentFilePath AS download, \r\n                Bookmarks.ValueBookmark AS Bookmarks \r\nFROM Enrollment \r\nJOIN Assignment ON Enrollment.CourseID = Assignment.CourseID \r\n                   AND Enrollment.Section = Assignment.Section\r\nLEFT JOIN Bookmarks ON Assignment.AssignmentID = Bookmarks.AssignmentID \r\n                       AND Bookmarks.UserID = @userID \r\nWHERE Enrollment.UserID = @userID \r\n      AND Enrollment.CourseID = @courseID; \r\n";
               
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@courseID", courseID);                     command.Parameters.AddWithValue("@userID", this.userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                      
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;


                    }
                }
            }
        }
        private void Assignment_View_Load(object sender, EventArgs e)
        {
            DataPrint(courseID);
            //bookMarkPrint();




        }

        private void bookMarkPrint()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "testingg";


            dataGridView1.Rows.Add(false);
        }



        private void button6_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            //for opening pdf

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["download"].Index)
            {
                string quizFilePath = dataGridView1.Rows[e.RowIndex].Cells["download"].Value.ToString();

                var startInfo = new ProcessStartInfo
                {
                    FileName = @quizFilePath,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }

        }

        //assignment view button
        private void button1_Click(object sender, EventArgs e)
        {
            panel.Height = button1.Height;
            panel.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)      //quiz section
        {
            //flowLayoutPanel1.Height = button2.Height;
            //flowLayoutPanel1.Top = button2.Top;
            QuizStudent quiz = new QuizStudent(courseID, userID);
            quiz.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel.Height = button3.Height;
            panel.Top = button3.Top;

            this.Hide();
            var form3 = new LectureNotes(courseID, userID);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel.Height = button4.Height;
            panel.Top = button4.Top;

            this.Hide();
            var form3 = new AnnouncementView(courseID, userID);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel.Height = button8.Height;
            panel.Top = button8.Top;

            this.Hide();
            var form3 = new StudentNotes(courseID, userID);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        void SaveBookmarksToDatabase()
        {
            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    bool isBookmarked = row.Cells["Bookmarks"].Value != null && row.Cells["Bookmarks"].Value != DBNull.Value && (bool)row.Cells["Bookmarks"].Value;
                    int assignmentID = Convert.ToInt32(row.Cells["Assignment number"].Value);

                    string checkExistingQuery = "SELECT COUNT(*) FROM Bookmarks WHERE AssignmentID = @assignmentID AND UserID = @userID";
                    using (SqlCommand checkCommand = new SqlCommand(checkExistingQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@assignmentID", assignmentID);
                        checkCommand.Parameters.AddWithValue("@userID", this.userID);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            string updateQuery = "UPDATE Bookmarks SET ValueBookmark = @valueBookmark WHERE AssignmentID = @assignmentID AND UserID = @userID";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@assignmentID", assignmentID);
                                updateCommand.Parameters.AddWithValue("@userID", this.userID);
                                updateCommand.Parameters.AddWithValue("@valueBookmark", isBookmarked);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // insert new bookmark
                            string insertQuery = "INSERT INTO Bookmarks (AssignmentID, UserID, ValueBookmark) VALUES (@assignmentID, @userID, @valueBookmark)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@assignmentID", assignmentID);
                                insertCommand.Parameters.AddWithValue("@userID", this.userID);
                                insertCommand.Parameters.AddWithValue("@valueBookmark", isBookmarked);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Bookmark saved successfully.");
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SaveBookmarksToDatabase();

        }

        private void FilterDataGridViewByBookmark()
        {
            dataGridView1.ClearSelection();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Bookmarks"].Value != null && row.Cells["Bookmarks"].Value.ToString() == "1")
                {
                    // Select the row
                    row.Selected = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bookmark bookmark = new Bookmark(courseID, userID);
            bookmark.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userID);
            dashboard.Show();
            this.Hide();
        }
    }
}