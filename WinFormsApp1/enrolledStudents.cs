﻿using System;
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
    public partial class enrolledStudents : Form
    {
        public enrolledStudents()
        {
            InitializeComponent();
            this.Load += enrollStudent_Load;
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

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;

            this.Hide();
            var form3 = new enrolledStudents();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
        private List<string> GetCourseNamesFromDatabase()
        {
            List<string> courseNames = new List<string>();

            var connectionString = "Data Source=KISSASIUM\\SQLEXPRESS;Database = lmsp; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            string query = "SELECT CourseName FROM Courses";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string courseName = reader["CourseName"].ToString();
                courseNames.Add(courseName);
            }

            return courseNames;
        }

        void enrollStudent_Load(object sender, EventArgs e)
        {
            List<string> courseNames = GetCourseNamesFromDatabase();

            // Populate the ComboBox with the list of course names
            CoursecomboBox.DataSource = courseNames;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form9 = new login();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }
        private void showFiles_Click(object sender, EventArgs e)
        {
            // Fetching the data
            var name = Name.Text;
            var email = Email.Text;
            var password = Password.Text;
            var section = SectioncomboBox.Text;
            var courseName = CoursecomboBox.Text;


            if (!email.Contains("@"))
            {
                MessageBox.Show("Email addres should contain @.");
                return;
            }

            var connectionString = "Data Source=KISSASIUM\\SQLEXPRESS;Database=lmsp;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                // Insert into users table 
                string insertUserQuery = "insert into Users values('" + name + "', '" + email + "', '" + password + "', 'Student')";
                SqlCommand insertUserCmd = new SqlCommand(insertUserQuery, sqlconn);
                int rowsAffected = insertUserCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // getting course id value 
                    string selectCourseQuery = "select top 1 CourseID from Courses where CourseName = '" + courseName + "'";
                    SqlCommand selectCourseCmd = new SqlCommand(selectCourseQuery, sqlconn);
                    SqlDataReader reader = selectCourseCmd.ExecuteReader();

                    try
                    {
                        if (reader.Read())
                        {
                            string CourseIDstr = reader["CourseID"].ToString();
                            reader.Close();

                            // convertinf from string to int 
                            int courseID;
                            if (int.TryParse(CourseIDstr, out courseID))
                            {
                                // Fetch UserID
                                string selectUserQuery = "select top 1 UserID from Users where Email = '" + email + "'";
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
                                            string insertEnrollmentQuery = "insert into Enrollment values('" + section + "','" + userID + "', '" + courseID + "')";
                                            SqlCommand insertEnrollmentCmd = new SqlCommand(insertEnrollmentQuery, sqlconn);
                                            int enrollmentRowsAffected = insertEnrollmentCmd.ExecuteNonQuery();

                                            if (enrollmentRowsAffected > 0)
                                            {
                                                MessageBox.Show("Student enrolled successfully");
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
                            else
                            {
                                MessageBox.Show("Error occurred while while converting course id  ");
                            }
                        }
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error occurred while inserting data into the users table");
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