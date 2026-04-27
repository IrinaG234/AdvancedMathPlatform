using AdvancedMathPlatform.Factories;
using AdvancedMathPlatform.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedMathPlatform.Controllers
{
    public class LinearController : Controller
    {
        public IActionResult Index()
            => View(new MathViewModel());

        [HttpPost]
        public IActionResult Calculate(MathViewModel model)
        {
            var (a, b, error) = EquationParser.ParseLinear(model.Equation ?? "");

            if (error != null)
            {
                model.ParseError = error;
                return View("Index", model);
            }

            var factory = new LinearProblemFactory();
            var problem = factory.CreateProblem(a, b);
            model.Steps = problem.SolveWithSteps().ToList();

            return View("Index", model);
        }
    }
}
