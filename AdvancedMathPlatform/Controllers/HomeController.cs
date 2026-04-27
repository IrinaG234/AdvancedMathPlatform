using Microsoft.AspNetCore.Mvc;

namespace AdvancedMathPlatform.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
            => View();
    }
}
