using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReflectionTask
{
    internal class Teacher
    {
        private string _name;

        private void ShowInfo()
        {
            Console.WriteLine($"Name: {_name}");
        }
    }
}
