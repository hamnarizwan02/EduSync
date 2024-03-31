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
using Microsoft.IdentityModel.Protocols.Configuration;

namespace WinFormsApp1
{
    public partial class Admin_Profile : Form
    {
        public Admin_Profile()
        {
            InitializeComponent();
            this.Load += Admin_Profile_Load;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;

            this.Hide();
            var form3 = new enrolledStudents();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button2.Height;
            panelLeft.Top = button2.Top;

            this.Hide();
            var form3 = new Admin_Profile();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button3.Height;
            panelLeft.Top = button3.Top;

            this.Hide();
            var form3 = new enrollTeacher();
            form3.Closed += (s, args) => this.Close();
            form3.Show(); ;
        }
        private void Admin_Profile_Load(object sender, EventArgs e)
        {
            var connectionString = "data source = LAPTOP-S1HUQ0ID\\SQLEXPRESS;database = LMS; integrated security = True"; ;
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();
            try
            {
                string query22 = "select uname from users where usertype = 'Administrator';";
                SqlCommand cmd32 = new SqlCommand(query22, sqlconn);
                SqlDataReader reader32 = cmd32.ExecuteReader();

                if (reader32.Read())
                {
                    string AdminName = reader32["uname"].ToString();
                    reader32.Close();
                    textBox4.Text = AdminName;

                }
                else
                {
                    MessageBox.Show("couldnt display name of the admin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = button4.Height;
            panelLeft.Top = button4.Top;

            this.Hide();
            var form3 = new enrolledStudents();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            var form9 = new login();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
            this.Hide();
        }

        private void showFiles_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source=LAPTOP-S1HUQ0ID\\SQLEXPRESS;Database = LMS; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();


            var password = passwordBox.Text; 
            var name = nameBox.Text;

            if(password == "")
            {
                try
                {
                    string query22 = "update Users set uname = '" + name + "' where usertype = 'Administrator';";
                    SqlCommand cmd32 = new SqlCommand(query22, sqlconn);
                  
                    int rowsAffected = cmd32.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Name of the administrator updated successfully.");

                        // to show updated name 
                        this.Hide();
                        var form3 = new Admin_Profile();
                        form3.Closed += (s, args) => this.Close();
                        form3.Show();

                    }
                    else
                    {
                        MessageBox.Show("couldnt update the name of the admin. error occured ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlconn.Close();
                }

            }
            else if(name == "")
            {
                try
                {
                    string query22 = "update Users set passwordd = '" + password + "' where usertype = 'Administrator';";
                    SqlCommand cmd32 = new SqlCommand(query22, sqlconn);

                    int rowsAffected = cmd32.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password of the administrator updated successfully.");

                    }
                    else
                    {
                        MessageBox.Show("couldnt update the password of the admin. Error occured ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlconn.Close();
                }

            }
            else
            {
                try
                {
                    string query22 = "update Users set uname = '" + name + "', passwordd ='" + password + "' where usertype = 'Administrator';";
                    SqlCommand cmd32 = new SqlCommand(query22, sqlconn);

                    int rowsAffected = cmd32.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Name and password of the administrator updated successfully.");

                        // to show updated name 
                        this.Hide();
                        var form3 = new Admin_Profile();
                        form3.Closed += (s, args) => this.Close();
                        form3.Show();

                    }
                    else
                    {
                        MessageBox.Show("couldnt update the name and password of the admin. error occured ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlconn.Close();
                }
            }
        }
    }

}
