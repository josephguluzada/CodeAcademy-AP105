using Microsoft.AspNetCore.Mvc;

namespace MVCFirst.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    var contentStr = new ContentResult();
        //    contentStr.Content = "Hello, AB102";

        //    return contentStr;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Json()
        {
            return Json(new {Id=5, Name= "Kamran", Age = 8 });
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult GetNumber(int id)
        {
            int number = id;

            return View(number);
        }

        public IActionResult GetString(int id, string surname)
        {
            string nameStr = id + " " + surname;

            return View((object)nameStr);
        }
    }
}
