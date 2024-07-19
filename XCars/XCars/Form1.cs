using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XCars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_image.Left += 20;
            if(panel_image.Left == 280)
            {
                timer1.Stop();
                //panel2.BackColor = Color.FromArgb(100,255,255,255);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel_image.Left -= 20;
            if (panel_image.Left == 0)
            {
                timer2.Stop();
                //panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
            }
        }

        private void lbl_signin_Click(object sender, EventArgs e)
        {
            //panel2.BackColor = Color.FromArgb(255, 255, 255);
            timer1.Start();
        }

        private void lbl_log_Click(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(255, 255, 255);
            timer2.Start();
        }
    }
}
