using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTask
{
    internal class Student
    {
        private int _counter;
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }


        public void ShowInfo()
        {
            Console.WriteLine($"Id : {Id} Fullname: {Name} {SurName}");
        }
    }
}
