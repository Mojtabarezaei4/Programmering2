using System;

namespace ForstaUppgiften
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi, what's your name?");
            String name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            String age = Console.ReadLine();

            Console.WriteLine("What's Your address?");
            String address = Console.ReadLine();

            Console.WriteLine("What's your post address?");
            String postAddress = Console.ReadLine();

            Console.WriteLine("Which city are you living in?");
            String city = Console.ReadLine();

            Console.WriteLine("Please write your telephone number.");
            String telephoneNumber = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Information: " + "\n" + "\n" + "Your name: " + "\t" + name
                                + "\n" + "Your age: " + "\t" + age
                                + "\n" + "Your address: " + "\t" + address
                                + "\n" + "Your post address: " + "\t" + postAddress
                                + "\n" + "Your city: " + "\t" + city
                                + "\n" + "Your telephonenumber: " + "\t" + telephoneNumber
            );
        }
    }
}
