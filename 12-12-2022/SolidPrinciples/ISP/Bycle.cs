using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Bycle : IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine("Suruldu");
        }
    }
}
