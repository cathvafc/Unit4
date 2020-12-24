using System;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write your name:");
            string name =  Console.ReadLine();

            Console.WriteLine("Please, write your age:");
            string age = Console.ReadLine();

            Console.WriteLine("Te llamas {0} y tienes {1} años.", name, age);
        }
    }
}
