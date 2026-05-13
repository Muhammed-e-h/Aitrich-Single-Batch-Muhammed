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

        // Using Select
        var selectResult = students.Select(s => s.Subjects);
        Console.WriteLine("Using Select:");
        foreach (var subjects in selectResult)
        {
            Console.WriteLine(string.Join(",", subjects));
        }

        // Using SelectMany
        var selectManyResult = students.SelectMany(s => s.Subjects);
        Console.WriteLine("\nUsing SelectMany:");
        Console.WriteLine(string.Join(",", selectManyResult));
        Console.ReadLine();
    }
}