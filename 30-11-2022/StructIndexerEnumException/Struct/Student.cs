using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal struct Student : IPerson
    {
        public string Name;
        public byte Age;

        public Student(string name,byte age)
        {
            Name = name;
            Age = age;
        }

        public string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    internal interface IPerson
    {
        public string Surname { get; set; }
    }
}
