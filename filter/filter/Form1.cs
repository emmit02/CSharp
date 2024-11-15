using System.Windows.Forms;

namespace filter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++)
            {
                noofgroupscb.Items.Add(i);
            }

            noofgroupscb.SelectedIndexChanged += noofgroupscb_SelectedIndexChanged;
        }

        private void noofgroupscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            conditionpanel1.Controls.Clear();

            // Get the number of user controls to add from ComboBox selection
            int count = (int)noofgroupscb.SelectedItem;

            // Loop to add User Controls dynamically
            for (int i = 1; i <= count; i++)
            {
                Condition newControl = new Condition();
                newControl.LabelText = $"User Control {i}";

                // Set position and add to the panel
                newControl.Top = (i - 1) * newControl.Height;
                conditionpanel1.Controls.Add(newControl);
            }
        }
    }
}
