using System;

namespace Exercice_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSells = 0;

            Console.WriteLine("Introduce the number of sells: ");
            int numberOfSells = Convert.ToInt32(Console.ReadLine());
           
            for(int i = 0; i < numberOfSells; i++)
            {
                Console.WriteLine("Introduce the value of the sell number {0}.", i+1);
                int valueOfSell = Convert.ToInt32(Console.ReadLine());

                totalSells += valueOfSell;
            }

            Console.WriteLine("The total value of all sells is: {0} ", totalSells);

        }
    }
}
