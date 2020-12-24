using System;

namespace Exercice_16
{
    class Program
    {
        static void Main(string[] args)
        {
            const double ivaPercentage = 0.21;

            Console.WriteLine("Introduce the price of the product: ");
            double priceWIthoutIva = Convert.ToDouble(Console.ReadLine());

            double iva = ivaPercentage * priceWIthoutIva;

            double priceWithIva = priceWIthoutIva + iva;

            Console.WriteLine("Your product price with IVA is: {0}", priceWithIva);
        }
    }
}
