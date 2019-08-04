using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Override
{
    abstract class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int EngineCapacity { get; set; }
        public int CylinderNum { get; set; }

        public Car(string name, int maxSpeed, int engineCapacity, int cylinderNum)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            EngineCapacity = engineCapacity;
            CylinderNum = cylinderNum;
        }

        public abstract void EngineStart();

        public abstract void ReachTopSpeed();

        public abstract void Refuel();

        public abstract void EngineShutDown();
    }
}
