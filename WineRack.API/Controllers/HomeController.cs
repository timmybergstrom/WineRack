using Microsoft.AspNetCore.Mvc;

namespace WineRack.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
