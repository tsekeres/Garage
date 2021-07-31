using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Cars
{
    class Delorian : CarBase
    {
        public override void Braking()
        {
            Console.WriteLine("No braking! 77 MPH!");
        }

        public override void Driving()
        {
            Console.WriteLine("Roads? Where we're going we don't need roads.");
        }
    }
}
