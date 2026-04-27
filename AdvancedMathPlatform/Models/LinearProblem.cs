using AdvancedMathPlatform.Interfaces;

namespace AdvancedMathPlatform.Models
{
    public class LinearProblem : IMathProblem
    {
        private readonly double _a;
        private readonly double _b;

        public string ProblemType => "Linear";

        public LinearProblem(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public string Solve()
        {
            if (_a == 0)
                return _b == 0 ? "Infinit de soluții" : "Fără soluție (a = 0)";

            double x = -_b / _a;
            return $"x = {x}";
        }

        public string GetDescription()
            => $"Ecuație liniară: {_a}x + ({_b}) = 0";

        public IEnumerable<string> SolveWithSteps()
        {
            yield return $"Ecuația: {_a}x + ({_b}) = 0";
            yield return $"Coeficienți: a = {_a},  b = {_b}";
            yield return "─────────────────────────────────────";

            if (_a == 0)
            {
                if (_b == 0)
                    yield return "0 = 0  →  Ecuația are infinit de soluții.";
                else
                    yield return $"{_b} = 0  →  Ecuația nu are soluție.";
                yield break;
            }

            yield return $"Pasul 1: Mutăm termenul liber în dreapta egalului";
            yield return $"  {_a}x = -{_b}";
            yield return $"Pasul 2: Împărțim ambii membri la {_a}";
            double x = -_b / _a;
            yield return $"  x = -{_b} ÷ {_a}";
            yield return $"─────────────────────────────────────";
            yield return $"  x = {x}";
        }
    }
}
