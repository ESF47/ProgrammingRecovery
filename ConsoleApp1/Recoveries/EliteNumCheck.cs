using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Recoveries
{
    class EliteNumCheck
    {
        private int getNumber()
        {
            bool isInputCorrect = false;
            int inputNumber = 0;
            while (!isInputCorrect)
            {
                Console.Clear();
                Console.WriteLine("Please enter a number which you want primes till it: ");

                isInputCorrect = int.TryParse(Console.ReadLine(), out inputNumber);
                if (!isInputCorrect)
                {
                    Console.WriteLine("The input was not a number! Press any key to try again.");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            return inputNumber;
        }

        private void primeCalculation()
        {
            int limitNumber = getNumber();
            int totalNumofPrimes = 0;
            for (int i = 2; i <= limitNumber; i++)
            {
                bool isCurrNumPrime = true;
                for (int j = 2; j < (i / 2) + 1; j++)
                {
                    if((i % j == 0))
                    {
                        isCurrNumPrime = false;
                        break;
                    }
                }
                if (isCurrNumPrime)
                {
                    Console.WriteLine("{0} is prime", i);
                    totalNumofPrimes++;
                }
            }
            Console.WriteLine("\nThere are {0} prime numbers between 2 and {1}", totalNumofPrimes, limitNumber);
            Console.ReadKey();
        }

        public void ElitePrime()
        {
            //Console Reset
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            bool isProgramOn = true;
            while (isProgramOn)
            {
                primeCalculation();
                Console.WriteLine("\nPress Enter to try again, or press Escape to exit");

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case (ConsoleKey.Enter):
                        break;

                    case (ConsoleKey.Escape):
                        isProgramOn = false;
                        break;

                    default:
                        break;
                }

            }
        }
    }
}
