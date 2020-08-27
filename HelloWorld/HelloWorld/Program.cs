using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what's your name?");
            String name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            String age = Console.ReadLine();

            Console.WriteLine("Are you alive? (Choose a number)" + "\n" + "1. Yes" + "\n" + "2. No");
            int aliveInt = Convert.ToInt32(Console.ReadLine());

            bool alive = true;

            if (aliveInt == 1)
            {
                alive = true;

            }
            else
            {
                alive = false;
            }

            Console.WriteLine("Are you good at math?" + "\n" + " 2 + 2 = ?");
            int answer = Convert.ToInt32(Console.ReadLine());


            var num1 = 2;
            var num2 = 2;
            var sum = num1 + num2;


            

            Console.WriteLine("");

            Console.WriteLine("Information: " + "\n" + "\n" + "Your name: " + "\t" + name
                                + "\n" + "Your age: " + "\t" + age
                                + "\n" + "You are alive: " + "\t" + alive
                                + "\n" + "You are not: " + "\t" +  "2 + 2 = " + sum
            );
        }
    }
}
