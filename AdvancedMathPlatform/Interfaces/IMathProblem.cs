namespace AdvancedMathPlatform.Interfaces
{
    public interface IMathProblem
    {
        string ProblemType { get; }
        string Solve();
        string GetDescription();
        IEnumerable<string> SolveWithSteps();
    }
}
