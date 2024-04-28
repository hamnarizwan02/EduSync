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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        private int userID;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

            ForgotPass forgotPasswordForm = new ForgotPass(emailtextBox.Text);
            forgotPasswordForm.Show();
            this.Hide();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            var email = emailtextBox.Text;
            var password = PasswordtextBox.Text;

            //instructor 
            //var email = "j@gmail.com";
            //var password = "Jennifer1";

            var connectionString = Constant.ConnectionString;

            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            // checks 

            if (email.Count(c => c == '@') != 1)
            {
                MessageBox.Show("Email address should contain exactly one '@' symbol.");
                return;
            }

            var atIndex = email.IndexOf('@');
            if (atIndex > 15 || atIndex == -1)
            {
                MessageBox.Show("Email address should not empty or exceed 15 characters (excluding @).");
                return;
            }

            if (password.Length > 15)
            {
                MessageBox.Show("Password should not exceed 15 characters.");
                return;
            }

            if (email == "" || password == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Email addres should contain @.");
                return;
            }


            try
            {
                string query = "Select email, passwordd from users where email = '" + email + "' and passwordd = '" + password + "'";
                SqlCommand cmd = new SqlCommand(query, sqlconn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Welcome to EduSync!");
                    reader.Close();

                    string query1 = "Select usertype from users where email = '" + email + "' ";
                    SqlCommand cmd1 = new SqlCommand(query1, sqlconn);
                    SqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.Read())
                    {
                        string usertype = reader1["UserType"].ToString();
                        reader1.Close();

                        if (usertype == "Administrator")
                        {


                            this.Hide();
                            var form3 = new Admin_Profile();        // admins profile 
                            form3.Closed += (s, args) => this.Close();
                            form3.Show();
                        }
                        else if (usertype == "Instructor")
                        {

                            try
                            {
                                string query3 = "SELECT userID FROM users WHERE email = '" + email + "' AND passwordd = '" + password + "'";
                                SqlCommand cmd3 = new SqlCommand(query3, sqlconn);
                                object result = cmd3.ExecuteScalar();

                                if (result != null)
                                {
                                    userID = Convert.ToInt32(result);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error fetching userID: " + ex.Message);
                            }

                            this.Hide();
                            var form3 = new Assignmnet(userID);
                            form3.Closed += (s, args) => this.Close();
                            form3.Show();
                        }
                        else
                        {
                            try
                            {
                                string query3 = "SELECT userID FROM users WHERE email = '" + email + "' AND passwordd = '" + password + "'";
                                SqlCommand cmd3 = new SqlCommand(query3, sqlconn);
                                object result = cmd3.ExecuteScalar();

                                if (result != null)
                                {
                                    userID = Convert.ToInt32(result);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error fetching userID: " + ex.Message);
                            }
                            Dashboard dash = new Dashboard(userID);
                            dash.Show();
                            this.Hide();



                            //Dashboard dash = new Dashboard();
                            //dash.Show();
                            //this.Hide();

                        }


                    }
                    else
                    {
                        MessageBox.Show("error while selecting usertypr ");

                    }
                    reader1.Close();
                }

                else
                {
                    MessageBox.Show("Incorrect email or password ");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!" + ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

