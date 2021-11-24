using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class myAnimal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Dog : myAnimal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dog says : Bow Bow");
        }
    }
    class Cat : myAnimal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Cat says : Meow Meow");
        }
    }
    class Goat : myAnimal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Goat says : Maa Maa");
        }
    }
}