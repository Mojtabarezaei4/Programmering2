using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int theResult = SumOfTheGivenNumbers();
            Console.WriteLine("The result of the addition is " + theResult);

            string[] givenNames = Backward();
            DisplayArray(givenNames);

            var (theBiggest, theSmallest) = Sorting();
            Console.WriteLine("The biggest number is " + theBiggest);
            Console.WriteLine("The smallest number is " + theSmallest);
        }

        /** A method for show the content of an array.
         */
        private static void DisplayArray(string[] givenNames)
        {
            foreach (var theNames in givenNames)
            {
                Console.WriteLine(theNames);
            }
        }

        /** A method for get some numbers in a list and add the content for return the result.
         */
        private static int SumOfTheGivenNumbers()
        {
            int sum = 0;

            var numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please write your number.");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            return sum;
        }

        /** A method for get a bounch of words (called names) in a list and make the list revers.
         */
        private static string[] Backward()
        {
            string[] names = new string[5];
            string[] reversedNames = new string[5];

            for (int counter = 0; counter < names.Length; counter++)
            {
                Console.WriteLine("Please write some name.");
                names[counter] = Console.ReadLine();
            }

            int i = 4;
            for (int j = 0; j <= reversedNames.Length && i >= 0; j++)
            {
                    reversedNames [j] = names[i];
                    i--;
            }
                
            return reversedNames;
        }

        /**A method for find the biggest and the smallest number in a list.
         * 
         * I googled Bubblesort algorithm.
         */
        private static (int theBiggest, int theSmallest) Sorting()
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

            return (theBiggest, theSmallest);
        }
    }

}
