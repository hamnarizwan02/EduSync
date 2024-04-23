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

namespace WinFormsApp1
{
    public partial class Announcement : Form
    {
        private int userID;

        public Announcement()
        {
            InitializeComponent();
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;
        }

        public Announcement(int userID) : this()
        {
            this.userID = userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;

            this.Hide();
            var form3 = new Assignmnet(userID);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;

            this.Hide();
            var form4 = new Quiz(userID);
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;

            this.Hide();
            var form3 = new Notes(userID);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;
            panelLeft.BringToFront();

            //this.Hide();
            //var form9 = new Announcement();
            //form9.Closed += (s, args) => this.Close();
            //form9.Show();
        }

        private void Announcement_Load(object sender, EventArgs e)
        {
            List<string> courseNames = GetCourseNamesFromDatabase(userID);
            List<string> sectionNames = GetSectionFromDatabase(userID);

            // Populate the ComboBox with the list of course names
            Course_comboBox1.DataSource = courseNames;
            Section_comboBox2.DataSource = sectionNames;
        }


        private List<string> GetCourseNamesFromDatabase(int userID)
        {
            List<string> courseNames = new List<string>();

            var connectionString = Constant.ConnectionString;
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            string query = "Select c.CourseName from Enrollment e JOIN Courses c on c.CourseID = e.CourseID where e.UserID = '" + userID + "' ";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string courseName = reader["CourseName"].ToString();
                courseNames.Add(courseName);
            }

            reader.Close();

            return courseNames;
        }

        private List<string> GetSectionFromDatabase(int userID)
        {
            List<string> sectionNames = new List<string>();

            var connectionString = Constant.ConnectionString;
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();

                string query1 = "SELECT c.CourseID FROM Enrollment e JOIN Courses c ON c.CourseID = e.CourseID WHERE e.UserID = '" + userID + "'";
                using (SqlCommand cmd1 = new SqlCommand(query1, sqlconn))
                {
                    List<int> courseIDs = new List<int>(); // List to store CourseIDs
                    using (SqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        while (reader1.Read())
                        {
                            // Retrieve the CourseID and add it to the list
                            int courseID = Convert.ToInt32(reader1["CourseID"]);
                            courseIDs.Add(courseID);
                        }
                    } // Close the first reader after collecting CourseIDs

                    // Iterate over the list of CourseIDs to execute the second query
                    foreach (int courseID in courseIDs)
                    {
                        string query2 = "SELECT Section FROM Enrollment WHERE UserID = '" + userID + "' AND CourseID = '" + courseID + "'";
                        using (SqlCommand cmd2 = new SqlCommand(query2, sqlconn))
                        {
                            using (SqlDataReader reader2 = cmd2.ExecuteReader())
                            {
                                // Assuming you want to retrieve all sections associated with the user's enrolled courses
                                while (reader2.Read())
                                {
                                    string sectionName = reader2["Section"].ToString();
                                    sectionNames.Add(sectionName);
                                }
                            }
                        }
                    }
                }
            }

            return sectionNames;
        }

        //upload button
        private void button6_Click(object sender, EventArgs e)
        {
            var connectionString = Constant.ConnectionString;
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            //get user input
            var section = Section_comboBox2.Text;  //if all sections chosen then when viewing it should be shown for students of all sections 
            var announcement = richTextBox1.Text;

            //get courseID of user entered coursename from courses table
            var coursename = Course_comboBox1.Text;
            string query = "Select TOP 1 CourseID from Courses where CourseName = '" + coursename + "'";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string CourseIDstr = reader["CourseID"].ToString();
                reader.Close();

                //convert CourseIDstr to integer so it can be inserted into assignment table
                int courseID;
                if (int.TryParse(CourseIDstr, out courseID))
                {
                    //insert courseid, sectiom, deadline
                    SqlCommand sqlcomm11 = new SqlCommand("insert into Announcement " +
                                "values('" + courseID + "' , '" + section + "', '" + announcement + "')", sqlconn);

                    var ifError11 = sqlcomm11.ExecuteNonQuery();
                    if (ifError11 == 0)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        MessageBox.Show("Successfully uploaded!");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to convert courseID string to integer");
                }

            }
            else
            {
                MessageBox.Show("Course does not exist.");
            }
        }

        //logout button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form9 = new login();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }
    }
} 
