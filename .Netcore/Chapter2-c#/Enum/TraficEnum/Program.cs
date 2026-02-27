internal class Program
{
    private static void Main(string[] args)
    {
        TrafficLight t=TrafficLight.Red;
        Console.WriteLine(t);
    }
    enum TrafficLight
    {
        Red,
        Green,
        Yellow
    }
}