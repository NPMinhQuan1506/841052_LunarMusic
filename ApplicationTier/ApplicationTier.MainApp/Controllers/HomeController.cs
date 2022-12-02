using ApplicationTier.MainApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApplicationTier.MainApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: HomeController/Genres/5
        [Route("Genres/{id:int?}")]
        public ActionResult Genres(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [Route("About")]
        public ActionResult About()
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