using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class Hedgehog : Animal
    {
        public Hedgehog(string color): base(color)
        {
            
        }

        public override void Eat()
        {
            // "squeeking" isnot eatin!
            // Console.WriteLine("Hedgehog is squeeking!");
            Console.WriteLine("Hedgehog is omnomnoming!");
        }

        public override void OwnersStatus()
        {
        }

        public override void Sleep()
        {
            Console.WriteLine("Hedgehog is napping!");
        }

        public override void Speak()
        {
            // "omnomnoming" isnot speak
            // Console.WriteLine("Hedgehog is omnomnoming!");
            Console.WriteLine("Hedgehog is squeeking!");
        }
    }
}
