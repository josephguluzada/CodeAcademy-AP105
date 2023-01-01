using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    interface IFuelable
    {
        double CurrentFuel { get; set; }
        double FuelCapacity { get; set; }

        void AddFuel(double fuel);
    }
}
