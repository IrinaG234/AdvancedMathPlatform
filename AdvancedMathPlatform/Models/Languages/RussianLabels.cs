using AdvancedMathPlatform.Interfaces;

namespace AdvancedMathPlatform.Models.Languages
{
    public class RussianLabels : IStepLabels
    {
        public string Language => "Русский";
        public string Equation => "Уравнение";
        public string Coefficients => "Коэффициенты";
        public string Step1 => "Шаг 1";
        public string Step2 => "Шаг 2";
        public string MoveTermRight => "Переносим свободный член в правую часть";
        public string DivideBy => "Делим обе части на";
        public string Result => "Результат";
        public string Discriminant => "Вычисляем дискриминант Δ";
        public string TwoSolutions => "два различных вещественных корня";
        public string DoubleSolution => "один двойной корень (x₁ = x₂)";
        public string NoRealSolutions => "Уравнение не имеет вещественных корней.";
    }

    public class RussianMessages : IMessages
    {
        public string Language => "Русский";
        public string NoSolution => "Нет решения (a = 0)";
        public string InfiniteSolutions => "Бесконечно много решений";
        public string NotQuadratic => "Не является уравнением 2-й степени (a = 0)";
    }
}