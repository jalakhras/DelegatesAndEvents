using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{

    public delegate int WorkPerformedHandler(int hours, WorkType workType);
    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted; 
        public void DoWork(int hours , WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }

        private void OnWorkPerformed (int hours , WorkType workType)
        { 

            var del = WorkPerformed as WorkPerformedHandler;
            if (del != null)
            {
                del(hours, workType);
            }

        }

        private void OnWorkCompleted()
        { 

            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }

        }
    }
}
