using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{

    public delegate void WorkPerformedHandler(int hours, WorkType workType); 
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);
            del1 += del2+ del3; 
            del1(5, WorkType.Golf);

        }

        static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.Golf);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("Work Performed 1 Called " + hours.ToString());
        }
        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("Work Performed 2  Called "+ hours.ToString());
        }
        static void WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("Work Performed 3  Called "+ hours.ToString());
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }

}
