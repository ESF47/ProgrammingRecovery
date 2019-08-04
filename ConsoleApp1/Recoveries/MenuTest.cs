using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Recoveries
{
    class MenuTest
    {
        public void LoadMenu()
        {
            //Console Reset
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            
            // Button texts
            List<string> menuTexts = new List<string> { "Button 1",
                                                        "Button 2",
                                                        "Button 3",
                                                        "Button 4"};

            int currentButton = 0;
            while (true)
            {
                // Show button texts
                for (int i = 0; i < menuTexts.Count; i++)
                {
                    if (currentButton == i)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine(menuTexts[i]);
                }

                // Changing current button position
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo != null)
                {
                    switch (keyInfo.Key)
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
}
