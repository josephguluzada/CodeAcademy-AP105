using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionsLesson.Models
{
    internal class Teacher
    {
        private int _id;
        public byte Age;
        public string Reshad;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }
        public string Name { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Hello AB102");
        }

        private void ShowTest()
        {

        }
    }
}
