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
    public partial class QuizStudent : Form
    {
        private int courseID;
        public QuizStudent()
        {
            InitializeComponent();
        }
        public QuizStudent(int courseID) : this()
        {
            this.courseID = courseID;
        }
        public void DataPrint(int courseID)
        {
            string connectionString = "data source=DESKTOP-88SEP50\\SQLEXPRESS; database=EduSync; integrated security=True";
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Assign = new Form1(courseID);
            Assign.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LectureNotes lec = new LectureNotes(courseID);
            lec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnnouncementView ann = new AnnouncementView(courseID);
            ann.Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();

        }
    }
}
