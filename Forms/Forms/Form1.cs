using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void register_btn_Click(object sender, EventArgs e)
        {

            try
            {
                if (reg_firstname.Text != "" || reg_lastname.Text != "" || reg_email.Text != "" || reg_phone.Text != "")
                {
                    MessageBox.Show("Register Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);   //messagebox("message","tittle")   
                    dataGridView dgv = new dataGridView();
                    dgv.Show();

                }
                else 
                {
                    MessageBox.Show("Please fill all the blank field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);   //messagebox("message","tittle")                                    
                }




            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public class Student
        {
            public string Name { get; set; }
            public string Contact { get; set; }

            public Student(string name, string contact)
            {
                Name = name;
                Contact = contact;
            }
        }

        public class MainForm : Form
        {
            private DataGridView dataGridView;

            public MainForm(List<Student> students)
            {
                // Initialize the DataGridView
                dataGridView = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                };

                // Bind the list to the DataGridView
                dataGridView.DataSource = students;

                // Add the DataGridView to the form
                Controls.Add(dataGridView);

                // Set the form properties
                Text = "Student Data";
                Width = 800;
                Height = 600;
            }   
        }












        /*private void reg_email_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (reg_email.ToString(Contains("@gmail.com"))
                {
                    reg_email.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    reg_email.Text = "Invalid Email";
                    reg_email.ForeColor = System.Drawing.Color.Red;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            try{
                if(reg_firstname.Text != "" || reg_lastname.Text != "" || reg_email.Text != "" || reg_phone.Text != "")
                {
                    reg_firstname.Text = string.Empty;
                    reg_lastname.Text = string.Empty;
                    reg_email.Text = string.Empty;
                    reg_phone.Text = string.Empty;
                }

                List<Student> students = new List<Student>
                {
                new Student("Alice", "88888888"),
                new Student("Bob", "777777777"),
                new Student("Charlie", "7777777777")
                };

                Application.EnableVisualStyles();

            }
            catch(Exception ex)
            {
                
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        



        /*private void reg_email_TextChanged(object sender, EventArgs e)
        {
            string email = reg_email.Text;
            if (IsValidEmail(email))
            {
                reg_email.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                reg_email.Text = "Invalid Email";
                reg_email.ForeColor = System.Drawing.Color.Red;
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@gmail\.com$|^[^@\s]+\.com$|^[^@\s]+\.in$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }*/
    }
}
