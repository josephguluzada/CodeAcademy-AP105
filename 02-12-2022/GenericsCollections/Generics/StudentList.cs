using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class StudentList
    {
        public Student[] Students; // {std1,std2,std3}

        public StudentList()
        {
            Students = Array.Empty<Student>();
        }

        public void Add(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[^1] = student;
        }

        public int Count()
        {
            return Students.Length;
        }

        public Student FindByIndex(int index) // 0
        {
            if(index < Students.Length)
            {
                return Students[index];
            }
            return null;
        }
    }
}
