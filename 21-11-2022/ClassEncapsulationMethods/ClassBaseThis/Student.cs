using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBaseThis
{
    internal class Student : Human
    {
        public double Point;
        public double Grant;


        public Student(string name, string surname, byte age, double point) : base(name, surname, age)
        {
            this.Point = point;
        }

        public Student(string name, string surname, byte age, double point,double grant) : this(name, surname, age, point)
        {
            this.Grant = grant;
        }
    }
}
