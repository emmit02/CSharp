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

namespace XCars
{
    
    public partial class Load : Form
    {
        public Load()
        {

            InitializeComponent();
        }


        private void Load_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }


       /* public void UpdateProgress(int progress)
        {
            if (loader_bar.Value == progress)
            {
                loader_bar.Value = progress;
                this.Hide();
            }
            else
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loader_bar.Value < 100)
            {
                loader_bar.Value += 1;
                percent_load.Text = loader_bar.Value.ToString() + "%";

            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
