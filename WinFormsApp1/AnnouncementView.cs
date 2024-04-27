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
    public partial class AnnouncementView : Form
    {
        private int courseID, userID;
        public AnnouncementView()
        {
            InitializeComponent();
            this.Load += AnnouncementView_Load;

            flowLayoutPanel1.Height = button4.Height;
            flowLayoutPanel1.Top = button4.Top;
        }


        public AnnouncementView(int courseID) : this()
        {
            this.courseID = courseID;
        }
        public AnnouncementView(int courseID, int userID) : this()
        {
            this.courseID = courseID;
            this.userID = userID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dataShow(int courseID)
        {
            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // using (SqlCommand command = new SqlCommand("SELECT a.CourseID, c.CourseName AS [Course Name], u.uname AS [Instructor Name], a.announcements FROM Courses c JOIN Users u ON c.InstructorID = u.UserID JOIN Announcement a ON c.CourseID = a.CourseID", connection)) 
                using (SqlCommand command = new SqlCommand("SELECT a.CourseID, \r\n       c.CourseName AS [Course Name], \r\n       u.uname AS [Instructor Name], \r\n       a.announcements \r\nFROM Enrollment \r\nJOIN Courses c ON Enrollment.CourseID = c.CourseID\r\nJOIN Users u ON c.InstructorID = u.UserID\r\nJOIN Announcement a ON c.CourseID = a.CourseID\r\nWHERE Enrollment.UserID = @userID \r\n      AND Enrollment.CourseID = @courseID\r\n      AND Enrollment.Section = a.Section;  \r\n", connection))
                {
                    command.Parameters.AddWithValue("@userID", this.userID);
                    command.Parameters.AddWithValue("@courseID", courseID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button3.Height;
            flowLayoutPanel1.Top = button3.Top;

            LectureNotes lec = new LectureNotes(courseID, userID);
            lec.Show();
            this.Hide();
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

            Assignment_View f = new Assignment_View(courseID, userID);
            f.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AnnouncementView_Load(object sender, EventArgs e)
        {
            dataShow(courseID);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button8.Height;
            flowLayoutPanel1.Top = button8.Top;

            StudentNotes f = new StudentNotes(courseID, userID);
            f.Show();
            this.Hide();
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
