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
        private double _point;
        public string Name { get; set; }


        public sbyte Age 
        {
            get 
            {
                return _age;
            }
            set
            {
                if(value >=0 && value <= 150)
                {
                    _age = value;
                }
            }
        }
        public double Point 
        {
            get 
            { 
                return _point; 
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    _point = value;
                }
            }
        }
    }
}
