using AdvancedMathPlatform.Interfaces;
using AdvancedMathPlatform.Models.Languages;

namespace AdvancedMathPlatform.Factories
{
    //abstrc factory rom
    public class RomanianFactory : ILanguageFactory
    {
        public string LanguageName => "Română";
        public string LanguageFlag => "🇷🇴";
        public IStepLabels CreateStepLabels() => new RomanianLabels();
        public IMessages CreateMessages() => new RomanianMessages();
    }

    // abstrc factory english
    public class EnglishFactory : ILanguageFactory
    {
        public string LanguageName => "English";
        public string LanguageFlag => "🇬🇧";
        public IStepLabels CreateStepLabels() => new EnglishLabels();
        public IMessages CreateMessages() => new EnglishMessages();
    }

    // abstrc factory rus
    public class RussianFactory : ILanguageFactory
    {
        public string LanguageName => "Русский";
        public string LanguageFlag => "🇷🇺";
        public IStepLabels CreateStepLabels() => new RussianLabels();
        public IMessages CreateMessages() => new RussianMessages();
    }

    // selec/default=romana
    public static class LanguageFactorySelector
    {
        public static ILanguageFactory GetFactory(string language) => language switch
        {
            "English" => new EnglishFactory(),
            "Russian" => new RussianFactory(),
            _ => new RomanianFactory() 
        };
    }
}