namespace AdvancedMathPlatform.Models
{
    public class MathViewModel
    {
        public string ProblemType { get; set; } = "Linear";
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public string? Equation { get; set; }
        public string? Result { get; set; }
        public string? Description { get; set; }
        public string? ParseError { get; set; }
        public List<string> Steps { get; set; } = new();

        // ── Abstract Factory (Language) ───────────────────────
        public string Language { get; set; } = "Română";
        public string LanguageFlag { get; set; } = "🇷🇴";
    }
}
