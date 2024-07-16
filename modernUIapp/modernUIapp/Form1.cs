using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modernUIapp
{
    public partial class form : Form
    {
        //fields
        private int bordersize = 2;
        //constructor
        public form()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(98, 102, 244);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //overridden
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;

            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1;
            const int HTLEFT = 10; 
            const int HTRIGHT = 11; 
            const int HTTOP = 12;   
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15; 
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());                            
                        Point clientPoint = this.PointToClient(screenPoint);                          
                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)  
                                m.Result = (IntPtr)HTTOPLEFT; 
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP; 
                            else 
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) 
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else 
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32()==1)
            {
                return;
            }
            base.WndProc(ref m);
        }
        //event method
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        //private method
        private void AdjustForm()
        {
            switch(this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if(this.Padding.Top != bordersize)
                    this.Padding = new Padding(bordersize);
                    break;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void btn_maximized_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if(this.panelMenu.Width>200) //collapse Me  nu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                btn_menu.Dock = DockStyle.Top;
                foreach(Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else//expand menu
            {
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                btn_menu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10,0,0,0);
                }
            }
        }

        
    }
}