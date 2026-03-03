namespace AdvancedMathPlatform.Models
{
    public class LinearProblem : MathProblem
    {
        public LinearProblem(string expression)
            : base(expression)
        {
        }

        public override List<double> Solve()
        {
            return new List<double> { 1 };
        }

    }
}
