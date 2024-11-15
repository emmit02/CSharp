using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    static class Program
    {
        static Form1 splashScreen;
        static Thread splashThread;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the splash screen in a separate thread
            splashThread = new Thread(new ThreadStart(ShowSplashScreen));
            splashThread.Start();

            // Load the main application
            LoadMainApplication();

            // Close the splash screen
            splashScreen.Invoke(new Action(() => splashScreen.Close()));

            Application.Run(new MainForm());
        }

        private static void ShowSplashScreen()
        {
            splashScreen = new Form1();
            Application.Run(splashScreen);
        } 

        private static void LoadMainApplication()
        {
            // Simulate loading tasks with progress updates
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50); // Simulate some work
                splashScreen.Invoke(new Action(() => splashScreen.UpdateProgress(i)));
            }
        }

        /*ApplicationConfiguration.Initialize();
        Application.Run(new Form1());*/
    }
}