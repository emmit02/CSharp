using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrid_learn
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");
        int index;
        private string position ;
        private string salary;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //rb_fresher.Checked = true;

            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("First_name", Type.GetType("System.String"));
            table.Columns.Add("Mobile", Type.GetType("System.Int32"));
            table.Columns.Add("Address", Type.GetType("System.String"));
            table.Columns.Add("Position", Type.GetType("System.String"));
            table.Columns.Add("Salary", Type.GetType("System.String"));


            dgv_contacts.DataSource=table;
        }

        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            index = dgv_contacts.CurrentCell.RowIndex;
            dgv_contacts.Rows.RemoveAt(index);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt_id.Text ,txt_name.Text ,txt_mobile.Text ,txt_address.Text ,position , salary);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_id.Text = String.Empty;
            txt_name.Text = String.Empty;
            txt_mobile.Text = String.Empty;
            txt_address.Text = String.Empty;
            position = String.Empty;
            salary = String.Empty;


        }

        private void dgv_contacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgv_contacts.Rows[index];
            txt_id.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[1].Value.ToString();
            txt_mobile.Text = row.Cells[2].Value.ToString();
            txt_address.Text = row.Cells[3].Value.ToString();
            position = row.Cells[4].Value.ToString();
            salary = row.Cells[5].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = dgv_contacts.Rows[index];
            newData.Cells[0].Value = txt_id.Text;
            newData.Cells[1].Value = txt_name.Text;
            newData.Cells[2].Value = txt_mobile.Text;
            newData.Cells[3].Value = txt_address.Text;
            newData.Cells[4].Value = position;
            newData.Cells[5].Value = salary;
        }

        private void dgv_contacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* this.dgv_contacts.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgv_contacts.DefaultCellStyle.SelectionBackColor = Color.White;*/
        }

        private void rb_fresher_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_fresher.Checked)
            {
                rb_exp.Checked = false;
                position = "Fresher";
                salary = "400000";
            }
        }

        private void rb_exp_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_exp.Checked)
            {
                rb_fresher.Checked = false;
                position = "Experienced";
                salary = "800000";
            }
        }
    }
}
 