using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<AppUser> _userManager;

        public BookController(PustokContext pustokContext, UserManager<AppUser> userManager)
        {
            _pustokContext = pustokContext;
            _userManager = userManager;
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

        public async Task<IActionResult> AddToBasket(int bookId)
        {
            if (!_pustokContext.Books.Any(x => x.Id == bookId)) return NotFound(); // 404
            AppUser member = null;
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            BasketItemViewModel basketItem = null;
            string basketItemStr = HttpContext.Request.Cookies["Basket"];

            if (User.Identity.IsAuthenticated)
            {
                member = await _userManager.FindByNameAsync(User.Identity.Name);
            }
            
            if(member == null)
            {

                if (basketItemStr != null)
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemStr);

                    basketItem = basketItems.FirstOrDefault(x => x.BookId == bookId);

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
            }
            else
            {
                BasketItem memberBasketItem = _pustokContext.BasketItems.FirstOrDefault(x => x.AppUserId == member.Id && x.BookId == bookId);

                if (memberBasketItem != null) memberBasketItem.Count++;
                else
                {
                    memberBasketItem = new BasketItem
                    {
                        BookId = bookId,
                        AppUserId = member.Id,
                        Count = 1
                    };
                    _pustokContext.BasketItems.Add(memberBasketItem);
                }
            }
            _pustokContext.SaveChanges();
           

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

        public async Task<IActionResult> Checkout()
        {
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            List<BookCheckoutViewModel> bookCheckoutItems = new List<BookCheckoutViewModel>();
            List<BasketItem> memberBasketItems = new List<BasketItem>();
            BookCheckoutViewModel bookCheckoutItem = null;
            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = await _userManager.FindByNameAsync(User.Identity.Name);
            }
            string basketItemsStr = HttpContext.Request.Cookies["Basket"];

            if(member == null)
            {
                if (basketItemsStr != null)
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
            }
            else
            {
                memberBasketItems = _pustokContext.BasketItems.Include(x=>x.Book).Where(x=>x.AppUserId == member.Id).ToList();

                foreach (var item in memberBasketItems)
                {
                    bookCheckoutItem = new BookCheckoutViewModel
                    {
                        Book = item.Book,
                        Count = item.Count
                    };

                    bookCheckoutItems.Add(bookCheckoutItem);
                }
            }

            return View(bookCheckoutItems);
        }
    }
}
