using System;

namespace Exercice_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application calculates the area of a circle. \n \n Please, introduce the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double result = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The area is equal to: {0}", result);
        }
    }
}
