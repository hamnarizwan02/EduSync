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
    public partial class ForgotPass : Form
    {
        private string email;


        public ForgotPass(string email)
        {
            InitializeComponent();
            this.email = email;
            DisplayEmail();
        }

        private void DisplayEmail()
        {
            if (!string.IsNullOrEmpty(email) && email.Contains('@'))
            {
                // username and domain
                string[] parts = email.Split('@');
                string username = parts[0];
                string domainemail = parts[1];
                string maskedEmail = username.Substring(0, Math.Min(username.Length, 3)) + "***@" + domainemail;

                // Display the masked email address inlabel
                Name1.Text = "We have sent the new password at you email: " + maskedEmail + "";
            }
            else
            {
               
                Name2.Text = "Invalid email format";
            }
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
