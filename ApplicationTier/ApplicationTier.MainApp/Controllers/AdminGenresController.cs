using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.MainApp.Controllers
{
    public class AdminGenresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
