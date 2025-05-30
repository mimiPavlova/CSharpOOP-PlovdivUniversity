namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ivo", "1234879");
            Class c1=new Class("Matematika");
            Class c2 = new Class("Class2");
            student.AddClassGrade( c1, 4);
            student.AddClassGrade(c2, 2);
            Console.WriteLine(student.AverageGrade());
            student.DisplayStudent();
        }
    }
}
