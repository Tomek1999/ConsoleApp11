using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace egzamin.Tasks
{
    public class DescribedTask : PriorityTask
    {
        //1 linijka w 1
        public string Description { get; set; }
        //1 linijka w 2
        public DescribedTask()
        {
            Name = "Empty";
            Priority = 0;
        }

        // 2 linijka w 2
        public DescribedTask(string name, int priority, string description) : base(name, priority)
        {
            Name = name;
            Priority = priority;
            Description = description;
        }
        // 3 linijka w 2
        public DescribedTask(DescribedTask task) : base(task) // :base - odwołanie do parametrów rodzica obiektu
        {
            Name = task.Name;
            Priority = task.Priority;
            Description = task.Description;
        }

        public override string ToString()
        {
            return $"{{Name: {Name}; Priority: {Priority}; Description: {Description}}}";
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
                DescribedTask describedTask = obj as DescribedTask;
                return (this.Name == describedTask.Name && this.Priority == describedTask.Priority && this.Description == describedTask.Description);
            }
        }
    }
}