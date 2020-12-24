using System;

namespace Exercice_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number please: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number {0} is divisible by 2.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is not divisible by 2.", number);
            }
        }
    }
}
