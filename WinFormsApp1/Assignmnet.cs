using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using Microsoft.Identity.Client;

namespace WinFormsApp1
{
    public partial class Assignmnet : Form
    {
        //set file path for assignment 
        string folderPath = @"C:\Users\khana\Desktop\i210710-DIP-2";

        public Assignmnet()
        {
            InitializeComponent();
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
        }

        private void Assignmnet_Load(object sender, EventArgs e)
        {
            List<string> courseNames = GetCourseNamesFromDatabase();

            // Populate the ComboBox with the list of course names
            Course_comboBox1.DataSource = courseNames;
        }

         private List<string> GetCourseNamesFromDatabase()
         {
             List<string> courseNames = new List<string>();

             var connectionString = "data source = DESKTOP-88SEP50\\SQLEXPRESS;database = EduSync; integrated security = True";
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
        
     
        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
            panelLeft.BringToFront();

            //this.Hide();
            //var form3 = new Assignmnet();
            //form3.Closed += (s, args) => this.Close();
            //form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;

            this.Hide();
            var form4 = new Quiz();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;

            this.Hide();
            var form3 = new Notes();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;
            panelLeft.BringToFront();

            this.Hide();
            var form9 = new Announcement();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }

        private void showFiles_Click(object sender, EventArgs e)
        {
            // Clear the ListBox before adding new items
            listBox1.Items.Clear();

            // Get all files in the specified folder
            string[] files = Directory.GetFiles(folderPath);

            // Add each file to the ListBox
            foreach (string file in files)
            {
                // only show pdf files
                if (Path.GetExtension(file).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    // Add only PDF file names to the ListBox
                    listBox1.Items.Add(Path.GetFileName(file));
                }
            }
        }

        //upload button
        private void button5_Click(object sender, EventArgs e)
        {
            var connectionString = "data source = DESKTOP-88SEP50\\SQLEXPRESS;database = EduSync; integrated security = True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            //get user input
            var section = Section_comboBox2.Text;
            var duedate = DueDate_dateTimePicker1.Text;

            if (listBox1.SelectedItem != null)
            {
                // Get the selected file name from the ListBox
                string selectedFileName = listBox1.SelectedItem.ToString();

                // Construct the full path to the selected file
                string selectedFilePath = Path.Combine(folderPath, selectedFileName);

                //MessageBox.Show("Selected file: " + selectedFilePath);


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
                        SqlCommand sqlcomm11 = new SqlCommand("insert into Assignment " +
                                   "values('" + courseID + "' , '" + section + "', '" + duedate + "' , '" + selectedFilePath + "' )", sqlconn);

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
            else
            {
                // If no item is selected in the ListBox, display a message to the user
                MessageBox.Show("Please select a file from the list.");
            }
        }

        //logout button
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form9 = new login();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }
    }
}
