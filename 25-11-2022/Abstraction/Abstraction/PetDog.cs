using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class PetDog : Dog
    {
        private byte _age;
        public override byte Age { 
            get => _age;
            set
            {
                if (value > 0 && value < 5)
                {
                    _age = value;
                }
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Petdog hav hav");
        }

        public override void Eat()
        {
            Console.WriteLine("Eat like Petdog");
        }
    }
}
