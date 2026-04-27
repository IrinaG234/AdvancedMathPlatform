namespace AdvancedMathPlatform.Interfaces
{
    // Produs 2: Mesaje de rezultat
    public interface IMessages
    {
        string Language { get; }
        string NoSolution { get; }
        string InfiniteSolutions { get; }
        string NotQuadratic { get; }
    }
}