using Microsoft.VisualBasic.Devices;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Xml.Linq;
using System.Data;
using System.Windows.Forms;

namespace grid_through_list
{
    public partial class Form1 : Form
    {
        public List<Person> Peoples ;
        Person People;
        //DataTable col = new DataTable("table");


        public Form1()
        {
            //Peoples = GetPeople();
            InitializeComponent();
        }

        public Form1(List<Person> peoples, Person people, IContainer components, DataGridView dataGridView1, Label label1, Label label2, Label label3, TextBox txt_id, TextBox txt_fn, TextBox txtln, TextBox txt_profession, Label label4, Button btn_add)
        {
            Peoples = peoples;
            People = people;
            this.components = components;
            this.dataGridView1 = dataGridView1;
            this.label1 = label1;
            this.label2 = label2;
            this.label3 = label3;
            this.txt_id = txt_id;
            this.txt_fn = txt_fn;
            this.txtln = txtln;
            this.txt_profession = txt_profession;
            this.label4 = label4;
            this.btn_add = btn_add;
        }

        public List<Person>? GetPeople()
        {
            //var list = new List<Person>();
            /*list.Add(new Person() { PersonId = 2, Name = "Person 2", Surname = "Surname 2", Profession = "Profession 2" });
            list.Add(new Person() { PersonId = 3, Name = "Person 3", Surname = "Surname 3", Profession = "Profession 3" });
*/
            return Peoples;
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            People = new Person();
            Peoples = new List<Person>();
            // dataGridView1.DataSource = Peoples;
            /*col.Columns.Add("ID", Type.GetType("System.Int32"));
            col.Columns.Add("Name", Type.GetType("System.String"));
            col.Columns.Add("Surname", Type.GetType("System.Int32"));
            col.Columns.Add("Profession", Type.GetType("System.String"));
            */
            try
            {
                dataGridView1.ColumnCount = 4;

                dataGridView1.Columns[0].Name = "PersonId";
                dataGridView1.Columns[1].Name = "Name";
                dataGridView1.Columns[2].Name = "Surname";
                dataGridView1.Columns[3].Name = "Profession";

                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;

                // dataGridView1.DataSource = null;
                dataGridView1.DataSource = Peoples;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    var selectedPerson = dataGridView1.SelectedRows[0].DataBoundItem as Person;
            //    txt_id.Text = selectedPerson.PersonId.ToString();
            //    txt_fn.Text = selectedPerson.Name.ToString();
            //    txtln.Text = selectedPerson.Surname.ToString();
            //    txt_profession.Text = selectedPerson.Profession.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error Occured: ", ex.Message + " - " + ex.Source);
            //}
        }

        private void btn_add_Click(object sender, EventArgs e)
        {            
            try
            {
                Peoples.Add(new Person
                {
                    PersonId = Convert.ToInt32(txt_id.Text),
                    Name = txt_fn.Text,
                    Surname = txtln.Text,
                    Profession = txt_profession.Text
                });
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Peoples;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
