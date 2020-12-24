using System;

namespace Exercice_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 0;
            int maxTries = 3;
            bool solved = false;
            
            Console.WriteLine("Introduce the password that has to be solve: ");
            string passwordToSolve = Console.ReadLine();

            while(tries < maxTries && !solved)
            {
                Console.WriteLine("Introduce the password to solve: Try number {0} of {1}", tries+1, maxTries);
                string passwordEntered = Console.ReadLine();

                if(passwordEntered == passwordToSolve)
                {
                    Console.WriteLine("Enhorabuena! Has acertado la contraseña.");
                    solved = true;
                }
                else
                {
                    tries++;
                }
            }
            
            if (!solved)
            {
                Console.WriteLine("You do not have more tries. Sorry.");
            }

        }
    }
}
