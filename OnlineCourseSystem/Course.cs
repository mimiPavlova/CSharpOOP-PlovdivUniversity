using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseSystem
{
    public class Course
    {
        public string Name { get; }
        public List<Student> Students;
        public Course(string name) 
        {
            if(string.IsNullOrWhiteSpace(name))throw new ArgumentNullException("name cannot be null");
             this.Name = name;
            this.Students=new List<Student>();
        }
        public void EnrollStudent(Student student)
        {
            if(Students.Contains(student))
                Console.WriteLine("This student is alredy in the course");
            else
            {
                Students.Add(student);
                Console.WriteLine("Student added");
            }
        }
        public void RemoveStudent(string username)
        {
            Student student=Students.FirstOrDefault(s=>s.UserName == username);
            if(student != null)
            {
                Students.Remove(student);
                Console.WriteLine("Student removed");

            }
            else
            {
                Console.WriteLine("This student is not in the course");
            }
        }
        public List<string> ListEnrolledStudents()
        {
            List<string> result = new List<string>();
            foreach (Student s in Students)
            {
                result.Add(s.UserName);
            }
            return result;
        }
    }
}
