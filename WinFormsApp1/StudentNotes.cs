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
        List<string> selectedFilePaths = new List<string>();

        public StudentNotes()
        {
            InitializeComponent();
            panelLeft.Height = button8.Height;
            panelLeft.Top = button8.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;
            panelLeft.BringToFront();

            this.Hide();
            var form3 = new Assignment_View();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;

            this.Hide();
            var form4 = new QuizStudent();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;
            panelLeft.BringToFront();

            this.Hide();
            var form4 = new LectureNotes();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;
            panelLeft.BringToFront();

            this.Hide();
            var form9 = new AnnouncementView();
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

        }

        private void showFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Files|*.docx";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear the ListBox before adding new items
                listBox1.Items.Clear();

                // Add each selected file's full path to the ListBox and the list of selected file paths
                foreach (string file in openFileDialog.FileNames)
                {
                    listBox1.Items.Add(file);
                    selectedFilePaths.Add(file); // Store selected file path in the list
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                // Get the selected file path from the ListBox
                string filePath = listBox1.SelectedItem.ToString();

                // Check if the file exists before attempting to open it
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
            }
            else
            {
                MessageBox.Show("Please select a file from the list.");
            }

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
            string filePath = @"C:\Users\hamna\Desktop\ " + filename + " .docx";

            try
            {
                // Create a new WordprocessingDocument
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    // Add a new MainDocumentPart
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                    // Create a new Document
                    DocumentFormat.OpenXml.Wordprocessing.Document document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                    mainPart.Document = document;

                    // Create a new Body
                    Body body = new Body();

                    // Add some text to the body
                    DocumentFormat.OpenXml.Wordprocessing.Paragraph paragraph = new DocumentFormat.OpenXml.Wordprocessing.Paragraph();

                    Run run = new Run(new Text(" "));
                    paragraph.Append(run);
                    body.Append(paragraph);

                    // Append the body to the document
                    document.Append(body);
                }

                MessageBox.Show("Word document created on Desktop successfully.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
