using System;
using przygotowaniesprawdzian.Tasks;

namespace przygotowaniesprawdzian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DescribedTask baseTask = new DescribedTask("Base task", 3, "Base task description");

            TaskManager tasksManager = new TaskManager();

            tasksManager.TaskAdded += (s, args) => {
                Console.WriteLine($"Task Added: {args.task.Name}");
            };

            tasksManager.TaskFinished += (s, args) => {
                Console.WriteLine($"Task Finished: {args.task.Name}");
            };

            tasksManager.AddTask(new PriorityTask());
            tasksManager.AddTask(new PriorityTask("Task 1", 1));
            tasksManager.AddTask(new DescribedTask("Task 2", 2, "Description 2"));
            tasksManager.AddTask(new DescribedTask("Task 3", 2, "Description 3"));
            tasksManager.AddTask(new PriorityTask(baseTask));
            tasksManager.AddTask(new DescribedTask(baseTask));

            Console.WriteLine("\n" + tasksManager);

            Console.WriteLine("-----------------------------------");

            tasksManager.FinishTask(1);
            tasksManager.FinishTask(0);

            Console.WriteLine("\n" + tasksManager);



        }
    }
}