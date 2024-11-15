namespace Splash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void UpdateProgress(int progress)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action(() => progressBar1.Value = progress));
            }
            else
            {
                progressBar1.Value = progress;
            }
        }
    }
}
