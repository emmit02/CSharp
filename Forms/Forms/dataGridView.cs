using formManipulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class dataGridView : Form
    {
        public dataGridView()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*DataTable table = new DataTable();
        int indexRow;
        private void dataGridView_Load(Object sender, EventArgs e)        
        {
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Course", typeof(string));
            table.Columns.Add("Branch", typeof(string));
            table.Columns.Add("Course", typeof(int));


            table.Rows.Add(1, "course" , "braNch" , 2010);
            table.Rows.Add(2, "A", "A", 2010);

            dataGridView2.DataSource = table;
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[indexRow];
            label.Text = row.Cells[1].Value.ToString();
            dgv_lbl_coarse.Text = row.Cells[1].Value.ToString();
            dgv_lbl_branch.Text = row.Cells[2].Value.ToString();
            dgv_lbl_year.Text = row.Cells[3].Value.ToString();

        }

        private void dgv_btn_insert_Click(object sender, EventArgs e)
        {

        }

        private void dgv_btn_update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView2.Rows[indexRow];
            newDataRow.Cells[0].Value = label.Text;
            newDataRow.Cells[0].Value = dgv_lbl_coarse.Text;
            newDataRow.Cells[0].Value = dgv_lbl_branch.Text;
            newDataRow.Cells[0].Value = label.Text;
        }




*/

        /*private void dataGridView_Load(object sender,EventArgs e)
        {
            var person = this.person;
            dataGridView1.DataSource = person;
            dataGridView1.Columns["PersonId"].Visible = false;

        }*/

        /*public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedPerson = dataGridView1.SelectedRows[0].DataBoundItem as Person;
                
            }catch(Exception ex)
            {
                MessageBox.Show("Some Error Occured: " + ex.Message + " - " + ex.Source);
            }
        }*/


    }
}
