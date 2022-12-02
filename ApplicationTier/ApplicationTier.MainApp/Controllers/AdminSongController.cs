using Microsoft.AspNetCore.Mvc;

namespace ApplicationTier.MainApp.Controllers
{
    public class AdminSongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
