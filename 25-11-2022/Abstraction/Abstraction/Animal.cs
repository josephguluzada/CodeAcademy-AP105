using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Animal
    {
        public string Name;
        public abstract byte Age { get; set; }

        public abstract void MakeSound();
        public abstract void Eat();
    }
}
