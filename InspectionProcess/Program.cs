using DevExpressKiller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectionProcess
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ProcessKiller.Instance.ShutDown += ProcessKiller_ShutDown;
            ProcessKiller.Instance.Start(interval: 500);

            Console.WriteLine("Press Enter to quit");
            Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void ProcessKiller_ShutDown(object sender, ProcessKiller.ShutDownEventArgs e)
        {
            Console.WriteLine($"[{e.Count}] at {DateTime.Now}");
        }
    }
}
