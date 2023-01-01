using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class IntList
    {
        public int[] numbers;

        public IntList()
        {
            numbers = Array.Empty<int>();
        }

        public void Add(int number)
        {
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[^1] = number;
        }

        public int Count()
        {
            return numbers.Length;
        }

        public int FindByIndex(int index)
        {
            if(index < numbers.Length)
            {
                return numbers[index];
            }
            return -1;
        }
    }
}
