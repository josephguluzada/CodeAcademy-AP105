using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Student
    {
        private sbyte _age;
        public string Name { get; set; }
        public sbyte Age 
        {
            get => _age;
            set
            {
                if (value > 0) _age = value;
                else throw new InvalidAgeException("Yas menfi ola bilmez!");
            }
        }
    }
}
