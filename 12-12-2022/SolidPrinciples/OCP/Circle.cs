using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}
