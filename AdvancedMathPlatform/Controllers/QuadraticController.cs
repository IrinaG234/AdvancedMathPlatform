using Microsoft.AspNetCore.Mvc;
using AdvancedMathPlatform.Models;

namespace AdvancedMathPlatform.Controllers
{
    public class QuadraticController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult Index(string expression)
        {
            var problem = new QuadraticProblem(expression);
            var solutions = problem.Solve();

            ViewBag.Expression = expression;
            ViewBag.Solutions = solutions;

            return View();
        }
    }
}
