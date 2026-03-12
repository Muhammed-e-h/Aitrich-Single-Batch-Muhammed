using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractsample1
{
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void Eat()
        {
            Console.WriteLine("Animal is Eating.............!");
        }

    }
    internal class Dog:Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Bow....Wow...!");
        }
    }
    internal class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Moew......Meow......!");
        }
    }
}
