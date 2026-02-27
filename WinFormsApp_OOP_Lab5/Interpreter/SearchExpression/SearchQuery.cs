using WinFormsApp_OOP_Lab5.Interpreter.NonTerminalExpression;
using WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression;
using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Interpreter.SearchExpression
{
    /// <summary>
    /// Класс, представляющий общее выражение для поиска людей
    /// </summary>
    public class SearchQuery
    {
        /// <summary>
        /// Свойство - пол челвоека
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Свойство - первый логический оператор
        /// </summary>
        public Operation FirstOperation { get; set; }

        /// <summary>
        /// Свойство - диапазон возрастов
        /// </summary>
        public AgeRange? Age {get; set;}

        /// <summary>
        /// Свойство - второй оператор
        /// </summary>
        public Operation SecondOperation { get; set; }

        /// <summary>
        /// Свойство - профессия человека
        /// </summary>
        public Profession Profession { get; set; }
    }
}
