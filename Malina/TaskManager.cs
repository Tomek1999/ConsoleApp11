using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using przygotowaniesprawdzian.Tasks;

namespace przygotowaniesprawdzian
{
    public class TaskManager
    {
        private List<ITask> waitingTasks;
        private List<ITask> finishedTasks;

        public TaskManager()
        {
            waitingTasks = new List<ITask>();
            finishedTasks = new List<ITask>();
        }

        public void AddTask(ITask task)
        {
            waitingTasks.Add(task);
            OnTaskAdded(task);
        }

        public void FinishTask(int index)
        {
            finishedTasks.Add(waitingTasks[index]);
            OnTaskFinished(waitingTasks[index]);
            waitingTasks.RemoveAt(index);


        }

        public event EventHandler<TaksArgs> TaskAdded;

        public event EventHandler<TaksArgs> TaskFinished;

        protected virtual void OnTaskAdded(ITask a)
        {
            TaskAdded.Invoke(this, new TaksArgs(a));
        }

        protected virtual void OnTaskFinished(ITask a)
        {
            TaskFinished.Invoke(this, new TaksArgs(a));
        }


        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < waitingTasks.Count; i++)
            {
                temp += $"- {i + 1}: {waitingTasks[i].ToString()}\n";
            }

            string fin = "";
            for (int i = 0; i < finishedTasks.Count; i++)
            {
                fin += $"+ {i + 1}: {finishedTasks[i].ToString()}\n";
            }

            return "WAITING: \n" + temp + "FINISHED: \n" + fin;

        }


    }
}