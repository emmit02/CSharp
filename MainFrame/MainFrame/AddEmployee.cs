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
    public partial class AddEmployee : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public AddEmployee()
        {
            InitializeComponent();

            //to display the data from database to your data grid view  
            displayEmployeeData();
        }
        public void displayEmployeeData()
        { 
            EmployeeData ed= new EmployeeData();
            List<EmployeeData> listData= ed.employeeListData();
            dataGridView1.DataSource = listData;
        }

        private void addEmp_addbtn_Click(object sender, EventArgs e)
        {
            if(addemp_id.Text == "" || addEmp_Fullname.Text == "" || addEmp_Gender.Text == "" ||
                addEmp_phone.Text == "" || addEmp_position.Text == "" || addEmp_status.Text == "" || addEmp_picture.Image == null)
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                    }catch(Exception ex)
                    {

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
