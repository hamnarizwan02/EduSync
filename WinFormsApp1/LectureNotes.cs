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

namespace WinFormsApp1
{
    public partial class LectureNotes : Form
    {
        private int courseID;
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Height = button2.Height;
            //flowLayoutPanel1.Top = button2.Top;

            //QuizStudent quiz = new QuizStudent(courseID);
            //quiz.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button1.Height;
            flowLayoutPanel1.Top = button1.Top;

            Assignment_View Assign = new Assignment_View(courseID);
            Assign.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button4.Height;
            flowLayoutPanel1.Top = button4.Top;

            AnnouncementView announce = new AnnouncementView(courseID);
            announce.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void LectureNotes_Load(object sender, EventArgs e)
        {
            dataShow(courseID);
        }


        public void dataShow(int courseID)
        {
            string connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = LMS; Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT a.CourseID, c.CourseName AS [Course Name], u.uname AS [Instructor Name], a.NotesFilePath FROM Courses c JOIN Users u ON c.InstructorID = u.UserID JOIN LectureNote a ON c.CourseID = a.CourseID", connection)) // replace with your SQL query
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
