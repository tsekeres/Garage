using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Cars
{
    class Frontier : CarBase
    {
        public int EngineSize { get; set; }
        public override void Braking()
        {
            Console.WriteLine("Whoa Nelly!");
        }

        public override void Driving()
        {
            Console.WriteLine("Goin' muddin'.");
        }

        public void Power()
        {
            Console.WriteLine($"Your engine is a {EngineSize} cylinder engine.");
        }
    }
}
