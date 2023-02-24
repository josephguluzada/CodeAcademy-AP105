using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Models;
using Pustok.ViewModels;

namespace Pustok.Controllers
{
    public class BookController : Controller
    {
        private readonly PustokContext _pustokContext;

        public BookController(PustokContext pustokContext)
        {
            _pustokContext = pustokContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            Book book = _pustokContext.Books
                            .Include(b => b.Author)
                            .Include(b => b.Genre)
                            .Include(b => b.BookImages)
                            .FirstOrDefault(x => x.Id == id);

            if(book == null) return View("Error");

            BookDetailViewModel bookDetailVM = new BookDetailViewModel
            {
                Book = book,
                RelatedBooks = _pustokContext.Books
                                    .Include(x=>x.BookImages)
                                    .Include(x=>x.Author)
                                    .Where(x => x.GenreId == book.GenreId && x.Id != book.Id).ToList()
            };

            return View(bookDetailVM);
        }
    }
}
