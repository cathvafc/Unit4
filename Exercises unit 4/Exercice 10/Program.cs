﻿using System;

namespace Exercice_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine("The value of i is: {0}", i);

                }
            }
        }
    }
}
