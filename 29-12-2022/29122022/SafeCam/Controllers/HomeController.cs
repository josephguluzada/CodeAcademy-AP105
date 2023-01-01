using Microsoft.AspNetCore.Mvc;
using SafeCam.Models;
using SafeCam.ViewModels;

namespace SafeCam.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _dataContext;
        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            //List<Slider> sliders = new List<Slider>
            //{
            //    new Slider{Id = 1, Title = "Hello", Desc = "Welcome to AzTU!!!", ImageUrl = "carousel-1.jpg", RedirectUrl1 = "https://classroom.google.com/u/0/h", RedirectUrl2="https://www.google.com/"},
            //    new Slider{Id = 2, Title = "Bye bye", Desc = "Salamlar, her kese", ImageUrl = "carousel-2.jpg", RedirectUrl1 = "https://classroom.google.com/u/0/h", RedirectUrl2="https://www.google.com/"},
            //    new Slider{Id = 3, Title = "Salam", Desc = "Guvenlik bizim isimiz", ImageUrl = "carousel-3.jpg", RedirectUrl1 = "https://classroom.google.com/u/0/h", RedirectUrl2="https://www.google.com/"},
            //};

            //List<SecurityService> securityServices = new List<SecurityService>
            //{
            //    new SecurityService{ Id =1, Title = "Quraşdirilma" , Desc = "Isimizi bilirik!", Icon = "<i class=\"flaticon-cctv d-block display-1 fw-normal text-secondary mb-3\"></i>", RedirectUrl = "https://www.google.com/"},
            //    new SecurityService{ Id =2, Title = "Ayarlar" , Desc = "Duzgun edin!", Icon = "<i class=\"flaticon-surveillance d-block display-1 fw-normal text-secondary mb-3\"></i>", RedirectUrl = "https://www.google.com/"},
            //    new SecurityService{ Id =3, Title = "Temir ve Servic" , Desc = "1 ay erzinde pulsuzdur", Icon = "<i class=\"flaticon-double d-block display-1 fw-normal text-secondary mb-3\"></i>", RedirectUrl = "https://www.google.com/"},

            //};

            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _dataContext.Sliders.ToList(),
                SecurityServices = _dataContext.SecurityServices.ToList()
            };

            return View(homeVM);
        }
    }
}