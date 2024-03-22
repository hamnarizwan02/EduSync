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
    public partial class AnnouncementView : Form
    {
        private int courseID;
        public AnnouncementView()
        {
            InitializeComponent();
        }


        public AnnouncementView(int courseID) : this()
        {
            this.courseID = courseID;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LectureNotes lec = new LectureNotes(courseID);
            lec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuizStudent quiz = new QuizStudent(courseID);
            quiz.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(courseID);
            f.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }
    }
}
