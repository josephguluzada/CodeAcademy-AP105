using Microsoft.AspNetCore.Mvc;
using Pustok.Models;
using Pustok.ViewModels;
using System.Xml.Linq;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BookController : Controller
    {
        private readonly PustokContext _pustokContext;

        public BookController(PustokContext pustokContext)
        {
            _pustokContext = pustokContext;
        }

        public IActionResult Index()
        {
            return View(_pustokContext.Books.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Authors = _pustokContext.Authors.ToList();
            ViewBag.Genres = _pustokContext.Genres.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookCreateViewModel bookVM)
        {
            ViewBag.Authors = _pustokContext.Authors.ToList();
            ViewBag.Genres = _pustokContext.Genres.ToList();
            if (!ModelState.IsValid) return View();

            Book book = new Book
            {
                Name = bookVM.Name,
                CostPrice = bookVM.CostPrice,
                SalePrice = bookVM.SalePrice,
                AuthorId = bookVM.AuthorId,
                GenreId = bookVM.GenreId,
                DiscountPrice = bookVM.DiscountPrice,
                Code = bookVM.Code,
                Desc = bookVM.Desc,
                IsAvailable = bookVM.IsAvailable
            };

            _pustokContext.Books.Add(book);
            _pustokContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Update(int id)
        {
            ViewBag.Authors = _pustokContext.Authors.ToList();
            ViewBag.Genres = _pustokContext.Genres.ToList();

            Book book = _pustokContext.Books.Find(id);
            if (book == null) return View("Error");


            return View(book);
        }

        [HttpPost]
        public IActionResult Update(Book book)
        {
            ViewBag.Authors = _pustokContext.Authors.ToList();
            ViewBag.Genres = _pustokContext.Genres.ToList();

            Book existBook = _pustokContext.Books.FirstOrDefault(x => x.Id == book.Id);
            if (book == null) return View("Error");

            if (!ModelState.IsValid) return View();


            existBook.Name = book.Name;
            existBook.CostPrice = book.CostPrice;
            existBook.SalePrice = book.SalePrice;
            existBook.AuthorId = book.AuthorId;
            existBook.GenreId = book.GenreId;
            existBook.DiscountPrice = book.DiscountPrice;
            existBook.Code = book.Code;
            existBook.Desc = book.Desc;
            existBook.IsAvailable = book.IsAvailable;

            _pustokContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
