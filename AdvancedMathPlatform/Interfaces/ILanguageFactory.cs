namespace AdvancedMathPlatform.Interfaces
{
    // ABSTRACT FACTORY — produce familia de obiecte pentru o limbă
    public interface ILanguageFactory
    {
        string LanguageName { get; }
        string LanguageFlag { get; }
        IStepLabels CreateStepLabels();
        IMessages CreateMessages();
    }
}