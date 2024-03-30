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
        private int courseID;
        public Assignment_View()
        {
            InitializeComponent();

            panel.Height = button1.Height;
            panel.Top = button1.Top;


            //this.WindowState = FormWindowState.Maximized;
        }

        public Assignment_View(int courseID) : this()
        {
            this.courseID = courseID;
        }

        public void DataPrint(int courseID)
        {
            string connectionString = "data source = LAPTOP-S1HUQ0ID\\SQLEXPRESS;database = LMS; integrated security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT AssignmentID AS [Assignment number], Deadline, AssignmentFilePath AS download FROM Assignment WHERE CourseID = @courseID"; // Parameterized
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
        private void Assignment_View_Load(object sender, EventArgs e)
        {
            DataPrint(courseID);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
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
    }
}
