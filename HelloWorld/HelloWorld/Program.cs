using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var informations = new string[5];

            var ages = new string[5];

            var liveStatus = new string[5];

            for (int i = 0; i < informations.Length; i++)
            {
                Console.WriteLine("Hi, what's your name?");
                informations[i] = Console.ReadLine();
            
                Console.WriteLine("How old are you?");
                ages[i] = Console.ReadLine();
           
                Console.WriteLine("Are you alive?");
                liveStatus[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(informations[i] + " is " + ages[i] + " old and he is alive? " + liveStatus[i]);
            }

        }
    }
}
