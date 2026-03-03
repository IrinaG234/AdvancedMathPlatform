using AdvancedMathPlatform.Interfaces;

namespace AdvancedMathPlatform.Services
{
    public class BasicCalculator : ICalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
