using System;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0; //Initial state
            int price = 123;

            while (option != 1 && option != 2)
            {

                Console.WriteLine("Please, you have to pay {0} euros. Do you want to pay with cash or credit card?", price);
                Console.WriteLine("Write 1 for Cash.");
                Console.WriteLine("Write 2 for Credit Card.");

                 option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("You have choosed Cash. Please, insert the quantity.");
                    int cashReceived = Convert.ToInt32(Console.ReadLine());

            
                    float change = cashReceived - price;

                    while (change < 0)
                    {
                        Console.WriteLine("You have to insert more money please.");
                        int extraCashReceived = Convert.ToInt32(Console.ReadLine());
                        cashReceived += extraCashReceived;
                        change = cashReceived - price;
                    }

                    Console.WriteLine("Your change is: {0}", change);

                }
                else if (option == 2)
                {
                    Console.WriteLine("You have choosed Credit card. Please, insert the credit card number.");
                    int creditCardNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Your credit number is: {0}", creditCardNumber);
                }
                else
                {
                    Console.WriteLine("The options is wrong. Try again. \n\n");
                }
            }
        }
    }
}
