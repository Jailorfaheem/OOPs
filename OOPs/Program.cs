using System;

//1. Inheritance ==

//namespace OOPSbasic.OOPS.Encapsulation
//{
// class Program
//{
// static void Main(string[] args)
//{
//Bird2 bird = new Bird2();
//bird.sound();
//Console.WriteLine(bird.name + " " + bird.color);

//}
//}
//}


//2.  Encapsulation ==

//namespace Encapsulation
//{
//class Program
//{
//static void Main(string[] args)
//{
//Person myObj = new Person();
//myObj.Name = "AMIR";
//Console.WriteLine(myObj.Name);
//}
//}
//}


//3. Polymorphism ==

namespace Overriding
{
    class Animal
    {
        static void Main(string[] args)
        {
            myAnimal myAnimal = new myAnimal();
            myAnimal myCat = new Cat();
            myAnimal myDog = new Dog();
            myAnimal myGoat = new Goat();

            myAnimal.animalSound();
            myCat.animalSound();
            myDog.animalSound();
            myGoat.animalSound();

        }
    }
}