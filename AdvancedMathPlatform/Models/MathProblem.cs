using System.Collections.Generic;

namespace AdvancedMathPlatform.Models
{
    public abstract class MathProblem
    {
        public string Expression { get; protected set; }

        public MathProblem(string expression)
        {
            Expression = expression;
        }

        public abstract List<double> Solve();
    }
}
