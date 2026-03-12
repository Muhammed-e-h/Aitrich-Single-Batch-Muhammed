using Abstractsample1;

internal class Program
{
    private static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.AnimalSound();
        cat.Eat();
        Dog dog = new Dog();
        dog.AnimalSound();
        dog.Eat();
    }
}