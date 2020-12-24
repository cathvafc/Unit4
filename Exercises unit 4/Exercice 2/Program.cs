using System;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a person name.");
            String personName = Console.ReadLine();

            Console.WriteLine("Please, enter a city name.");
            String cityName = Console.ReadLine();


            Console.WriteLine("Hola {0} bienvenido a {1}.", personName, cityName);
        }
    }
}
