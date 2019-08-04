using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Recoveries
{
    class FormatChecker
    {
        // This application takes an input and tells you if the input is a number or not
        public void FormatCheck()
        {
            bool input = false;
            while (input == false)
            {
                //Console Reset
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Please give an input: ");
                string numberInput = Console.ReadLine();
                if (int.TryParse(numberInput, out int numberToOut))
                    Console.WriteLine("\nThe input was a number!");
                else
                    Console.WriteLine("\nThe Input was not a number!");

                Console.WriteLine("\nPress Escape to exit the application, or press Enter to continue...");
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.Escape)
                    input = true;
                else
                    continue;
            }
        }
    }
}
