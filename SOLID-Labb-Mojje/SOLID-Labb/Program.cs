using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};

            Console.WriteLine("###############");
            Console.WriteLine();

            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                // defining who is the owner of dog
                dog._owner= "Niklas";
                }

                animal.Eat();
                animal.Sleep();
                animal.Speak();
                // for see owner's status
                animal.OwnersStatus();
                animal._color = "Grey";
                Console.WriteLine(animal.GetType().Name + " is " + animal._color);
                Console.WriteLine();

                Console.WriteLine("###############");
                Console.WriteLine();
            }
        }
    }
}
