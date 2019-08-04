using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Inheritance
{
    class Shape
    {
        public string BaseShape { set; get; }
        public int BaseXPosition { get; set; }
        public int BaseYPosition { get; set; }
        public ConsoleColor DefaultColor { get; set; }

        public Shape(string baseShape, int baseXPos, int baseYPos, ConsoleColor baseColor)
        {
            BaseShape = baseShape;
            BaseXPosition = baseXPos;
            BaseYPosition = baseYPos;
            DefaultColor = baseColor;
        }

        public void ChangePosition(int xPos, int yPos, string shapeName)
        {
            BaseXPosition = xPos;
            BaseYPosition = yPos;
            Console.WriteLine("The {0} position has beed changed", shapeName);
        }

        public void ChangeColor(ConsoleColor desiredColor, string shapeName)
        {
            DefaultColor = desiredColor;
            Console.WriteLine("The {0} color has beed changed", shapeName);
        }

        public void ShowBaseStatus()
        {
            Console.WriteLine("The base shape is {0}. The Current Position is ({1}, {2}) and the current color is {3}", BaseShape, BaseXPosition, BaseYPosition, DefaultColor);
        }
    }
}
