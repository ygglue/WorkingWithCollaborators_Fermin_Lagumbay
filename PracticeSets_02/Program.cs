﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i >= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is even");
                }
            }
            Console.WriteLine("hi mike");
            Console.ReadKey();

        }
    }
}
