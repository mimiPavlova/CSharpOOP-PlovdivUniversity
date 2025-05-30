using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string Name { get; }
        public string id { get; }

        Dictionary<Class, double> Grades;
        public Student(string name, string id)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name cannot be null");
            Name=name;
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException("id cannot be null");
            this.id=id;
            this.Grades=new Dictionary<Class, double>();
        }

        public int GetNumberOfClases => this.Grades.Count;

        public string DisplayGrades()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var (c, grade) in Grades)
            {
                stringBuilder.AppendLine($"{c.name} -> {grade}");
            }
            return stringBuilder.ToString().Trim();

        }
        public double GetGrade(Class c)
            => Grades[c];

        public double AverageGrade => Grades.Values.Average();

        public void DisplayStudent()
        {
            Console.WriteLine("Name "+this.Name);
            Console.WriteLine("Id "+id);
            Console.WriteLine("Grades");
            Console.WriteLine(this.DisplayGrades);
            Console.WriteLine($"Average garde: {this.AverageGrade:f2} ");
        }

    }
}
