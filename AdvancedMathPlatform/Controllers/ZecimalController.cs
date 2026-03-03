using Microsoft.AspNetCore.Mvc;
using AdvancedMathPlatform.Models;
using AdvancedMathPlatform.Interfaces;

namespace AdvancedMathPlatform.Controllers
{
    public class ZecimaleController : Controller
    {
        private readonly ICalculator _calculator;

        public ZecimaleController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public IActionResult Index()
        {
            return View(new MathViewModel());
        }

        [HttpPost]
        public IActionResult Calculate(MathViewModel model)
        {
            if (!string.IsNullOrWhiteSpace(model.Expression))
            {
                var parts = model.Expression.Split('+');

                decimal sum = 0;

                foreach (var part in parts)
                {
                    if (decimal.TryParse(part.Trim(), out decimal number))
                    {
                        sum += number;
                    }
                }

                model.Result = (double)sum;
            }

            return View("Index", model);
        }

    }
}
