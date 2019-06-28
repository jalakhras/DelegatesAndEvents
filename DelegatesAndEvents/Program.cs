using System;

namespace DelegatesAndEvents
{

    class Program
    {
        static void Main(string[] args)
        {
            //WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            //WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            //WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);
            //del1 += del2 + del3;
            //int finalHours = del1(5, WorkType.Golf);
            //Console.WriteLine("final Hours : " + finalHours.ToString());
            Worker worker = new Worker();
            worker.WorkPerformed += Worker_WorkPerformed;
            worker.WorkPerformed -= Worker_WorkPerformed;
            worker.WorkCompleted += worker_WorkComplate;
            worker.DoWork(8, WorkType.GenerateReports);
        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Houres Worked : " + e.Hours + " " + e.WorkType);
        }

        
        static void worker_WorkComplate(object sender  , EventArgs eventArgs)
        {
            Console.WriteLine("Worker is Done");
        }
        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.Golf);
        //}

        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("Work Performed 1 Called " + hours.ToString());
        //    return hours + 1;
        //}
        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("Work Performed 2  Called " + hours.ToString());
        //    return hours + 2;
        //}
        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("Work Performed 3  Called " + hours.ToString());
        //    return hours + 3;
        //}
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }

}
