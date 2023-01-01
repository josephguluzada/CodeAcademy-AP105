using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class AreaCalculator
    {
        public double AreaCalcul(Shape shape)
        {
            double area = 0;

            area = shape.Area();

            return area;
        }
    }
}
