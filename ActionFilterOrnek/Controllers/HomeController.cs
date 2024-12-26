using ActionFilterOrnek.Filters;
using ActionFilterOrnek.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace ActionFilterOrnek.Controllers
{
    [Yonlen]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("NEREDEYÝZ: HomeController > Index Action");
            return View();
        }

        // [TypeFilter<YonlenAttribute>]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("NEREDEYÝZ: OnActionExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("NEREDEYÝZ: OnActionExecuted");
        }
    }
}
