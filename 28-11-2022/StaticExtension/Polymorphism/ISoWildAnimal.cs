using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal interface ISoWildAnimal
    {
        public void Test()
        {
            Console.WriteLine("Test");
        }
        public void Collapse()
        {
            Console.WriteLine("Collapse");
        }
    }
}
