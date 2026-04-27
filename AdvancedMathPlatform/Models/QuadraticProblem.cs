using AdvancedMathPlatform.Interfaces;

namespace AdvancedMathPlatform.Models
{
    public class QuadraticProblem : IMathProblem
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public string ProblemType => "Quadratic";

        public QuadraticProblem(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public string Solve()
        {
            if (_a == 0)
                return "Nu este ecuație de gradul 2 (a = 0)";

            double delta = _b * _b - 4 * _a * _c;

            if (delta < 0)
                return $"Fără soluții reale (Δ = {delta:F2} < 0)";

            if (delta == 0)
                return $"x = {-_b / (2 * _a):F4}";

            double x1 = (-_b + Math.Sqrt(delta)) / (2 * _a);
            double x2 = (-_b - Math.Sqrt(delta)) / (2 * _a);
            return $"x₁ = {x1:F4},  x₂ = {x2:F4}";
        }

        public string GetDescription()
            => $"Ecuație de gradul 2: {_a}x² + ({_b})x + ({_c}) = 0  →  Δ = {_b * _b - 4 * _a * _c:F2}";

        public IEnumerable<string> SolveWithSteps()
        {
            double b2   = _b * _b;
            double ac4  = 4 * _a * _c;
            double delta = b2 - ac4;

            yield return $"Ecuația: {_a}x² + ({_b})x + ({_c}) = 0";
            yield return $"Coeficienți: a = {_a},  b = {_b},  c = {_c}";
            yield return "─────────────────────────────────────";
            yield return "Pasul 1: Calculăm discriminantul Δ";
            yield return "  Δ = b² - 4ac";
            yield return $"  Δ = ({_b})² - 4 · ({_a}) · ({_c})";
            yield return $"  Δ = {b2} - ({ac4})";
            yield return $"  Δ = {delta}";
            yield return "─────────────────────────────────────";

            if (delta < 0)
            {
                yield return $"Δ = {delta} < 0";
                yield return "Ecuația nu are soluții reale.";
            }
            else if (delta == 0)
            {
                yield return "Δ = 0  →  o soluție dublă (x₁ = x₂)";
                yield return "Pasul 2: Calculăm soluția";
                yield return "  x = -b / (2a)";
                double x = -_b / (2 * _a);
                yield return $"  x = -({_b}) / (2 · {_a})";
                yield return $"  x = {x:F4}";
            }
            else
            {
                double sqrtD = Math.Sqrt(delta);
                yield return $"Δ = {delta} > 0  →  două soluții reale distincte";
                yield return $"  √Δ = √{delta} ≈ {sqrtD:F4}";
                yield return "Pasul 2: Calculăm soluțiile";
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
