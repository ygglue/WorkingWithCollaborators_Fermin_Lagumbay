using System;

namespace PS02_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }

            Console.WriteLine("Character frequencies:");
            foreach (KeyValuePair<char, int> kvp in frequency)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }


        }
    }
}