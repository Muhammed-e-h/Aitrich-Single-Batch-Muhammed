using System.Security.Cryptography.X509Certificates;
using static System.Enum;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)

        {
            //Colors col = new Colors();
            Console.WriteLine(Colors.Color.Red);/*✔ It prints the Red value from the enum Color 
                                                     that belongs to the class Colors.*/
            Console.WriteLine(Colors.Color.Green);
            Console.WriteLine((int)Colors.Color.Green); /*This is type casting.
                                                        It converts the enum value to its integer value.
                                                        Enums store values as numbers internally.*/
        }

    internal class Colors
    {
        public enum Color
        {
            Red,
            Blue,
            Yellow,
            Green
        }
    }
}
