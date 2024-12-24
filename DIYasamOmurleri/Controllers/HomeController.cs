using DIYasamOmurleri.Models;
using DIYasamOmurleri.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DIYasamOmurleri.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TimeService _timeService;

        public HomeController(ILogger<HomeController> logger, TimeService timeService)
        {
            _logger = logger;
            _timeService = timeService;
        }

        public IActionResult Index()
        {
            ViewBag.Saat = _timeService.GetTime().ToString("HH:mm:ss.fffffff");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
