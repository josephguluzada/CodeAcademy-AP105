using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Human
    {
        public string Name;
        public string Surname;
        public int Age;

        public void ShowFullData()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age}");
        }

        public string GetFullname()
        {
            return this.Name + " " + this.Surname;
        }

    }
}
