using LibraryBookHomework.Models;

namespace LibraryBookHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Programming");
            Book book2 = new Book("Design");

            Library library = new Library("Aztu");
            library.AddBook(book1);
            library.AddBook(book2);

            library.ShowAllBooks();

            Book wantedBook = library.FindBookByBookCode("Pr1001");

            if(wantedBook != null)
            {
                Console.WriteLine(wantedBook.Name + " " + wantedBook.BookCode);
            }
            else
            {
                Console.WriteLine("Axtardiginiz kitab yoxdur!");
            }


            Book wantedBook1 = library.FindBookById(3);

            if( wantedBook1 != null)
            {
                Console.WriteLine(wantedBook1.Name + " " + wantedBook1.Id);
            }
            else
            {
                Console.WriteLine("Axtardiginiz kitab yoxdur!");
            }


        }
    }
}