using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MainFrame
{
     
    public partial class RegisterForm : Form
    {
        SqlConnection connect
        = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginbtn_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all the blank field", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);   //messagebox("message","tittle")   

            }
            else
            {
                if(connect.State!=ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //to check if the user is already taken or not
                        string selectUserName = "Select count(id) from Users Where username = @user";
                        using (SqlCommand checkUser = new SqlCommand(selectUserName, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar(); 
                            if(count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + " is already taken", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO users" +
                                    "(username,password,date_register )" +
                                    "Values(@username,@password,@dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registration Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);   //messagebox("message","tittle")   

                                    Login loginform = new Login();
                                    loginform.Show();
                                    this.Hide();

                                }
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
