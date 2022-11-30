using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Teacher
    {
        public string Fullname { get; set; }
        public string Position { get; set; }
        public byte Age { get; set; }

        public override string ToString()
        {
            return $"Fullname: {Fullname} Age: {Age}";
        }
    }
}
