using OnlineCourseSystem;

Platform platform = new Platform("New Platform");
Course math = new Course("Math");
math.EnrollStudent(new Student("Pepi"));
math.EnrollStudent(new Student("Goshco"));
math.EnrollStudent(new Student("Jivko"));

Console.WriteLine("-----Math enrolled students-----");
Console.WriteLine(  string.Join("\n", math.ListEnrolledStudents()));
Console.WriteLine("-----------------------------------------------");
platform.AddCourse(math);

Course english = new Course("English");
english.EnrollStudent(new Student("Gencho"));
english.EnrollStudent(new Student("Andi"));
english.EnrollStudent(new Student("Ivi"));

Console.WriteLine("----English enrolled students----");
Console.WriteLine(string.Join("\n", english.ListEnrolledStudents()));
Console.WriteLine("--------------------------------------------------");
platform.AddCourse(english);
Console.WriteLine("-----------Platform Info-----------------");
platform.PrintAllCoursesAndStudents();
