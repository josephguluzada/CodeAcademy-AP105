using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pustok.Helpers;
using Pustok.Models;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles ="SuperAdmin,Admin")]
    public class SliderController : Controller
    {
        private readonly PustokContext _pustokContext;
        private readonly IWebHostEnvironment _env;

        public SliderController(PustokContext pustokContext, IWebHostEnvironment env)
        {
            _pustokContext = pustokContext;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Slider> sliderList = _pustokContext.Sliders.ToList();

            return View(sliderList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            if(slider.ImageFile.ContentType != "image/png" && slider.ImageFile.ContentType != "image/jpeg")
            {
                ModelState.AddModelError("ImageFile", "Ancaq png ve jpeg ola biler");
                return View();
            }

            if(slider.ImageFile.Length > 3145728)
            {
                ModelState.AddModelError("ImageFile", "Seklin olcusu maximum 3 mb ola biler");
                return View();
            }

            //string name = slider.ImageFile.FileName;
            //if(name.Length > 64)
            //{
            //    name = name.Substring(name.Length-64, 64);
            //}

            //name = Guid.NewGuid().ToString() + name;

            ////string path = "C:\\Users\\asus\\Desktop\\University\\AP105\\06-01-2023\\Pustok\\Pustok\\wwwroot\\uploads\\sliders\\" + name;

            //string path = Path.Combine(_env.WebRootPath, "uploads/sliders", name);

            //using (FileStream fileStream = new FileStream(path, FileMode.Create))
            //{
            //    slider.ImageFile.CopyTo(fileStream);
            //}

            slider.Image = FileManager.SaveFile(_env.WebRootPath, "uploads/sliders", slider.ImageFile);

            _pustokContext.Sliders.Add(slider);
            _pustokContext.SaveChanges();

            return RedirectToAction("index");
        }


        public IActionResult Update(int id)
        {
            Slider slider = _pustokContext.Sliders.Find(id);
            if (slider == null) return View("Error");

            return View(slider);
        }

        [HttpPost]
        public IActionResult Update(Slider slider)
        {
            Slider existSlider = _pustokContext.Sliders.Find(slider.Id);

            if (existSlider == null) return View("Error");

            if(slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/png" && slider.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Ancaq png ve jpeg ola biler");
                    return View();
                }

                if (slider.ImageFile.Length > 3145728)
                {
                    ModelState.AddModelError("ImageFile", "Seklin olcusu maximum 3 mb ola biler");
                    return View();
                }

                string name =  FileManager.SaveFile(_env.WebRootPath,"uploads/sliders",slider.ImageFile);

                //string deletePath = Path.Combine(_env.WebRootPath, "uploads/sliders", existSlider.Image);
                //if (System.IO.File.Exists(deletePath))
                //{
                //    System.IO.File.Delete(deletePath);
                //}
                FileManager.DeleteFile(_env.WebRootPath, "uploads/sliders", existSlider.Image);

                existSlider.Image = name;
            }

            existSlider.Title1 = slider.Title1;
            existSlider.Title2 = slider.Title2;
            existSlider.Desc = slider.Desc;
            existSlider.RedirectUrl = slider.RedirectUrl;
            existSlider.RedirectUrlText = slider.RedirectUrlText;
            existSlider.Order = slider.Order;

            _pustokContext.SaveChanges();

            return RedirectToAction("Index");

        }


        public IActionResult Delete(int id)
        {
            Slider slider = _pustokContext.Sliders.FirstOrDefault(s => s.Id == id);
            if (slider == null) return NotFound(); // 404

            if (slider.Image != null)
            {
                FileManager.DeleteFile(_env.WebRootPath, "uploads/sliders", slider.Image);
            }

            _pustokContext.Sliders.Remove(slider);
            _pustokContext.SaveChanges();

            return Ok(); // 200
        }
    }
}
