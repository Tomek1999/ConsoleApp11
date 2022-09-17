using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przygotowaniesprawdzian.Tasks
{
    public class PriorityTask : ITask
    {
        public string Name { get; set; }
        public int Priority { get; set; }

        public PriorityTask()
        {
            Name = "Empty";
        }
        public PriorityTask(string name, int prio)
        {
            Name = name;
            Priority = prio;
        }

        public PriorityTask(PriorityTask a)
        {
            Name = a.Name;
            Priority = a.Priority;
        }

        public override string ToString()
        {
            return "{" + $"Name: {Name}; Priority:{Priority}" + "}";
        }
    }
}