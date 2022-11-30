using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cat
    {
        public string Name { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("Cat sound");
        }
    }
}
