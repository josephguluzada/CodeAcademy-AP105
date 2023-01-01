using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class Student : Person
    {
        public override string GetFullName()
        {
            return "Student Full name";
        }
    }
}
