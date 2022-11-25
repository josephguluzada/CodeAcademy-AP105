using Library.Models;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Book book = new Book();
            book.Name = "Rasim";
            book.Genre = "Qorxu";

            Book book2 = new Book();
            book2.Name = "Rasim Salam";
            book2.Genre = "Qorxu";

            LibraryClass library = new LibraryClass();

            library.AddBook(book);
            library.AddBook(book2);

            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name + " " + item.Genre);
            }

            var filteredBooks =library.GetFilteredBooks("Qorxu");

            foreach (var item in filteredBooks)
            {
                Console.WriteLine(item.Name + " " + item.Genre);
            }

            Console.WriteLine(library.Books.Length);

        }
    }
}