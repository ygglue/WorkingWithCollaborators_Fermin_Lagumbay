using System;

namespace PS02_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a character:");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            char lowerChar = char.ToLower(input);

            if (char.IsLetter(lowerChar))
            {
                if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
                {
                    Console.WriteLine($"{input} is a vowel.");
                }
                else
                {
                    Console.WriteLine($"{input} is a consonant.");
                }
            }
            else
            {
                Console.WriteLine($"{input} is not a letter.");
            }

        }
    }
}