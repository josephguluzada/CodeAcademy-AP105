using Microsoft.AspNetCore.Mvc;
using MVCFirst.Models;

namespace MVCFirst.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            Student student1 = new Student { Id = 1, Name = "Reshad", Age =13};
            Student student2 = new Student { Id = 2, Name = "Vasif", Age =16};
            Student student3 = new Student { Id = 3, Name = "Agasif", Age =23};

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            return View(students);
        }

        public IActionResult Detail(int id)
        {
            List<Student> students = new List<Student>();
            Student student1 = new Student { Id = 1, Name = "Reshad", Age = 13 };
            Student student2 = new Student { Id = 2, Name = "Vasif", Age = 16 };
            Student student3 = new Student { Id = 3, Name = "Agasif", Age = 23 };

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            Student student = students.Find(std => std.Id == id);

            //if (student is null) return NotFound();

            return View(student);
        }
    }
}
