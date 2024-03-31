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

            var connectionString = "data source =KISSASIUM\\SQLEXPRESS;database = edusync; integrated security = True";

            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();

            // checks 

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

                            this.Hide();
                            var form3 = new Assignmnet();
                            form3.Closed += (s, args) => this.Close();
                            form3.Show();
                        }
                        else
                        {


                            Dashboard dash = new Dashboard();
                            dash.Show();
                            this.Hide();

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

        //private void loginButton_Click(object sender, EventArgs e)
        //{
        //    var email = emailtextBox.Text;
        //    var password = PasswordtextBox.Text;

        //    var connectionString = "data source = DESKTOP - 88SEP50\\SQLEXPRESS; database = EduSync; integrated security = True";
        //    // string connectionString = "data source=DESKTOP-88SEP50\\SQLEXPRESS; database=EduSync; integrated security=True";
        //    SqlConnection connection = new SqlConnection(connectionString);

        //        connection.Open();
        //        SqlConnection sqlconn = new SqlConnection(connectionString);
        //        sqlconn.Open();

        //        // checks 

        //        if (email == "" || password == "")
        //        {
        //            MessageBox.Show("Please fill all fields");
        //            return;
        //        }

        //        if (!email.Contains("@"))
        //        {
        //            MessageBox.Show("Email addres should contain @.");
        //            return;
        //        }

        //        try
        //        {
        //            string query = "Select email, passwordd from users where email = '" + email + "' and passwordd = '" + password + "'";
        //            SqlCommand cmd = new SqlCommand(query, connection);
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            if (reader.Read())
        //            {
        //                MessageBox.Show("Welcome to EduSync!");
        //                reader.Close();

        //                string query1 = "Select usertype from users where email = '" + email + "' ";
        //                SqlCommand cmd1 = new SqlCommand(query1, connection);
        //                SqlDataReader reader1 = cmd1.ExecuteReader();

        //                if (reader1.Read())
        //                {
        //                    string usertype = reader1["UserType"].ToString();
        //                    reader1.Close();

        //                    if (usertype == "Administrator")
        //                    {


        //                        this.Hide();
        //                        var form3 = new Admin_Profile();        // admins profile 
        //                        form3.Closed += (s, args) => this.Close();
        //                        form3.Show();
        //                    }
        //                    else if (usertype == "Instructor")
        //                    {

        //                        this.Hide();
        //                        var form3 = new Assignmnet();
        //                        form3.Closed += (s, args) => this.Close();
        //                        form3.Show();
        //                    }
        //                    else
        //                    {

        //                        // arham add your student page here 

        //                       Form1 form = new Form1();
        //                        form.Show();
        //                        this.Hide();
        //                    }


        //                }
        //                else
        //                {
        //                    MessageBox.Show("error while selecting usertypr ");

        //                }
        //                reader1.Close();
        //            }

        //            else
        //            {
        //                MessageBox.Show("Incorrect email or password ");
        //            }

        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show("Error!" + ex.Message);
        //        }
        //        finally
        //        {
        //             sqlconn.Close();

        //        }
        //    }

        //private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}

