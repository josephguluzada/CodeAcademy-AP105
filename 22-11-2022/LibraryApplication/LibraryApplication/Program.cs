using LibraryApplication.Models;

namespace LibraryApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Name = "The War";
            book1.Genre = "Dram";

            Book book2 = new Book();
            book2.Name = "Aladdin";
            book2.Genre = "Adventure";

            Book book3 = new Book();
            book3.Name = "Tohmet";
            book3.Genre = "Dram";

            Library library = new Library();

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            //foreach (Book book in library.Books)
            //{
            //    Console.WriteLine(book.Name +"-"+ book.Genre);
            //}

            //Book[] filteredBooks =  library.GetFilteredBooks("Adventure");

            foreach (Book book in library.GetFilteredBooks("dram"))
            {
                Console.WriteLine(book.Name + "-" + book.Genre);
            }
        }
    }
}