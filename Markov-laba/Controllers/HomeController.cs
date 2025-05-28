using System.Diagnostics;
using Markov_laba.Data;
using Markov_laba.Models;
using Markov_laba.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Markov_laba.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Markov_labaContext _context;
        public HomeController(ILogger<HomeController> logger, Markov_labaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.u == "client")
                {
                    _context.Client.Add(new Client { login = model.l, password = model.p });
                }
                else if (model.u == "courier")
                {
                    _context.Courier.Add(new Courier { login = model.l, password = model.p });
                }
                await _context.SaveChangesAsync();

            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
