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

namespace Testing_Multithreading
{
    public partial class MainForm : Form
    {
        private Form1 loadingForm;
        public MainForm()
        {
            InitializeComponent();
        }

        protected override async void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        // Hide the main form initially
        this.Visible = false;

        // Show the loading form
        loadingForm = new Form1();
        loadingForm.Show();

        // Perform the initialization tasks asynchronously
        await InitializeAsync();

        // Close the loading form
        loadingForm.Close();
        loadingForm.Dispose();
        loadingForm = null;

        // Show the main form
        this.Visible = true;
    }

    private async Task InitializeAsync()
    {
        // Perform the long-running initialization tasks here
        for (int i = 0; i <= 100; i++)
        {
            await Task.Delay(50); // Simulate a task
            UpdateProgress(i);
        }
    }

    private void UpdateProgress(int progress)
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
                catch(Exception ex)
                {
                    MessageBox.Show("Error");
                }
        }
    }
    }
}
