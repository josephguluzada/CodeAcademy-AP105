using Eterna.Models;
using Eterna.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly DataContext _dataContext;

        public PortfolioController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            PortfolioViewModel portfolioVM = new PortfolioViewModel
            {
                Portfolios = _dataContext.Portfolios
                                        .Include(x=> x.Category)
                                        .Include(pi => pi.PortfolioImages).ToList(),
                Categories = _dataContext.Categories.ToList()
            };
            return View(portfolioVM);
        }

        public IActionResult Detail(int id)
        {
            Portfolio portfolio = _dataContext.Portfolios
                                .Include(por => por.Category)
                                .Include(pi => pi.PortfolioImages).FirstOrDefault(por => por.Id == id);

            if (portfolio is null) return NotFound();
            return View(portfolio);
        }
    }
}
