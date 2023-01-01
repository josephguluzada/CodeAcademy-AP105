using _29122022.Models;
using _29122022.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _29122022.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id = 1, Name = "Behruz", Age = 11, TeacherId = 1},
                new Student{Id = 90, Name = "Rafiq", Age = 12, TeacherId = 2},
                new Student{Id = 122, Name = "Faiq", Age = 17, TeacherId = 3},
                new Student{Id = 166, Name = "Feyruz", Age = 15, TeacherId = 3},
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher{Id = 1, Name = "Eli", Experience = 11 },
                new Teacher{Id = 2, Name = "Eliyeddin", Experience = 12 },
                new Teacher{Id = 3, Name = "Taceddin", Experience = 17}
            };

            List<Group> groups = new List<Group>
            {
                new Group {Id=1,Name = "AB102"},
                new Group {Id=2,Name = "AB101"},
            };

            HomeViewModel homeVM = new HomeViewModel
            {
                Students = students,
                Teachers = teachers,
                Groups = groups
            };

            return View(homeVM);
        }
    }
}
