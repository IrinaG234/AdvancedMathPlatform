using AdvancedMathPlatform.Interfaces;

namespace AdvancedMathPlatform.Models
{
    public class LinearProblem : IMathProblem
    {
        private readonly double _a;
        private readonly double _b;
        private readonly IStepLabels _labels;
        private readonly IMessages _messages;

        public string ProblemType => "Linear";

        public LinearProblem(double a, double b, IStepLabels labels, IMessages messages)
        {
            _a = a;
            _b = b;
            _labels = labels;
            _messages = messages;
        }

        public string Solve()
        {
            if (_a == 0)
                return _b == 0 ? _messages.InfiniteSolutions : _messages.NoSolution;

            double x = -_b / _a;
            return $"x = {x}";
        }

        public string GetDescription()
            => $"{_labels.Equation}: {_a}x + ({_b}) = 0";

        public IEnumerable<string> SolveWithSteps()
        {
            yield return $"{_labels.Equation}: {_a}x + ({_b}) = 0";
            yield return $"{_labels.Coefficients}: a = {_a},  b = {_b}";
            yield return "─────────────────────────────────────";

            if (_a == 0)
            {
                if (_b == 0)
                    yield return $"0 = 0  →  {_messages.InfiniteSolutions}";
                else
                    yield return $"{_b} = 0  →  {_messages.NoSolution}";
                yield break;
            }

            yield return $"{_labels.Step1}: {_labels.MoveTermRight}";
            yield return $"  {_a}x = -{_b}";
            yield return $"{_labels.Step2}: {_labels.DivideBy} {_a}";
            double x = -_b / _a;
            yield return $"  x = -{_b} ÷ {_a}";
            yield return "─────────────────────────────────────";
            yield return $"  x = {x}";
        }
    }
}