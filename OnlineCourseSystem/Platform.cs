using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourseSystem
{
    public class Platform
    {
        public string Name { get; }
        public List<Course> Courses { get; set; }

        public Platform(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name cannot be null");
            Name=name;
            Courses = new List<Course>();

        }
        public void AddCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                Console.WriteLine("Course alredy exists"); return;
            }
            Courses.Add(course);
            Console.WriteLine("Course added");
        }
        public Course FindCourseByName(string name)
        {
            Course course=Courses.FirstOrDefault(c=> c.Name==name);
            if (course!=null) return course;
            else
            {
                throw new ArgumentException("This course doesnt exists");
            }
        }
        public void PrintAllCoursesAndStudents()
        {
            foreach(Course course in Courses)
            {
                Console.WriteLine($"Course name: {course.Name}");
                Console.WriteLine("Students: ");
                foreach(Student student in course.Students)
                {
                    Console.WriteLine(student.UserName);
                }
            }
        }
    }
}
