using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookHomework.Models
{
    internal class Book
    {
        private static int _counter = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string BookCode { get; set; }


        public Book(string name)
        {
            _counter++; // 1 -> 2

            this.Name = name;
            this.Id = _counter;

            this.BookCode = this.Name.Substring(0,2).ToUpper() + (1000+ this.Id).ToString();
        }
    }
}
