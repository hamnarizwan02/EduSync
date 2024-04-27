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
using System.Diagnostics;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WinFormsApp1
{
    public partial class StudentNotes : Form
    {
        private int courseID, userID;
        List<string> selectedFilePaths = new List<string>();

        public StudentNotes()
        {
            InitializeComponent();
            panelLeft.Height = button8.Height;
            panelLeft.Top = button8.Top;
        }

        public StudentNotes(int courseID) : this()
        {
            this.courseID = courseID;
        }
        public StudentNotes(int courseID, int userID) : this()
        {
            this.courseID = courseID;
            this.userID = userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
            panelLeft.BringToFront();

            this.Hide();
            var form3 = new Assignment_View(courseID,userID);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;

            this.Hide();
            var form4 = new QuizStudent(courseID,userID);
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;
            panelLeft.BringToFront();

            this.Hide();
            var form4 = new LectureNotes(courseID,userID);
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;
            panelLeft.BringToFront();

            this.Hide();
            var form9 = new AnnouncementView(courseID, userID);
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button8.Height;
            panelLeft.Top = button8.Top;
            panelLeft.BringToFront();
        }

        private void LectureNotes_STUDENT_Load(object sender, EventArgs e)
        {
            DataPrint();
        }

        //private void DataPrint()
        //{

        //    string connectionString = Constant.ConnectionString;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        try
        //        {
        //            string query = "SELECT * FROM StudentNotes WHERE UserID = @userID";
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@UserID", userID);


        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {


        //                    DataTable dataTable = new DataTable();
        //                    dataTable.Load(reader);
        //                    dataGridView1.DataSource = dataTable;


        //                }
        //            }
        //        }
        //        catch(Exception ex)
        //        {
        //            MessageBox.Show( "hello "+ ex.Message);
        //        }
        //    }

        //}

        private string GetFileName(string filePath)
        {
            return Path.GetFileName(filePath);
        }


        private void DataPrint()
        {
            string connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT * FROM StudentNotes WHERE UserID = @userID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // Add a new column for the file name
                            dataTable.Columns.Add("FileName", typeof(string));

                            // Iterate through each row in the DataTable and extract the file name from the file path
                            foreach (DataRow row in dataTable.Rows)
                            {
                                string filePath = row["FilePath"].ToString();
                                string fileName = GetFileName(filePath);
                                row["FileName"] = fileName;
                            }

                            // Set the DataGridView's DataSource to the modified DataTable
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void showFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Files|*.docx";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                foreach (string file in openFileDialog.FileNames)
                {
                    listBox1.Items.Add(file);
                    selectedFilePaths.Add(file);
                }
            }
        }

        private void openCode_New(string filePath)
        {
            if (File.Exists(filePath))
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }

            else
            {
                MessageBox.Show("File not found.");
            }
            var connectionString = Constant.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO StudentNotes (UserID, FilePath) VALUES (@userID, @filePath)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@userID", userID);
                command.Parameters.AddWithValue("@filePath", filePath);
                command.ExecuteNonQuery();
            }
        }

        private void openCode(string filePath)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (File.Exists(filePath))
                {
                    var startInfo = new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    };
                    Process.Start(startInfo);
                }

                else
                {
                    MessageBox.Show("File not found.");
                }
                var connectionString = Constant.ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO StudentNotes (UserID, FilePath) VALUES (@userID, @filePath)";
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@filePath", filePath);
                    command.ExecuteNonQuery();
                }

            }
            else
            {
                MessageBox.Show("Please select a file from the list.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openCode(listBox1.SelectedItem.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form9 = new login();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }

        //create new doc button 
        private void button7_Click(object sender, EventArgs e)
        {
            string filename = filename_textBox1.Text;
            string filePath = @"C:\Users\hamna\Desktop " + filename + " .docx";

            try
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                    DocumentFormat.OpenXml.Wordprocessing.Document document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                    mainPart.Document = document;

                    Body body = new Body();

                    DocumentFormat.OpenXml.Wordprocessing.Paragraph paragraph = new DocumentFormat.OpenXml.Wordprocessing.Paragraph();

                    Run run = new Run(new Text(" "));
                    paragraph.Append(run);
                    body.Append(paragraph);

                    document.Append(body);
                }

                try
                {
                    var connectionString = Constant.ConnectionString;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertQuery = "INSERT INTO StudentNotes (UserID, FilePath) VALUES (@userID, @filePath)";
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@filePath", filePath);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Word document created on Desktop and file path saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataPrint();
            openCode_New(filePath);

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Bookmark bookmark = new Bookmark(courseID, userID);
            bookmark.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["FilePath"].Index)
            {
                string notesFilePath = dataGridView1.Rows[e.RowIndex].Cells["FilePath"].Value.ToString();

                var startInfo = new ProcessStartInfo
                {
                    FileName = @notesFilePath,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Dashboard dashboard=new Dashboard(userID);
            dashboard.Show();
            this.Hide();
        }
    }
}
