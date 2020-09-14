using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] addNumbers = { 5, 7, 10, 2, 8 };

            Console.WriteLine(Add(addNumbers));
        }

        static int Add(int[] addNumbers)
        {
            int total = 1;
            for (int i = 4; i >= 0; i--)
            {
                total = total + addNumbers[i];
            }

            return total;
        }
    }
}
