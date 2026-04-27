using System.Globalization;
using System.Text.RegularExpressions;

namespace AdvancedMathPlatform.Models
{
    public static class EquationParser
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        public static (double a, double b, string? error) ParseLinear(string equation)
        {
            try
            {
                string eq = equation.Replace(" ", "").ToLower();

                if (eq.Contains("x^2") || eq.Contains("x²"))
                    return (0, 0, "Aceasta este o ecuație de gradul 2, nu gradul 1.");

                if (!eq.Contains("x"))
                    return (0, 0, "Ecuația trebuie să conțină necunoscuta x.");

                if (!eq.EndsWith("=0"))
                    return (0, 0, "Ecuația trebuie să fie de forma ax+b=0.");

                eq = eq[..^2];
                if (!eq.StartsWith("-") && !eq.StartsWith("+"))
                    eq = "+" + eq;

                double a = 0, b = 0;

                var mA = Regex.Match(eq, @"([+-]\d*\.?\d*)x");
                if (mA.Success)
                {
                    string s = mA.Groups[1].Value;
                    a = s is "+" or "" ? 1 : s == "-" ? -1 : double.Parse(s, Inv);
                }

                string rest = Regex.Replace(eq, @"[+-]?\d*\.?\d*x", "");
                if (!string.IsNullOrEmpty(rest))
                    b = double.Parse(rest, Inv);

                if (a == 0)
                    return (0, 0, "Coeficientul lui x nu poate fi 0 (nu mai e ecuație de gradul 1).");

                return (a, b, null);
            }
            catch
            {
                return (0, 0, "Format invalid. Exemplu corect: 2x+3=0");
            }
        }

        public static (double a, double b, double c, string? error) ParseQuadratic(string equation)
        {
            try
            {
                string eq = equation.Replace(" ", "").ToLower().Replace("x²", "x^2");

                if (!eq.Contains("x^2"))
                    return (0, 0, 0, "Ecuația trebuie să conțină x^2.");

                if (!eq.EndsWith("=0"))
                    return (0, 0, 0, "Ecuația trebuie să fie de forma ax^2+bx+c=0.");

                eq = eq[..^2];
                if (!eq.StartsWith("-") && !eq.StartsWith("+"))
                    eq = "+" + eq;

                double a = 0, b = 0, c = 0;

                var mA = Regex.Match(eq, @"([+-]\d*\.?\d*)x\^2");
                if (mA.Success)
                {
                    string s = mA.Groups[1].Value;
                    a = s is "+" or "" ? 1 : s == "-" ? -1 : double.Parse(s, Inv);
                }

                var mB = Regex.Match(eq, @"([+-]\d*\.?\d*)x(?!\^)");
                if (mB.Success)
                {
                    string s = mB.Groups[1].Value;
                    b = s is "+" or "" ? 1 : s == "-" ? -1 : double.Parse(s, Inv);
                }

                string rest = Regex.Replace(eq, @"[+-]?\d*\.?\d*x(?:\^2)?", "");
                if (!string.IsNullOrEmpty(rest))
                    c = double.Parse(rest, Inv);

                if (a == 0)
                    return (0, 0, 0, "Coeficientul lui x² nu poate fi 0.");

                return (a, b, c, null);
            }
            catch
            {
                return (0, 0, 0, "Format invalid. Exemplu corect: 2x^2+3x-5=0");
            }
        }
    }
}
