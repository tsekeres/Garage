using Garage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Watercraft
{
    abstract class BoatBase : VehicleBase
    {
        public int TowingCapacity { get; set; }
        public virtual void Towing()
        {
            Console.WriteLine($"Your boat can pull {TowingCapacity} skiers.");
        }

        public override void Driving()
        {
            Console.WriteLine("Watch out for the rocks!");
        }

     }
}
