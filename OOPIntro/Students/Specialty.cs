using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students;

public class Specialty
{
    public string Name {  get; protected set; }
    public int CourseYear {  get; protected set; }

    public List<Class> CommonSubjects = new();
    public List<Student> Students=new();

    public void AddStudent(string name, string fn, Class[] clases)
    {
        Student current = new Student(name, fn);
        for (int i = 0; i < clases.Length; i++)
        {
           
        }
        Students.Add(current);
    }
    public void PrintInfo()
    {
        Console.WriteLine("Speciality subjects:");
        Console.WriteLine(string.Join("\n->", CommonSubjects));
        Console.WriteLine("Students:");
        Console.WriteLine(string.Join("\n->", Students);
    }


}
