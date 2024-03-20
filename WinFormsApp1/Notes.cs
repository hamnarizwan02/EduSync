using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button1.Height;
            panelLeft.Top = button1.Top;

            this.Hide();
            var form3 = new Assignmnet();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;
            // panelLeft.BringToFront();

            this.Hide();
            var form4 = new Quiz();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;
            panelLeft.BringToFront();

            //this.Hide();
            //var form3 = new Notes();
            //form3.Closed += (s, args) => this.Close();
            //form3.Show();
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
            string folderPath = @"path";

            // Clear the ListBox before adding new items
            listBox1.Items.Clear();

            // Get all files in the specified folder
            string[] files = Directory.GetFiles(folderPath);

            // Add each file to the ListBox
            foreach (string file in files)
            {
                // Add only file names to the ListBox
                listBox1.Items.Add(Path.GetFileName(file));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string folderPath = @"path";

            if (listBox1.SelectedItem != null)
            {
                // Get the selected file name from the ListBox
                string selectedFileName = listBox1.SelectedItem.ToString();

                // Construct the full path to the selected file
                //string selectedFilePath = Path.Combine(folderPath, selectedFileName);

                MessageBox.Show("Selected file: " + selectedFileName);
            }
            else
            {
                // If no item is selected in the ListBox, display a message to the user
                MessageBox.Show("Please select a file from the list.");
            }
        }
    }
}
