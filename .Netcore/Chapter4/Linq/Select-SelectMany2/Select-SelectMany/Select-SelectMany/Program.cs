internal class Program
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Subjects { get; set; }
    }

    public static void Main(string[] args)
    {


        List<Student> students = new List<Student>
{
    new Student { Name = "Alice", Subjects = new List<string> { "Math", "Science" } },
    new Student { Name = "Bob", Subjects = new List<string> { "History", "Geography" } }
};

        var selectresult = from s in students
                           select s;
        foreach(var student in selectresult)
        {
            Console.WriteLine(student.Name+":");
            foreach (var s in student.Subjects)
            {
                Console.Write(s+ " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("********************");
        Console.WriteLine("Subjects :Select");
        var selectManyResult3 = students.Select(s => s.Subjects);

        foreach (var subject in selectManyResult3)
        {
            foreach (var s in subject)
            {
                Console.WriteLine(s);
            }
        }

        Console.WriteLine("********************");
        Console.WriteLine("Subjects (Flattened List):SelectMany");
        var selectManyResult1 = students.SelectMany(s => s.Subjects);
        
        foreach (var subject in selectManyResult1)
        {
            Console.WriteLine(subject);
        }

        Console.WriteLine("********************");
        Console.WriteLine("Student - Subject Pairs:SelectMany");
        var selectManyResult2 = students.SelectMany(
                                s => s.Subjects,
                             (student, subject) => new { student.Name, Subject = subject });
        
        foreach (var item in selectManyResult2)
        {
            Console.WriteLine($"{item.Name} - {item.Subject}");
        }
        Console.ReadLine();

    }
}