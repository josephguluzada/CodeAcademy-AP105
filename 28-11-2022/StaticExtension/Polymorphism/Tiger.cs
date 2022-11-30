using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Tiger : Cat
    {
        public string HungryLevel { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Tiger sound" + " " + HungryLevel);
        }
    }
}
