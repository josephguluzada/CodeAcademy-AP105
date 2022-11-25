using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class LibraryClass
    {
        public Book[] Books = new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = book;
        }

        public Book[] GetFilteredBooks(string value)
        {
            Book[] filteredBooks = new Book[0];
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre == value)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = Books[i];
                }
            }

            return filteredBooks;
        }
    }
}
