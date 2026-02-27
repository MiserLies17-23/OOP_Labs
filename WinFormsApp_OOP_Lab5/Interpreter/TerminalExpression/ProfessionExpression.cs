using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression
{
    /// <summary>
    /// Класс, представляющий терминальное выражение для профессии
    /// Реализует метод Intepret интерфейса IExpression
    /// </summary>
    public class ProfessionExpression : IExpression
    {
        /// <summary> Профессия </summary>
        private readonly Profession _profession;

        /// <summary>
        /// Метод с параметрами
        /// </summary>
        /// <param name="profession"> профессия </param>
        public ProfessionExpression(Profession profession)
        {
            _profession = profession;
        }

        /// <summary>
        /// Метод для интерпретации контекста
        /// </summary>
        /// <param name="context"> контекст</param>
        /// <returns> результат интерпретации </returns>
        public bool Interpret(Context context)
        {
            return _profession == context.CurrentPerson.Profession;
        }
    }
}
