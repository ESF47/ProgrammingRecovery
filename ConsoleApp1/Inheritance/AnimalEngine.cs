using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Inheritance
{
    class AnimalEngine
    {
        Ball ball = new Ball("Ball", 4, 4, ConsoleColor.Red, "Wood", 2);
        Snake snake = new Snake("snake", 16, 16, ConsoleColor.Green, "Zangi", true, 5);

        public void EngineStart()
        {
            //Ball test
            ball.ShowBaseStatus();
            ball.ChangePosition(14, 14, "Ball");
            ball.ChangeColor(ConsoleColor.Black, "Ball");
            ball.ShowBaseStatus();
            Console.WriteLine("\nPress any key in order to continue...\n");
            Console.ReadKey();

            ball.ShowSpecificStatus();
            ball.Bounce(8);
            ball.ChangeTheMaterial("Iron");
            ball.ShowSpecificStatus();
            Console.WriteLine("\nPress any key in order to continue...\n");
            Console.ReadKey(); Console.WriteLine();

            //Snake test
            snake.ShowBaseStatus();
            snake.ChangePosition(160, 160, "Snake");
            snake.ChangeColor(ConsoleColor.Blue, "Snake");
            snake.ShowBaseStatus();
            Console.WriteLine("\nPress any key in order to continue...\n");
            Console.ReadKey();

            snake.ShowSpecificStatus();
            snake.ChangeSnakeType("Shiri");
            snake.ReverseLethality();
            snake.ChangeBodyLength(25);
            snake.ShowSpecificStatus();
            Console.WriteLine("\nPress any key in order to continue...\n");
            Console.ReadKey();
        }
    }
}
