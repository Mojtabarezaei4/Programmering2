using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class Dog : Animal
    {
        // same as line 31. see line 31. 
        // string _owner;

        public Dog(string color): base(color)
        {
            
        }

        public override void Eat()
        {
            Console.WriteLine("Dog is barking!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Dog is sleeping!");
        }

        public override void Speak()
        {
            Console.WriteLine("Dog is eating. " + _owner +" is happy!");
        }
        // All the animals have the ability to get an owner so this method shodn be in class "Animal". 
        // public void TransferOwnership(string owner)
        // {
        //    _owner = owner;
        // }
    }
}
