using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Dog : Animal
    {
        public bool HasCollar;

        public override byte Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat like dog");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hav Hav");
        }
    }
}
