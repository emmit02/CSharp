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

            /*Load load = new Load();
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
            bg.Start();*/

            Application.Run(new Main());
            
        }
    }
}
