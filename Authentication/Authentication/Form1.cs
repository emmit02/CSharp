namespace Authentication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String message = this.txtUsername.Text;
            String title = "Login";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result=MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }

        }
    }
}
