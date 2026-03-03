using System;
using System.Collections.Generic;

namespace AdvancedMathPlatform.Models
{
    public class QuadraticProblem : MathProblem
    {
        public QuadraticProblem(string expression)
            : base(expression)
        {
        }

        public override List<double> Solve()
        {
            var parts = Expression.Split(',');

            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[1]);
            double c = double.Parse(parts[2]);

            double delta = b * b - 4 * a * c;

            var solutions = new List<double>();

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                solutions.Add(x1);
                solutions.Add(x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                solutions.Add(x);
            }

            return solutions;
        }
    }
}
