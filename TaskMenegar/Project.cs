using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenegar
{
    public class Project
    {
        public List<Task> tasks;
        public Project()
        {
            tasks = new List<Task>();
        }
        public void AddTask(Task task)
        {
            if (tasks.Contains(task)) Console.WriteLine("This task alredy exists");
            tasks.Add(task);
            Console.WriteLine("Task added");
        }
        public void RemoveTask(Task task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
                Console.WriteLine("Task removed");
            }
            else
            {
                Console.WriteLine("this task doesn't exist in the progect");
            }

        }
        public List<Task> ReturnPendingTasks()
        {
            List<Task> tasks = new List<Task>();
            foreach (Task task in this.tasks)
            {
                if (task.TaskStatus==Status.Pending)
                {
                    tasks.Add(task);
                }
            }
            return tasks;
        }
    }
}
