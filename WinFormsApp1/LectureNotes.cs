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
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class LectureNotes : Form
    {
        private int courseID, userID;
        public LectureNotes()
        {
            InitializeComponent();
            this.Load += LectureNotes_Load;

            flowLayoutPanel1.Height = button3.Height;
            flowLayoutPanel1.Top = button3.Top;
        }
        public LectureNotes(int courseID) : this()
        {
            this.courseID = courseID;
        }
        public LectureNotes(int courseID, int userID) : this()
        {
            this.courseID = courseID;
            this.userID = userID;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string quizFilePath = dataGridView1.Rows[e.RowIndex].Cells["NotesFilePath"].Value.ToString();

                var startInfo = new ProcessStartInfo
                {
                    FileName = @quizFilePath,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Height = button2.Height;
            //flowLayoutPanel1.Top = button2.Top;

            QuizStudent quiz = new QuizStudent(courseID, userID);
            quiz.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button1.Height;
            flowLayoutPanel1.Top = button1.Top;

            Assignment_View Assign = new Assignment_View(courseID, userID);
            Assign.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button4.Height;
            flowLayoutPanel1.Top = button4.Top;

            AnnouncementView announce = new AnnouncementView(courseID, userID);
            announce.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button5.Height;
            flowLayoutPanel1.Top = button5.Top;

            StudentNotes lg = new StudentNotes(courseID, userID);
            lg.Show();
            this.Hide();
        }

        private void LectureNotes_Load(object sender, EventArgs e)
        {
            dataShow(courseID);
        }


        public void dataShow(int courseID)
        {
            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //using (SqlCommand command = new SqlCommand("SELECT a.CourseID, c.CourseName AS [Course Name], u.uname AS [Instructor Name], a.NotesFilePath FROM Courses c JOIN Users u ON c.InstructorID = u.UserID JOIN LectureNote a ON c.CourseID = a.CourseID", connection)) // replace with your SQL query
                using (SqlCommand command = new SqlCommand("SELECT a.CourseID, \r\n       c.CourseName AS [Course Name], \r\n       u.uname AS [Instructor Name], \r\n       a.NotesFilePath \r\nFROM Enrollment \r\nJOIN Courses c ON Enrollment.CourseID = c.CourseID\r\nJOIN Users u ON c.InstructorID = u.UserID\r\nJOIN LectureNote a ON c.CourseID = a.CourseID AND Enrollment.Section = a.Section \r\nWHERE Enrollment.UserID = @userID \r\n      AND Enrollment.CourseID = @courseID;\r\n", connection))
                {
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

        private void button7_Click(object sender, EventArgs e)
        {
            Bookmark bookmark = new Bookmark(courseID, userID);
            bookmark.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userID);
            dashboard.Show();
            this.Hide();
        }
    }
}
