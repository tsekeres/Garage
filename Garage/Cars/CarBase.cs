using Garage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    abstract class CarBase : VehicleBase
    {
        public int TirePressure { get; set; }
        public bool IsCheesed { get; set; }

        public virtual void Windows()
        {
            Console.WriteLine("Roll the windows down and feel the breeze!");
        }

        public override void Driving()
        {
            Console.WriteLine("Punch it Hilda!");
        }
     }
}
