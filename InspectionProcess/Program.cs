using DevExpressKiller;
using InspectionProcess.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

            //Console.WriteLine("Press Enter to quit");
            //Console.ReadLine();
            Thread jobThread = new Thread(() => JobQueueHandler());
            jobThread.IsBackground = true;
            jobThread.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());


        }

        private static void JobQueueHandler()
        {
            while (true)
            {
                if (Helpers.JobQueue.Instance.jobQueue.Count == 0)
                    continue;

                var set = Helpers.JobQueue.Instance.jobQueue.Dequeue();

               Helpers.SocketHelper.ManageSocket(set[0],set[1]);
            }
        }

        private static void ProcessKiller_ShutDown(object sender, ProcessKiller.ShutDownEventArgs e)
        {
            Console.WriteLine($"[{e.Count}] at {DateTime.Now}");
        }
    }
}
