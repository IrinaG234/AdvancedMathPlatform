using AdvancedMathPlatform.Interfaces;

namespace AdvancedMathPlatform.Models.Languages
{
    public class EnglishLabels : IStepLabels
    {
        public string Language => "English";
        public string Equation => "Equation";
        public string Coefficients => "Coefficients";
        public string Step1 => "Step 1";
        public string Step2 => "Step 2";
        public string MoveTermRight => "Move the constant to the right side";
        public string DivideBy => "Divide both sides by";
        public string Result => "Result";
        public string Discriminant => "Calculate the discriminant Δ";
        public string TwoSolutions => "two distinct real solutions";
        public string DoubleSolution => "one double solution (x₁ = x₂)";
        public string NoRealSolutions => "The equation has no real solutions.";
    }

    public class EnglishMessages : IMessages
    {
        public string Language => "English";
        public string NoSolution => "No solution (a = 0)";
        public string InfiniteSolutions => "Infinite solutions";
        public string NotQuadratic => "Not a quadratic equation (a = 0)";
    }
}