using Garage.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Aircraft
{
    abstract class PlaneBase : VehicleBase
    {
        public int NumberOfEngines { get; set; }

        public virtual void Flying()
        {
            Console.WriteLine("Pull up! Pull up!");
        }

        public abstract void Landing();
    }
}
