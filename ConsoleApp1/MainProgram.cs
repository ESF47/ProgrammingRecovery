using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using ProgrammingRecovery.Recoveries;
using ProgrammingRecovery.Inheritance;
using ProgrammingRecovery.Override;
using ProgrammingRecovery.Interface;

namespace ProgrammingRecovery
{
    class MainProgram
    {
        static List<string> menuTexts = new List<string>() { "\nMenu Test", //case 0
                                                             "Format Checker", //case 1
                                                             "Prime to Hundred", //case 2
                                                             "Elite Number Check", //case 3
                                                             "Animal Engine", //case 4
                                                             "Car Handler", //case 5 
                                                             "Combat System" //case 6
                                                            };

        static void programLoader(int programToLoad)
        {
            switch (programToLoad)
            {
                case (0):
                    MenuTest menuTest = new MenuTest();
                    menuTest.LoadMenu();
                    break;

                case (1):
                    FormatChecker formatChecker = new FormatChecker();
                    formatChecker.FormatCheck();
                    break;

                case (2):
                    PrimeToHundred primeToHundred = new PrimeToHundred();
                    primeToHundred.PrimToHundred();
                    break;

                case (3):
                    EliteNumCheck eliteNumCheck = new EliteNumCheck();
                    eliteNumCheck.ElitePrime();
                    break;

                case (4):
                    AnimalEngine animalEngine = new AnimalEngine();
                    animalEngine.EngineStart();
                    break;

                case (5):
                    CarHandler carHandler = new CarHandler();
                    carHandler.HandleCars();
                    break;

                case (6):
                    CombatSystem combatSystem = new CombatSystem(new Katana());
                    combatSystem.CombatEngine();
                    break;

                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            int currentButton = 0;

            while (true)
            {
                //Draws basic menu texts like buttons
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Use arrow keys in order to select buttons:");
                for (int i = 0; i < menuTexts.Count; i++)
                {
                    if (i == currentButton)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine(menuTexts[i]);
                }

                ConsoleKeyInfo userInput = Console.ReadKey();
                switch (userInput.Key)
                {
                    case (ConsoleKey.UpArrow):
                        if (currentButton == 0)
                            currentButton = 0;
                        else
                            currentButton--;
                        break;

                    case (ConsoleKey.DownArrow):
                        if (currentButton == menuTexts.Count - 1)
                            currentButton = menuTexts.Count - 1;
                        else
                            currentButton++;
                        break;

                    case (ConsoleKey.Enter):
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        programLoader(currentButton);
                        break;

                    case (ConsoleKey.Escape):
                        return;

                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
