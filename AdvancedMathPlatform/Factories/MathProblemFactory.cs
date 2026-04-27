using AdvancedMathPlatform.Interfaces;
using AdvancedMathPlatform.Models;

namespace AdvancedMathPlatform.Factories
{
    // ─── Creator abstract ────────────────────────────────────────────────────────
    // Declară factory method-ul; subclasele decid CE obiect concret se creează.
    // Respectă OCP: adaugi tipuri noi fără a modifica această clasă.
    public abstract class MathProblemFactory
    {
        public abstract IMathProblem CreateProblem(params double[] parameters);

        // Metodă template care folosește factory method-ul – logică comună.
        public string SolveAndDescribe(params double[] parameters)
        {
            IMathProblem problem = CreateProblem(parameters);
            return $"{problem.GetDescription()}\nRezultat: {problem.Solve()}";
        }
    }

    // ─── Concrete Creator: Linear ────────────────────────────────────────────────
    public class LinearProblemFactory : MathProblemFactory
    {
        // parameters: [a, b]  →  ax + b = 0
        public override IMathProblem CreateProblem(params double[] parameters)
            => new LinearProblem(parameters[0], parameters[1]);
    }

    // ─── Concrete Creator: Quadratic ─────────────────────────────────────────────
    public class QuadraticProblemFactory : MathProblemFactory
    {
        // parameters: [a, b, c]  →  ax² + bx + c = 0
        public override IMathProblem CreateProblem(params double[] parameters)
            => new QuadraticProblem(parameters[0], parameters[1], parameters[2]);
    }
}
