using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Helpers
{
    public class JobQueue
    {
        #region singleton
        private JobQueue()
        {
            jobQueue = new Queue<List<int>>();
        }

        private static JobQueue _instance = null;

        public static JobQueue Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new JobQueue();

                return _instance;
            }
        }
        #endregion

        public Queue<List<int>> jobQueue { get; set; }

        internal void AddList(int inspectionResultId, int inspectionId)
        {
            List<int> idSet = new List<int>();
            idSet.Add(inspectionResultId);
            idSet.Add(inspectionId);
            Instance.jobQueue.Enqueue(idSet);
        }
    }
}
