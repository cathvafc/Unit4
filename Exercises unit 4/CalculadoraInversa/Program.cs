using System;

namespace CalculadoraInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            bool working = true;
            int result = 0;

            Console.WriteLine("Introduce the first int value: ");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce the second int value: ");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            while(working)
            {
          
                Console.WriteLine("Introduce the operand +, -, *, /, ^ or %: ");
                string operand = Console.ReadLine();        
        
                switch(operand)
                {
                        case "+":
                            result = firstValue + secondValue;
                            Console.WriteLine("The result of {0} {1} {2} is: {3}", firstValue, operand, secondValue, result);                    
                            break;
                        case "-":
                        result = firstValue - secondValue;
                        Console.WriteLine("The result of {0} {1} {2} is: {3}", firstValue, operand, secondValue, result);
                            break;
                        case "*":
                        result = firstValue * secondValue;
                        Console.WriteLine("The result of {0} {1} {2} is: {3}", firstValue, operand, secondValue, result);
                            break;
                        case "/":
                        result = firstValue / secondValue;
                        Console.WriteLine("The result of {0} {1} {2} is: {3}", firstValue, operand, secondValue, result);
                            break;
                        case "^":
                        result = (int)Math.Pow(firstValue, secondValue); 
                        Console.WriteLine("The result of {0} {1} {2} is: {3}", firstValue, operand, secondValue, result);
                            break;
                        case "%":
                        result = firstValue % secondValue;
                        Console.WriteLine("The result of {0} {1} {2} is: {3}", firstValue, operand, secondValue, result);
                            break;
                        default:
                            Console.WriteLine("The operand {0} is incorrect. Try it again.", operand);
                            break;
                }

                Console.WriteLine("Do you want to do any other operation? Write Yes/No");
                string continueOperand = Console.ReadLine();

                if (continueOperand == "No")
                {
                    working = false;
                }
                else if(continueOperand == "Yes")
                {
                    //Let working on true 
                    working = true;
                }
                else
                {
                    working = false;
                }

            }
        }
    }
}
