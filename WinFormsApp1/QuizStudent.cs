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
        private int courseID;
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
        public void DataPrint(int courseID)
        {
            string connectionString = "data source = DESKTOP-88SEP50\\SQLEXPRESS;database = EduSync; integrated security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT QuizID AS [Quiz number], QuizFilePath AS download FROM Quiz WHERE CourseID = @courseID"; // Parameterized
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameter value
                    command.Parameters.AddWithValue("@courseID", courseID); // Replace courseId with the actual ID 

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
            if (e.RowIndex >= 0)
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

            Assignment_View Assign = new Assignment_View(courseID, 0);
            Assign.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button3.Height;
            flowLayoutPanel1.Top = button3.Top;

            LectureNotes lec = new LectureNotes(courseID);
            lec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button4.Height;
            flowLayoutPanel1.Top = button4.Top;

            AnnouncementView ann = new AnnouncementView(courseID);
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
    }
}
