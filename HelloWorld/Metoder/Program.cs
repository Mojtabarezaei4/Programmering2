using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfTheGivenNumbers();
            Sorting();
            Sorting();
        }

        /** A method for get some numbers in a list and add the content for return the result.
         */
        private static int SumOfTheGivenNumbers()
        {
            int sum = 0;

            var numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please write your numbers.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            Console.WriteLine("The result of the addition is " + sum);

            return sum;
        }

        /** A method for get a bounch of words (called names) in a list and make the list revers.
         */
        private static void Backward()
        {
            var names = new string[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Please write some names?");
                names[i] = Console.ReadLine();
            }
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
        }

        /**A method for find the biggest and the smallest number in a list.
         * 
         * I googled Bubblesort algorithm.
         */
        private static void Sorting()
        {
            var numbers = new int[5];
            int temp;
            int theBiggest = 0;
            int theSmallest = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j <= numbers.Length - 2; j++)
            {
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            theBiggest = numbers[4];
            theSmallest = numbers[0];

            Console.WriteLine("The biggest number is:  " + theBiggest);
            Console.WriteLine("The smallest number is: " + theSmallest);
        }
    }

    
}
