using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Triangle : Shape
    {
        public double Height { get; set; }
        public double Side { get; set; }

        public override double Area()
        {
            return (Height * Side) / 2;
        }
    }
}
