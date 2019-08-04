using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Inheritance
{
    class Snake : Shape
    {
        public string SnakeType { get; set; }
        public bool IsLethal { get; set; }
        public int BodyLength { get; set; }

        public Snake(string baseShape, int baseXPos, int baseYPos, ConsoleColor baseColor, string snakeType, bool isLethal, int bodyLength) 
            : base(baseShape, baseXPos, baseYPos, baseColor)
        {
            SnakeType = snakeType;
            IsLethal = isLethal;
            BodyLength = bodyLength;
        }

        public void ChangeSnakeType(string type)
        {
            SnakeType = type;
            Console.WriteLine("The snake type has been changed");
        }

        public void ReverseLethality()
        {
            IsLethal = !IsLethal;
        }

        public void ChangeBodyLength(int length)
        {
            BodyLength = length;
            Console.WriteLine("The body length has been changed");
        }

        public void ShowSpecificStatus()
        {
            Console.WriteLine("This is a {0} snake. This is a {1} snake and its body length is {2} cm", SnakeType, (IsLethal ? "Lethal" : "Non-Lethal"), BodyLength);
        }
    }
}
