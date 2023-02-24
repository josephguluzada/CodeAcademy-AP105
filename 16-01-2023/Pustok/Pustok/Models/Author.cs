namespace Pustok.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Fullname { get; set; }

        public List<Book> Books { get; set; }
    }
}
