namespace WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression
{
    /// <summary>
    /// Класс, представляющий терминальное выражение для возраста
    /// Реализует метод Intepret интерфейса IExpression
    /// </summary>
    public class AgeExpression : IExpression
    {
        /// <summary> Возраст </summary>
        private readonly AgeRange _age;

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="age"> возраст </param>
        public AgeExpression(AgeRange age)
        {
            _age = age;
        }

        /// <summary>
        /// Метод для интерпретации контекста
        /// </summary>
        /// <param name="context"> контекст </param>
        /// <returns> результат интерпретации </returns>
        public bool Interpret(Context context)
        {
            return _age.Down <= context.CurrentPerson.Age &&
                context.CurrentPerson.Age <= _age.Top;
        }
    }
}
