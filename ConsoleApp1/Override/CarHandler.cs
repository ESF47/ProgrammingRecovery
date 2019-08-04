using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingRecovery.Override
{
    class CarHandler
    {
        List<Car> cars = new List<Car>() { new Benz("Benz", 300, 150, 8),
                                           new BMW("BMW", 280, 180, 6),
                                           new Auodi("Auodi", 350, 200, 8)};

        public void HandleCars()
        {
            foreach (Car car in cars)
            {
                car.EngineStart();
                car.ReachTopSpeed();
                car.Refuel();
                car.EngineShutDown();
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
