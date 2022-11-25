using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Student : Human
    {
        public Student()
        {
            Console.WriteLine("Student created");
        }

        public Student(string name) : this()
        {
            this.Name = name;
        }

        public Student(string name, string surname) : this(name)
        {
            this.Surname = surname;
        }

        public Student(string name, string surname, int age) : this(name, surname)
        {
            this.Age = age;
        }

        public Student(string name, string surname, int age, double point) : this(name, surname, age)
        {
            this.Point = point;
        }

        public void ShowFullData()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age}");
        }

        public double Point;
    }
}
