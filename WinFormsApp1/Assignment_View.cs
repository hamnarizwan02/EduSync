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

namespace WinFormsApp1
{
    public partial class Assignment_View : Form
    {
        private int courseID;
        public Assignment_View()
        {
            InitializeComponent();

            flowLayoutPanel1.Height = button1.Height;
            flowLayoutPanel1.Top = button1.Top;


            //this.WindowState = FormWindowState.Maximized;
        }

        public Assignment_View(int courseID) : this()
        {
            this.courseID = courseID;
        }

        public void DataPrint(int courseID)
        {
            string connectionString = "data source = DESKTOP-88SEP50\\SQLEXPRESS;database = EduSync; integrated security = True";
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

        }

        //assignment view button
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button1.Height;
            flowLayoutPanel1.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Height = button2.Height;
            //flowLayoutPanel1.Top = button2.Top;
            QuizStudent quiz =new QuizStudent(courseID);
            quiz.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button3.Height;
            flowLayoutPanel1.Top = button3.Top;

            this.Hide();
            var form3 = new LectureNotes(courseID);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = button4.Height;
            flowLayoutPanel1.Top = button4.Top;

            this.Hide();
            var form3 = new AnnouncementView(courseID);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
