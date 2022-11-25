using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomLibrary
{
    public class CustomMath
    {
        internal int Sum(int a, int b)
        {
            return a + b;
        }

        public void ShowSum(int a, int b)
        {
            Console.WriteLine(Sum(a,b)); 
        }
    }
}
