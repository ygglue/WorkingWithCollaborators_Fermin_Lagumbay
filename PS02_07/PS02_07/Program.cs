using System;

namespace PS02_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();

            string[] numberStrings = input.Split(' ');

            int sum = 0;

            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString, out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine($"'{numberString}' is not a valid number.");
                }
            }

            Console.WriteLine($"The sum of the numbers is: {sum}");
        }
    }
}