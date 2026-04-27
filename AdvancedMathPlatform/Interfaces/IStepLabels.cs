namespace AdvancedMathPlatform.Interfaces
{
    // Produs 1: Etichete pentru pașii de rezolvare
    public interface IStepLabels
    {
        string Language { get; }
        string Equation { get; }
        string Coefficients { get; }
        string Step1 { get; }
        string Step2 { get; }
        string MoveTermRight { get; }
        string DivideBy { get; }
        string Result { get; }
        string Discriminant { get; }
        string TwoSolutions { get; }
        string DoubleSolution { get; }
        string NoRealSolutions { get; }
    }
}