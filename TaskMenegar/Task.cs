using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenegar
{
    public class Task
    {
        public string Name { get; }

        public User Creator { get; }
        public Status TaskStatus { get; }

        public Task(string name, User creator, Status taskStatus)
        {
            if(string.IsNullOrEmpty(name)) throw new ArgumentNullException("name cannot be null");
            Name=name;

            Creator=creator;
            TaskStatus=taskStatus;
        }
    }
}
