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
    public partial class LectureNotes : Form
    {
        private int courseID;
        public LectureNotes()
        {
            InitializeComponent();
        }
        public LectureNotes(int courseID) : this()
        {
            this.courseID = courseID;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuizStudent quiz = new QuizStudent(courseID);
            quiz.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Assign = new Form1(courseID);
            Assign.Show();
            this.Hide();
        }
    }
}
