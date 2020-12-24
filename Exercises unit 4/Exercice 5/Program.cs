using System;

namespace Exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert the day of the week.");
            string weekDay = Console.ReadLine();


            //Check weekend days in english and spanish.

            if (weekDay == "Sabado" || weekDay == "Domingo" || weekDay == "Saturday" || weekDay == "Sunday" )
            {
                Console.WriteLine("{0} is a weekend day",weekDay);
            }
            else
            {
                Console.WriteLine("{0} is not a weekend day", weekDay);
            }
        }
    }
}
