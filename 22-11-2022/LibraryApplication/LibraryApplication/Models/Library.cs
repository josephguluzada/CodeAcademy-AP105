using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Models
{
    internal class Library
    {
        public Book[] Books = new Book[0];  // {book1,book2,book3} 3 -> {book1,book2,book3,book4,book5} 5


        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length-1] = book;
        }

        public Book[] GetFilteredBooks(string value)
        {
            Book[] filteredBooks = new Book[0];

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre.ToLower() == value.ToLower())
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = Books[i];
                }
            }
            return filteredBooks;
        }
    }
}
