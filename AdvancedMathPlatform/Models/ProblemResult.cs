namespace AdvancedMathPlatform.Models
{
    public class ProblemResult
    {
        public MathProblem Problem { get; private set; }
        public List<double> Result { get; private set; }


        public ProblemResult(MathProblem problem)
        {
            Problem = problem;
            Result = problem.Solve();
        }
    }
}
