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
