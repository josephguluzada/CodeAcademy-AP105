using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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

        public IActionResult AddToBasket(int bookId)
        {
            if (!_pustokContext.Books.Any(x => x.Id == bookId)) return NotFound(); // 404

            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            BasketItemViewModel basketItem = null;
            string basketItemStr = HttpContext.Request.Cookies["Basket"];

            if(basketItemStr != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemStr);

                basketItem = basketItems.FirstOrDefault(x=>x.BookId == bookId);

                if (basketItem != null) basketItem.Count++;
                else
                {
                    basketItem = new BasketItemViewModel
                    {
                        BookId = bookId,
                        Count = 1
                    };

                    basketItems.Add(basketItem);
                }
                
            }
            else
            {
                basketItem = new BasketItemViewModel
                {
                    BookId = bookId,
                    Count = 1
                };

                basketItems.Add(basketItem);
            }

            basketItemStr = JsonConvert.SerializeObject(basketItems);

            HttpContext.Response.Cookies.Append("Basket", basketItemStr);

            return Ok(); // 200
        }

        public IActionResult GetBasket()
        {
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();

            string basketItemStr = HttpContext.Request.Cookies["Basket"];

            if(basketItemStr != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemStr);
            }

            return Json(basketItems);
        }

        public IActionResult Test()
        {
            // cookieden basket itemleri goturur ve geriye qaytarir

            return PartialView("_BasketPartial");
        }

        public IActionResult Checkout()
        {
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            List<BookCheckoutViewModel> bookCheckoutItems = new List<BookCheckoutViewModel>();
            BookCheckoutViewModel bookCheckoutItem = null;

            string basketItemsStr = HttpContext.Request.Cookies["Basket"];

            if(basketItemsStr != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemsStr);

                foreach (var basketItem in basketItems)
                {
                    bookCheckoutItem = new BookCheckoutViewModel
                    {
                        Book = _pustokContext.Books.FirstOrDefault(b => b.Id == basketItem.BookId),
                        Count = basketItem.Count
                    };
                    bookCheckoutItems.Add(bookCheckoutItem);
                }
            }


            return View(bookCheckoutItems);
        }
    }
}
