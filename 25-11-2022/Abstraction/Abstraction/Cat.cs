using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Cat : Animal
    {
        private byte _age;
        public override byte Age 
        {
            get => _age;
            set
            {
                if(value>0 && value < 11)
                {
                    _age = value;
                }
            } 
        }

        public override void Eat()
        {
            Console.WriteLine("Eat like cat");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miyav Miyav");
        }
    }
}
