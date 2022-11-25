using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookHomework.Models
{
    internal class Library
    {
        private static int _counter;

        public int Id { get; set; }
        public string Name { get; set; }
        public Book[] Books = new Book[0]; //{book1,book2} 2 -> {book1,book2,book3} 3
        //public Book[] Books = Array.Empty<Book>();

        public Library(string name)
        {
            _counter++;
            this.Id = _counter;
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            //Books[^1] = book;
            Books[Books.Length-1] = book;
        }

        public void ShowAllBooks()
        {
            if(Books.Length > 0)
            {
                foreach (Book book in this.Books)
                {
                    Console.WriteLine($"{book.Id} - {book.BookCode} - {book.Name} ");
                }
            }
            else
            {
                Console.WriteLine("There is not any book in the library");
            }
        }


        public Book FindBookById(int id)
        {
            foreach (Book book in this.Books)
            {
                if(book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }

        public Book FindBookByBookCode(string bookCode)
        {
            foreach (Book book in this.Books)
            {
                if (book.BookCode.ToLower() == bookCode.ToLower())
                {
                    return book;
                }
            }
            return null;
        }


    }
}
