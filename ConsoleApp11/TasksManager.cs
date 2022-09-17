using System;
using System.Collections.Generic;
using System.Text;
using egzamin.Tasks;

namespace egzamin
{
    public class TasksManager
    {
        // 1 linijka w 1
        private List<ITask> waitingTasks;
        // 2 linijka w 1
        private List<ITask> finishedTasks;

        //zad 2
        public delegate void TaskAddedHandler(ITask task);
        public delegate void TaskFinishedHandler(ITask task);

        public event TaskAddedHandler TaskAdded;
        public event TaskFinishedHandler TaskFinished;

        //to dodatkowe
        public TasksManager()
        {
            waitingTasks = new List<ITask>();
            finishedTasks = new List<ITask>();
        }
        //1 linijka w 2
        public void AddTask(ITask task)
        {
            waitingTasks.Add(task);

            //kontynuacja zadania 2
            TaskAdded.Invoke(task);
        }


        // 2 linijka w 2
        public void FinishTask(int index)

        {
            //kontynuacja zad 2.2
            TaskFinished.Invoke(waitingTasks[index]);
            //koniec
            //2 linijka w 2
            finishedTasks.Add(waitingTasks[index]);

            waitingTasks.RemoveAt(index);
        }

        public override string ToString()
        {
            string output = "WAITING:\n";
            int i = 1;
            foreach (ITask task in waitingTasks)
            {
                output += $"- {i}: {task}\n";
                i++;
            }
            i = 1;
            output += "FINISHED:\n";
            foreach (ITask task in finishedTasks)
            {
                output += $"+ {i}: {task}\n";
                i++;
            }


            return output;
        }

    }
}