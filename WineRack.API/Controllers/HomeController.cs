using Microsoft.AspNetCore.Mvc;

namespace WineRack.API.Controllers
{
    [ApiController]
    [Route("winerack/home")]
    public class HomeController : Controller
    {
        [HttpGet("home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
