﻿using Microsoft.AspNetCore.Mvc;
using Pustok.Models;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SliderController : Controller
    {
        private readonly PustokContext _pustokContext;

        public SliderController(PustokContext pustokContext)
        {
            _pustokContext = pustokContext;
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

            string name = slider.ImageFile.FileName;
            if(name.Length > 64)
            {
                name = name.Substring(name.Length-64, 64);
            }

            name = Guid.NewGuid().ToString() + name;

            string path = "C:\\Users\\asus\\Desktop\\University\\AP105\\06-01-2023\\Pustok\\Pustok\\wwwroot\\uploads\\sliders\\" + name;

            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                slider.ImageFile.CopyTo(fileStream);
            }

            slider.Image = name;

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

            existSlider.Title1 = slider.Title1;
            existSlider.Title2 = slider.Title2;
            existSlider.Desc = slider.Desc;
            existSlider.RedirectUrl = slider.RedirectUrl;
            existSlider.RedirectUrlText = slider.RedirectUrlText;
            existSlider.Image = slider.Image;
            existSlider.Order = slider.Order;

            _pustokContext.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}