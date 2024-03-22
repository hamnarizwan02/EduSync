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
    public partial class Form1 : Form
    {
        private int courseID;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public Form1(int courseID) : this()
        {
            this.courseID = courseID;
        }

        public void DataPrint(int courseID)
        {
            string connectionString = "data source=DESKTOP-88SEP50\\SQLEXPRESS; database=EduSync; integrated security=True";
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
        private void Form1_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuizStudent quizview = new QuizStudent(courseID);
            quizview.Show();
            this.Hide();
        }
    }
}
