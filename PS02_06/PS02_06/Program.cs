using System;

namespace PS02_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            int sum = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    sum += c - '0'; 
                }
            }

            Console.WriteLine($"The sum of the digits is: {sum}");

        }
    }
}