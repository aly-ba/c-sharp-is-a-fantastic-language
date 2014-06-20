using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int hours, WorkType workTyhpe);


    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WordPerformed1);

            WorkPerformedHandler del2 = new WorkPerformedHandler(WordPerformed2);

            WorkPerformedHandler del3 = new WorkPerformedHandler(WordPerformed3); 

            del1 = del2+del2;

            //del1 += del2;
            //del1 += del3;

            del1(10, WorkType.GenerateReports);

            //DoWork(del1);
            //del1(5, WorkType.Golf);
            //del2(10, WorkType.GenerateReports);


            Console.Read();

        }

        static void DoWork(WorkPerformedHandler del)
        {
           del(5, WorkType.GoToMeetings);
        }


        static void WordPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine(" WorkPerformed1 Called" +hours.ToString() );
        }

        static void WordPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine(" WorkPerformed2 Called" +hours.ToString());
        }

        static void WordPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine(" WorkPerformed3 Called" + hours.ToString());
        }
    }
    //enumerateur de worktype
    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
