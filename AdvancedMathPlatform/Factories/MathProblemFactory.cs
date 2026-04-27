using AdvancedMathPlatform.Interfaces;
using AdvancedMathPlatform.Models;

namespace AdvancedMathPlatform.Factories
{
    // ─creat abstrc
    public abstract class MathProblemFactory
    {
        public abstract IMathProblem CreateProblem(IStepLabels labels, IMessages messages, params double[] parameters);

        public string SolveAndDescribe(IStepLabels labels, IMessages messages, params double[] parameters)
        {
            IMathProblem problem = CreateProblem(labels, messages, parameters);
            return $"{problem.GetDescription()}\n{labels.Result}: {problem.Solve()}";
        }
    }

    //  Concrete Creator: grad1
    public class LinearProblemFactory : MathProblemFactory
    {
        public override IMathProblem CreateProblem(IStepLabels labels, IMessages messages, params double[] parameters)
            => new LinearProblem(parameters[0], parameters[1], labels, messages);
    }

    //  Concrete Creator: grad2
    public class QuadraticProblemFactory : MathProblemFactory
    {
        public override IMathProblem CreateProblem(IStepLabels labels, IMessages messages, params double[] parameters)
            => new QuadraticProblem(parameters[0], parameters[1], parameters[2], labels, messages);
    }
}
