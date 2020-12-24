using System;

namespace Exercice_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce a week day.");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("{0} is a laboral day.", day);
                    break;
                case "Lunes":
                    Console.WriteLine("{0} es un día laborable.", day);
                    break;
                case "Tuesday":
                    Console.WriteLine("{0} is a laboral day.", day);
                    break;
                case "Martes":
                    Console.WriteLine("{0} es un día laborable.", day);
                    break;
                case "Wednesday":
                    Console.WriteLine("{0} is a laboral day.", day);
                    break;
                case "Miercoles":
                    Console.WriteLine("{0} es un día laborable.", day);
                    break;
                case "Thursday":
                    Console.WriteLine("{0} is a laboral day.", day);
                    break;
                case "Jueves":
                    Console.WriteLine("{0} es un día laborable.", day);
                    break;
                case "Friday":
                    Console.WriteLine("{0} is a laboral day.", day);
                    break;
                case "Viernes":
                    Console.WriteLine("{0} es un día laborable.", day);
                    break;
                case "Saturday":
                    Console.WriteLine("{0} is not a laboral day.", day);
                    break;
                case "Sabado":
                    Console.WriteLine("{0} no es un día laborable.", day);
                    break;
                case "Sunday":
                    Console.WriteLine("{0} is not a laboral day.", day);
                    break;
                case "Domingo":
                    Console.WriteLine("{0} no es un día laborable.", day);
                    break;
                default:
                    Console.WriteLine("The day introduced is incorrect");
                    break;
                }
        }
    }
}
