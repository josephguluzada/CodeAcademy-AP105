using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pustok.Models;
using Pustok.ViewModels;
using System.Diagnostics;
using System.Net;

namespace Pustok.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokContext _pustokContext;

        public HomeController(PustokContext pustokContext)
        {
            _pustokContext = pustokContext;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _pustokContext.Sliders.OrderBy(x => x.Order).ToList(),
                FeaturedBooks = _pustokContext.Books
                                    .Include(x => x.BookImages)
                                    .Include(x=> x.Author)
                                    .Where(x=> x.IsFeatured).ToList(),
                NewBooks = _pustokContext.Books
                                    .Include(x=>x.BookImages)
                                    .Include(x=>x.Author)
                                    .Where(x=>x.IsNew).ToList(),
                DiscountedBooks = _pustokContext.Books
                                    .Include(x => x.BookImages)
                                    .Include(x => x.Author)
                                    .Where(x => x.DiscountPrice >0).ToList()
            };

            return View(homeVM);
        }

        //public IActionResult SetSession(int id)
        //{
        //    HttpContext.Session.SetString("UserId", id.ToString());

        //    return Content("Added session");
        //}

        //public IActionResult GetSession()
        //{
        //    string  id = HttpContext.Session.GetString("UserId");

        //    return Content(id);
        //}

        //public IActionResult RemoveSession()
        //{
        //    HttpContext.Session.Remove("UserId");

        //    return RedirectToAction("index");
        //}

        //public IActionResult SetCookie(string name)
        //{
        //    HttpContext.Response.Cookies.Append("BookName", name);

        //    return Content("added cookie");
        //}

        //public IActionResult GetCookie()
        //{
        //    string bookName = HttpContext.Request.Cookies["BookName"];

        //    return Content(bookName);
        //}

        //public IActionResult SetCookie(int bookId)
        //{
        //    List<int> bookIds = new List<int>();

        //    string bookIdsStr = HttpContext.Request.Cookies["BookIds"];
        //    if(bookIdsStr != null)
        //    {
        //        bookIds = JsonConvert.DeserializeObject<List<int>>(bookIdsStr);
        //        bookIds.Add(bookId);
        //    }
        //    else
        //    {
        //        bookIds.Add(bookId);
        //    }

        //    bookIdsStr = JsonConvert.SerializeObject(bookIds);

        //    HttpContext.Response.Cookies.Append("BookIds", bookIdsStr);

        //    return Content("added cookie");
        //}

        //public IActionResult GetCookie()
        //{
        //    List<int> bookIds = new List<int>();

        //    string bookIdsStr = HttpContext.Request.Cookies["BookIds"];

        //    if(bookIdsStr != null)
        //    {
        //        bookIds = JsonConvert.DeserializeObject<List<int>>(bookIdsStr);
        //    }

        //    return Json(bookIds);
        //}
    }
}