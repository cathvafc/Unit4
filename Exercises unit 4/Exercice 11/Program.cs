using System;

namespace Exercice_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 0;
            int secondValue = 0;
            int testCase = 0;

            while (testCase <3)
            {
                //Initialize variables for each test case 
                if (testCase == 0)
                {
                    firstValue = 1;
                    secondValue = 3;
                    testCase++;
                }
                else if (testCase == 1)
                {
                    firstValue = 2;
                    secondValue = 2;
                    testCase++;
                }
                else if (testCase == 2)
                {
                    firstValue = 3;
                    secondValue = 1;
                    testCase++;
                }
              

                if (firstValue > secondValue)
                {
                    Console.WriteLine("The first value {0} is bigger than the second value {1}", firstValue, secondValue);
                }
                else if (firstValue == secondValue)
                {
                    Console.WriteLine("The first value {0} is equal to the second value {1}", firstValue, secondValue);
                }
                else
                {
                    Console.WriteLine("The first value {0} is lower than the second value {1}", firstValue, secondValue);
                }

            }



        }
    }
}
