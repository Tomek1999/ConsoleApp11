using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace egzamin.Tasks
{
    public class PriorityTask : ITask
    {
        public string Name { get; set; } /// <summary>
                                         /// 1 linijka z ptask
                                         /// </summary>
        public int Priority { get; set; } //2 linijka z ptask

        //create - konstruktor, metoda tego samego typu co klasa
        // konstruktor - tworzy obiekt klasy
        public PriorityTask()
        //   tasksManager.AddTask(new PriorityTask()); - 1 linijka //
        {
            Name = "Empty";
            Priority = 0;
        }

        //2 linijka//
        public PriorityTask(string name, int priority)
        {
            //tasksManager.AddTask(new PriorityTask("Task 1", 1));
            Name = name;
            Priority = priority;
        }

        //3 linijka
        public PriorityTask(PriorityTask task)
        {
            Name = task.Name;
            Priority = task.Priority;
        }

        //4 linijka
        public override string ToString()
        {
            return $"{{Name: {Name}; Priority: {Priority}}}";

        }
        //zadanie 3
        public override bool Equals(object obj)
        {
            //mozna skopiowac z dokumentacji https://docs.microsoft.com/en-us/dotnet/api/system.object.equals?view=net-6.0
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                //tego juz nie kopiujemy 
                PriorityTask priorityTask = obj as PriorityTask;
                return (this.Name == priorityTask.Name && this.Priority == priorityTask.Priority);
            }
        }
    }
}