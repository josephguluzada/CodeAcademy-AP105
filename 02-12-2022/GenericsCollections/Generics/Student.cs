using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Student
    {
        private static int _counter;
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        static Student()
        {
            _counter = 0;
        }

        public Student()
        {
            _counter++;
            Id = _counter;
        }

        public override string ToString()
        {
            return $"Id: {Id} - Fullname: {Name + " " + SurName}";
        }
    }
}
