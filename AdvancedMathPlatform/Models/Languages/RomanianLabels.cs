using AdvancedMathPlatform.Interfaces;

namespace AdvancedMathPlatform.Models.Languages
{
    public class RomanianLabels : IStepLabels
    {
        public string Language => "Română";
        public string Equation => "Ecuația";
        public string Coefficients => "Coeficienți";
        public string Step1 => "Pasul 1";
        public string Step2 => "Pasul 2";
        public string MoveTermRight => "Mutăm termenul liber în dreapta egalului";
        public string DivideBy => "Împărțim ambii membri la";
        public string Result => "Rezultat";
        public string Discriminant => "Calculăm discriminantul Δ";
        public string TwoSolutions => "două soluții reale distincte";
        public string DoubleSolution => "o soluție dublă (x₁ = x₂)";
        public string NoRealSolutions => "Ecuația nu are soluții reale.";
    }

    public class RomanianMessages : IMessages
    {
        public string Language => "Română";
        public string NoSolution => "Fără soluție (a = 0)";
        public string InfiniteSolutions => "Infinit de soluții";
        public string NotQuadratic => "Nu este ecuație de gradul 2 (a = 0)";
    }
}