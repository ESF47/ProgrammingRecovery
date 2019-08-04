using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Inheritance
{
    class Ball : Shape
    {
        public string Material { get; set; }
        public int Bounciness { get; set; }
        private int _totalBounceTime = 0;

        public Ball(string baseShape, int baseXPos, int baseYPos, ConsoleColor baseColor, string material, int bounciness) 
            : base(baseShape, baseXPos, baseYPos, baseColor)
        {
            Material = material;
            Bounciness = bounciness;
        }

        public void ChangeTheMaterial(string newMaterial)
        {
            Material = newMaterial;
            Console.WriteLine("The ball's material has been changed to {0}", newMaterial);
        }

        public void Bounce(int bounceForce)
        {
            int currentBounce =+ Bounciness * bounceForce;
            _totalBounceTime = +currentBounce;
            Console.WriteLine("The Ball has been bounced off the ground {0} time.", currentBounce);
        }

        public void ShowSpecificStatus()
        {
            Console.WriteLine("This Ball's material is {0}. Also the ball has been bounced off the ground total of {1} times.", Material, _totalBounceTime);
        }
    }
}
