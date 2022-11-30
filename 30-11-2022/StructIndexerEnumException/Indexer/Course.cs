using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Course
    {
        public string Name { get; set; }
        public Teacher[] Teachers;



        public Teacher this[int index]
        {
            get
            {
                return Teachers[index];
            }
            set
            {
                Teachers[index] = value;
            }
        }

        public Teacher this[int index, string name]
        {
            get
            {
                return Teachers[index];
            }
            set
            {
                Teachers[index] = value;
            }
        }
        public Course()
        {
            Teachers = new Teacher[10];
        }

        public void AddTeacher(Teacher teacher)
        {
            Array.Resize(ref Teachers, Teachers.Length + 1); // 10 -> 11
            Teachers[^1] = teacher; // -> 10
        }
    }
}
