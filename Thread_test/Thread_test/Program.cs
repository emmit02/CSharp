using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Thread_test
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Task task = new Task(() =>
            {
                    Console.WriteLine("Running task in a separate thread");
                    int result = AddNumbers(5, 10);
                    Console.WriteLine("Result of addition: " + result);
            });
            task.Start();
            Console.WriteLine("Main Thread is done");
            Console.ReadLine();
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

    }



    //another program


    /*public class Myobject
    {
        int _index;
        int pCount;

        public void MyownMethod()
        {
            pCount = Environment.ProcessorCount - 1;
            int a = 0;

            Console.WriteLine("Started Thread");
            for (int i = 0; i < 1000000000; ++i)
            {
                a++;
            }
            for (int i = 0; i < 1000000000; ++i)
            {
                a++;
            }
            for (int i = 0; i < 1000000000; ++i)
            {
                a++;
            }
            for (int i = 0; i < 1000000000; ++i)
            {
                a++;
            }
            for (int i = 0; i < 1000000000; ++i)
            {
                a++;
            }
            for (int i = 0; i < 1000000000; ++i)
            {
                a++;
            }
            for (int i = 0; i < 1000000000; ++i)
            {
                a++;
            }
            for (int i = 0; i < 1000000000; ++i)
            {
                a++;
            }

            Console.WriteLine("Finished Job 1");
            Program.count++;
            if (Program.count == 3)
            {
             *//*   Program.stopWatch.Stop();
                TimeSpan ts = Program.stopWatch.Elapsed;

                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                Console.WriteLine("Runtime: " + elapsedTime);*//*
            }

        }

        public Myobject(int index)
        {
            _index = index;
        }
        
    }
    class Program
    {
        public static int count = 0;
        public static Stopwatch stopWatch = new Stopwatch();
        
        static void Main()
        {
            int threadCount = Environment.ProcessorCount;
            stopWatch.Start();

            for(int i=0;i<3;++i)
            {
                Myobject mob = new Myobject(i);
                Thread thr = new Thread(mob.MyownMethod);
                thr.Start();
                thr.Join();
            }
            Program.stopWatch.Stop();
            TimeSpan ts = Program.stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Runtime: " + elapsedTime);
        }

    }*/

    /*public class Program
    {
        public static void Main(string[] args)
        {
            var th = new Thread(PrintFromThread);
            th.Name = "Child Thread";
            th.Start();

            th.Join();

            Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine($"Print from{Thread.CurrentThread.Name}");
        }

        private static void  PrintFromThread()
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Print from{Thread.CurrentThread.Name}");
        }

    }*/
}
