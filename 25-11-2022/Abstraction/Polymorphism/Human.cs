using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public virtual void ShowFullData()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age}");
        }
    }
}
