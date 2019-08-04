using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Override
{
    class Auodi : Car
    {
        public Auodi(string name, int maxSpeed, int engineCapacity, int cylinderNum) 
            : base(name, maxSpeed, engineCapacity, cylinderNum)
        {

        }

        public override void EngineStart()
        {
            Console.WriteLine("\n{0} engine has been started. {1} cylinders are working now.", Name, CylinderNum);
        }

        public override void ReachTopSpeed()
        {
            Console.WriteLine("The{0} has reached to {1} which is its max speed.", Name, MaxSpeed);
        }

        public override void Refuel()
        {
            Console.WriteLine("{0} gas container has been refueled with {1} gas units.", Name, EngineCapacity);
        }

        public override void EngineShutDown()
        {
            Console.WriteLine("{0} engine has been shut down.", Name);
        }
    }
}
