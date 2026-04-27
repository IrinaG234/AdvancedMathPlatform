using AdvancedMathPlatform.Interfaces;

namespace AdvancedMathPlatform.Models
{
    public class QuadraticProblem : IMathProblem
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        private readonly IStepLabels _labels;
        private readonly IMessages _messages;

        public string ProblemType => "Quadratic";

        public QuadraticProblem(double a, double b, double c, IStepLabels labels, IMessages messages)
        {
            _a = a;
            _b = b;
            _c = c;
            _labels = labels;
            _messages = messages;
        }

        public string Solve()
        {
            if (_a == 0) return _messages.NotQuadratic;

            double delta = _b * _b - 4 * _a * _c;

            if (delta < 0) return $"{_messages.NoSolution} (Δ = {delta:F2} < 0)";
            if (delta == 0) return $"x = {-_b / (2 * _a):F4}";

            double x1 = (-_b + Math.Sqrt(delta)) / (2 * _a);
            double x2 = (-_b - Math.Sqrt(delta)) / (2 * _a);
            return $"x₁ = {x1:F4},  x₂ = {x2:F4}";
        }

        public string GetDescription()
            => $"{_labels.Equation}: {_a}x² + ({_b})x + ({_c}) = 0";

        public IEnumerable<string> SolveWithSteps()
        {
            double b2 = _b * _b;
            double ac4 = 4 * _a * _c;
            double delta = b2 - ac4;

            yield return $"{_labels.Equation}: {_a}x² + ({_b})x + ({_c}) = 0";
            yield return $"{_labels.Coefficients}: a = {_a},  b = {_b},  c = {_c}";
            yield return "─────────────────────────────────────";
            yield return $"{_labels.Step1}: {_labels.Discriminant}";
            yield return "  Δ = b² - 4ac";
            yield return $"  Δ = ({_b})² - 4 · ({_a}) · ({_c})";
            yield return $"  Δ = {b2} - ({ac4})";
            yield return $"  Δ = {delta}";
            yield return "─────────────────────────────────────";

            if (delta < 0)
            {
                yield return $"Δ = {delta} < 0";
                yield return _labels.NoRealSolutions;
            }
            else if (delta == 0)
            {
                yield return $"Δ = 0  →  {_labels.DoubleSolution}";
                yield return $"{_labels.Step2}: {_labels.Result}";
                yield return "  x = -b / (2a)";
                double x = -_b / (2 * _a);
                yield return $"  x = -({_b}) / (2 · {_a})";
                yield return $"  x = {x:F4}";
            }
            else
            {
                double sqrtD = Math.Sqrt(delta);
                yield return $"Δ = {delta} > 0  →  {_labels.TwoSolutions}";
                yield return $"  √Δ = √{delta} ≈ {sqrtD:F4}";
                yield return $"{_labels.Step2}: {_labels.Result}";
                yield return "  x₁ = (-b + √Δ) / (2a)";
                double x1 = (-_b + sqrtD) / (2 * _a);
                yield return $"  x₁ = (-({_b}) + {sqrtD:F4}) / (2 · {_a}) = {x1:F4}";
                yield return "  x₂ = (-b - √Δ) / (2a)";
                double x2 = (-_b - sqrtD) / (2 * _a);
                yield return $"  x₂ = (-({_b}) - {sqrtD:F4}) / (2 · {_a}) = {x2:F4}";
            }
        }
    }
}
