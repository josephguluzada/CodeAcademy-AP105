using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyList<T>
    {
        public T[] values = new T[0];

        public void Add(T value)
        {
            Array.Resize(ref values, values.Length + 1);
            values[values.Length - 1] = value;
        }

        public int Count()
        {
            return values.Length;
        }

        public T FindByIndex(int index)
        {
            return values[index];
        }
    }
}
