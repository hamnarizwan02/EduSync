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
            ConvertAndDisplayEmail();
        }

        private void ConvertAndDisplayEmail()
        {
            // Check if email is not null and contains '@'
            if (!string.IsNullOrEmpty(email) && email.Contains('@'))
            {
                // Split the email into username and domain parts
                string[] parts = email.Split('@');
                string username = parts[0];
                string domain = parts[1];

                // Construct the masked email address
                string maskedEmail = username.Substring(0, Math.Min(username.Length, 3)) + "***@" + domain;

                // Display the masked email address in a label
                Name1.Text = "We have sent the new password at you email: " + maskedEmail + "";
            }
            else
            {
                // Handle invalid email
                Name1.Text = "Invalid email format";
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
    }
}
