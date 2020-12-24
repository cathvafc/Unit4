using System;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert the first number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
        
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The first number is bigger thant the second one.");
            }
            else
            {
                Console.WriteLine("The second number is bigger thant the first one.");
            }
        }
    }
}
