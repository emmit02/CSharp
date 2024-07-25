using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Web.UI.Design.WebControls;

namespace XCars
{
    public partial class Main : Form
    {
        
        private Load loadingForm;

        public Main()
        {
            InitializeComponent();
        }


        private void guna2TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            guna_lbl_prix.Text = guna2TrackBar1.Value.ToString() + "€";
        }

        private void guna2TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            guna_lbl_ann.Text = guna2TrackBar2.Value.ToString();
        }

        private void guna2TrackBar3_ValueChanged(object sender, EventArgs e)
        {
            guna_lbl_km.Text = guna2TrackBar3.Value.ToString() + "km";
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if(guna_pb_car.Image != null)
            {
                guna_pb_car.Image = new Bitmap(guna2PictureBox1.Image);
                guna_pb_car.Dock = DockStyle.Fill;
            }


            //guna_pb_car.Image = guna_pb_1.Image;
            //guna_pb_1.Load("images_car\audi1.png");
            //guna_pb_2.Load("images_car\audi1.png");
            //guna_pb_3.Load("images_car\audi1.png");

            //guna_lbl_pp.Text = guna2HtmlLabel10.Text; 
        }

        private void guna_pb_1_Click(object sender, EventArgs e)
        {
            guna_pb_car.Image = guna_pb_1.Image;
        }

        private void guna_pb_2_Click(object sender, EventArgs e)
        {
            guna_pb_car.Image = guna_pb_2.Image;
        }

        private void guna_pb_3_Click(object sender, EventArgs e)
        {
            guna_pb_car.Image = guna_pb_3.Image;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            /*guna_pb_car.Image = guna_pb_1.Image;
            guna_pb_1.Load("XCars\\images_car\audi5.png");
            guna_pb_2.Load("XCars\\images_car\audi5.png");
            guna_pb_3.Load("XCars\\images_car\audi5.png");

            guna_lbl_pp.Text = guna2HtmlLabel13.Text;*/
        }

        private void guna_pb_car_Click(object sender, EventArgs e)
        {
            guna_pb_car.Image = guna_pb_3.Image;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnLoad(EventArgs e)
        {
            
            base.OnLoad(e);
            // Hide the main form initially
            this.Visible = false;

            // Show the loading form
            loadingForm = new Load();
            loadingForm.Show();                                   //ShowDialog()  is used for only showing the whole dialogue box but it pauses the asynchronicy 
            //loadingForm.BringToFront();
            // Start the background worker
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(1000); // Simulate a task
                backgroundWorker1.ReportProgress(i);

            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (loadingForm != null)
            {
                loadingForm.Close();
                loadingForm.Dispose();
                loadingForm = null;
            }

            // Show the main form
            this.Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }





        /*private void UpdateProgress(int progress)
        {
            if (loadingForm != null && loadingForm.InvokeRequired)
            {
                loadingForm.Invoke(new Action<int>(UpdateProgress), progress);
            }
            else
            {
                try
                {
                    loadingForm?.UpdateProgress(progress);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }*/
    }
}
