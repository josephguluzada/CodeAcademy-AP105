using Exception.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Person
    {
        private string _name;
        public string Name 
        { 
            get => _name;
            set
            {
                if(value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    throw new InvalidNameLengthException("Adin uzunlugu minimum 3 olmalidir");
                }
            }
        }
        public string Surname { get; set; }
        public byte Age { get; set; }
    }
}
