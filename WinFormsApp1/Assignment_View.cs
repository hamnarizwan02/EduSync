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

        public void DataPrint(int courseID)
        {
            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT Assignment.AssignmentID AS [Assignment number], Assignment.Deadline, Assignment.AssignmentFilePath AS download, Bookmarks.ValueBookmark AS Bookmarks FROM Assignment LEFT JOIN Bookmarks ON Assignment.AssignmentID = Bookmarks.AssignmentID WHERE Assignment.CourseID = @courseID"; // Parameterized
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameter value
                    command.Parameters.AddWithValue("@courseID", courseID); // Replace courseId with the actual ID 

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

        //assignment view button
        private void button1_Click(object sender, EventArgs e)
        {
            panel.Height = button1.Height;
            panel.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Height = button2.Height;
            //flowLayoutPanel1.Top = button2.Top;
            QuizStudent quiz = new QuizStudent(courseID);
            quiz.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel.Height = button3.Height;
            panel.Top = button3.Top;

            this.Hide();
            var form3 = new LectureNotes(courseID);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel.Height = button4.Height;
            panel.Top = button4.Top;

            this.Hide();
            var form3 = new AnnouncementView(courseID);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel.Height = button8.Height;
            panel.Top = button8.Top;

            this.Hide();
            var form3 = new StudentNotes();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            SaveBookmarksToDatabase();
        }
        void SaveBookmarksToDatabase()
        {
            string connectionString = "data source = DESKTOP-88SEP50\\SQLEXPRESS;database = EduSync; integrated security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    bool isBookmarked = row.Cells["Bookmarks"].Value != null && row.Cells["Bookmarks"].Value != DBNull.Value && (bool)row.Cells["Bookmarks"].Value;


                    if (isBookmarked)
                    {
                        int assignmentID = Convert.ToInt32(row.Cells["Assignment number"].Value);

                        // 1. Deletion Step
                        string deleteQuery = "DELETE FROM Bookmarks WHERE AssignmentID = @assignmentID";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@assignmentID", assignmentID);
                            deleteCommand.ExecuteNonQuery();
                        }

                        // 2. Insertion Step 
                        string insertQuery = "INSERT INTO Bookmarks (AssignmentID, UserID, ValueBookmark) VALUES (@assignmentID, @userID, @valueBookmark)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@assignmentID", assignmentID);
                            insertCommand.Parameters.AddWithValue("@userID", this.userID);
                            insertCommand.Parameters.AddWithValue("@valueBookmark", isBookmarked);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        int assignmentID = Convert.ToInt32(row.Cells["Assignment number"].Value);

                        //1.Deletion Step
                        string deleteQuery = "DELETE FROM Bookmarks WHERE AssignmentID = @assignmentID";
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@assignmentID", assignmentID);
                            deleteCommand.ExecuteNonQuery();
                        }

                        // 2. Insertion Step 
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
