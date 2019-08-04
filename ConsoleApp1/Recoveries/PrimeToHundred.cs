using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Recoveries
{
    class PrimeToHundred
    {
        public void PrimToHundred()
        {
            //Console Reset
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            List<int> nonPrimeNums = new List<int>();

            for(int i = 2; i < 100; i++)
            {
                for(int j = 2; 2 < (i / j); j++)
                {
                    if (i % j == 0) // This way I find if the number (i) is non-prime
                    {
                        nonPrimeNums.Add(i);
                        break;
                    }
                }
            }

            for (int x = 2; x < 100; x++)
            {
                if (nonPrimeNums.Contains(x) == false)
                    Console.WriteLine("{0} is prime!", x);
            }
            Console.ReadKey();
        }
    }
}
