using System;

namespace PS02_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string processedInput = input.Replace(" ", "").ToLower();
 
            char[] charArray = processedInput.ToCharArray();
            Array.Reverse(charArray);
            string reversedInput = new string(charArray);

            if (processedInput == reversedInput)
            {
                Console.WriteLine($"'{input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{input}' is not a palindrome.");
            }

        }
    }
}