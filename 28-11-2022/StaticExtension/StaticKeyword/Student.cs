using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    internal class Student
    {
        public int Id { get; set; }
        private static int _counter;

        static Student()
        {
            _counter = 0;
        }

        public Student()
        {
            _counter++; //1 -> 2
            Id = _counter; 
        }

        public static bool CheckPassword(string password)
        {
            if(!string.IsNullOrWhiteSpace(password) && char.IsUpper(password[0]))
            {
                return true;
            }
            return false;
        }

        //public static bool CheckPassword(string password,int num)
        //{
        //    if (!string.IsNullOrWhiteSpace(password) && char.IsUpper(password[0]))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
