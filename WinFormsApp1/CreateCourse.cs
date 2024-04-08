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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class CreateCourse : Form
    {
        public CreateCourse()
        {
            InitializeComponent();
            this.Load += enrollTeacher_Load;
        }
        void enrollTeacher_Load(object sender, EventArgs e)
        {

            List<string> sectionNames = GetSectionFromDatabase();
            List<string> InsNames = GetInstrcutorFromDatabase();

            // Populate the ComboBox with the list of course names

            SectionBox.DataSource = sectionNames;
            instBox.DataSource = InsNames;
        }
        private List<string> GetSectionFromDatabase()
        {
            List<string> sectionNames = new List<string>();

            var connectionString = Constant.ConnectionString;
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            string query = "SELECT SectionName FROM Section WHERE SectionName != 'All'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string SectionName = reader["SectionName"].ToString();
                sectionNames.Add(SectionName);
            }

            return sectionNames;
        }

        private List<string> GetInstrcutorFromDatabase()
        {
            List<string> InstructortsNames = new List<string>();

            var connectionString = Constant.ConnectionString;
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            string query = "select uname from users where UserType = 'Instructor';";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string uname = reader["uname"].ToString();
                InstructortsNames.Add(uname);
            }

            return InstructortsNames;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;

            this.Hide();
            var form3 = new enrolledStudents();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createcoursebutton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = createcoursebutton.Height;
            panelLeft.Top = createcoursebutton.Top;

            this.Hide();
            var form3 = new CreateCourse();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;

            this.Hide();
            var form3 = new Admin_Profile();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;

            this.Hide();
            var form3 = new enrollTeacher();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form9 = new login();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void showFiles_Click(object sender, EventArgs e)
        {
            var x = CourseBox.Text;
            if (x == "")
            {
                MessageBox.Show("No fields should be empty.");
                return;
            }

            var coursename = CourseBox.Text;
            var sectionname = SectionBox.Text;
            var instname = instBox.Text;


            var connectionString = Constant.ConnectionString;
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                            // Fetch UserID
                            string selectUserQuery = "select top 1 UserID from Users where uname = '" + instname + "'";
                            SqlCommand selectUserCmd = new SqlCommand(selectUserQuery, sqlconn);
                            SqlDataReader reader2 = selectUserCmd.ExecuteReader();

                            try
                            {
                                if (reader2.Read())
                                {
                                    string UserIDstr = reader2["UserID"].ToString();
                                    reader2.Close();


                                    // convertinf from string to int 
                                    int userID;
                                    if (int.TryParse(UserIDstr, out userID))
                                    {
                                        // Insert valuesin enrollment table 
                                        string insertEnrollmentQuery = "insert into Courses values('" + coursename + "','" + userID + "')";
                                        SqlCommand insertEnrollmentCmd = new SqlCommand(insertEnrollmentQuery, sqlconn);
                                        int enrollmentRowsAffected = insertEnrollmentCmd.ExecuteNonQuery();

                                        if (enrollmentRowsAffected > 0)
                                        {
                                            MessageBox.Show("New Course has been registered!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error occurred while inserting data into the Enrollment table");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error occurred while converting user id  ");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error while fetching userid ");
                                }
                            }
                            finally
                            {
                                reader2.Close();
                            }
                      
                  
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }

        }
    }
}
