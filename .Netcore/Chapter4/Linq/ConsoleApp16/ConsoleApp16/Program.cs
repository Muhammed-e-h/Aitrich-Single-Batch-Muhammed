internal class Program
{

    
    private static void Main(string[] args)

    {
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

        // Convert each name into an array of characters
        var result = names.Select(name => name.ToCharArray());

        foreach (var charArray in result)
        {
            Console.WriteLine(string.Join(",", charArray));
        }

        List<string> names1 = new List<string> { "Alice", "Bob", "Charlie" };

        // Flatten all characters into a single sequence
        //SelectMany flattens the char[] collections into a single sequence.


        var result1 = names1.SelectMany(name => name.ToCharArray());

        Console.WriteLine(string.Join(",", result1));

    }
}