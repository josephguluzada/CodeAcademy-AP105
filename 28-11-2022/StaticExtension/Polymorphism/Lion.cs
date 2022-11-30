using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Lion : Cat, IWildAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Lion sound");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
