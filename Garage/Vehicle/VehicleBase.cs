using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Vehicle
{
    abstract class VehicleBase
    {
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }

        public virtual void Refueling()
        {
            Console.WriteLine($"Your tank holds {FuelCapacity} gallons of fuel.");
        }

        public virtual void Driving()
        {
            Console.WriteLine("Let's see what ya got.");
        }

        public abstract void Braking();
    }
}
