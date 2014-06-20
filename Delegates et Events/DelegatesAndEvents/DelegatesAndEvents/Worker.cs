using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int WorkerPerforMedHandle(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                //WorkPerformed(i+1, workType);
            }
            OnWorkCompleted();

        }
        protected virtual void OnWorkPerformed(int hours, WorkType Type )
        {
            //if(WorkPerformed != null)
            //{
            //    WorkPerformed(hours, WorkType);
            //}
            //var del = WorkPerformed as WorkPerformedHandler;
            //if(del != null)
            //{
            //    del(hours, WorkType);
            //}
        }



        protected virtual void OnWorkCompleted(int hours, WorkType Type)
        {

            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                //on passe le piplelin
                del(this, EventArgs.Empty);
            }
        }


    }
}
