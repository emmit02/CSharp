using System;  
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;

namespace XCars
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

            /*Application.Run(new Main());
            *//*Load load = new Load();
            //load.Show();

            Thread bg = new Thread(() =>
            {
                Main main = new Main();
                main.Load += (sender, args) =>
                {
                    load.Invoke(new Action(() => load.Close()));
                };
                Application.Run(new Main());


            });
            bg.IsBackground = true;
            bg.Start();*//*
*/




        }

        
        /*public static void Main(string[] args)
        {
            Load load = new Load();
            Main main = new Main();

            var th = new Thread(PrintFromThread);
            th.Name = "Child Thread";
            th.Start();

            th.Join();
            Application.Run(new Main());
            Thread.CurrentThread.Name = "Main Thread";
            if(load.Visible  == false)
            {
                main.Visible = true;
            }
        }

        private static void  PrintFromThread()
        {
            Thread.Sleep(5000);
            Application.Run(new Load());

        }*/
    }
}
