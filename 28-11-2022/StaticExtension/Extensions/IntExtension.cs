using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal static class IntExtension
    {
        public static bool IsEven(this int number)
        {
            if (number % 2 == 0) return true;
            else return false;
        }

        public static int Add(this int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
