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
            // "Barking" is not eating...
            // Console.WriteLine("Dog is barking!");
            Console.WriteLine("Dog is eating!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Dog is sleeping!");
        }

        public override void Speak()
        {
            // "eating" is not speak... And the owner should had own metod.
            // Console.WriteLine("Dog is eating. " + _owner +" is happy!");
            Console.WriteLine("Dog is wof-wofing!");
        }
        
        public override void OwnersStatus()
        {
            Console.WriteLine(_owner +" is happy!");
        }
    }
}
