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
        public string Id { get; }

        Dictionary<Class, double> Grades;
        public Student(string name, string id)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name cannot be null");
            Name=name;
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException("id cannot be null");
            this.Id=id;
            this.Grades=new Dictionary<Class, double>();
        }


        public void AddClassGrade(Class c, double grade)
        {
            if (Grades.ContainsKey(c)) throw new ArgumentException("class alredy exists");
            else if (grade<2||grade>6) throw new ArgumentOutOfRangeException("invalid grade");
            else Grades[c]=grade;
        }

        public int GetNumberOfClasses => Grades.Any() ? this.Grades.Count : 0;


        public string DisplayGrades()
        {
            if (!Grades.Any()) throw new ArgumentNullException("this student don't have grades, yet");
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var (c, grade) in Grades)
            {
                stringBuilder.AppendLine($"{c.Name} -> {grade}");
            }
            return stringBuilder.ToString().Trim();

        }
        public double GetGrade(Class c)
        {
            if (c is null) throw new ArgumentNullException("class is null");
            return Grades[c];
        }

        public double AverageGrade() => Grades.Any() ? Grades.Values.Average() : 0;

        public void DisplayStudent()
        {
            Console.WriteLine("Name "+this.Name);
            Console.WriteLine("Id "+Id);
            Console.WriteLine("Grades");
            Console.WriteLine(this.DisplayGrades());
            Console.WriteLine($"Average garde: {this.AverageGrade():f2} ");
        }

    }
}
