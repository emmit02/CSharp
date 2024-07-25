namespace Testing_Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void UpdateProgress(int progress)
        {
            progressBar1.Value = progress;
        }
    }


    
}
