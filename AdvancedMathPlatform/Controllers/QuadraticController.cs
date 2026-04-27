using AdvancedMathPlatform.Factories;
using AdvancedMathPlatform.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedMathPlatform.Controllers
{
    public class QuadraticController : Controller
    {
        public IActionResult Index()
            => View(new MathViewModel());

        [HttpPost]
        public IActionResult Calculate(MathViewModel model)
        {
            var (a, b, c, error) = EquationParser.ParseQuadratic(model.Equation ?? "");

            if (error != null)
            {
                model.ParseError = error;
                return View("Index", model);
            }

            // ── Abstract Factory: alege familia de limbă ──
            var langFactory = LanguageFactorySelector.GetFactory(model.Language);
            var labels = langFactory.CreateStepLabels();
            var messages = langFactory.CreateMessages();

            model.LanguageFlag = langFactory.LanguageFlag;

            // ── Factory Method: creează problema cu labels-urile limbii ──
            var factory = new QuadraticProblemFactory();
            var problem = factory.CreateProblem(labels, messages, a, b, c);
            model.Steps = problem.SolveWithSteps().ToList();

            return View("Index", model);
        }
    }
}
