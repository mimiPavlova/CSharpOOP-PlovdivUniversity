using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseSystem
{
    public class Student
    {
        public string UserName { get; }
        public Student(string username)
        {
            if(string.IsNullOrWhiteSpace(username))throw new ArgumentNullException("username cannot be null");
        this.UserName = username;
        }
    }
}
