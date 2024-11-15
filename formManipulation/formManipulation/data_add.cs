using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formManipulation
{
    public partial class data_add : Form
    {
        public data_add()
        {
            InitializeComponent();
        }

        private void enter_btn_Enter(object sender, EventArgs e)
        {
            enter_btn.BackColor = Color.SeaGreen;
     
        }
    }
}
