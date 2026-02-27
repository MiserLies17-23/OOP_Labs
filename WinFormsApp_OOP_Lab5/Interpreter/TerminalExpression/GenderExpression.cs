using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression
{
    /// <summary>
    /// Класс, представляющий терминальное выражение для пола 
    /// Реализует метод Intepret интерфейса IExpression
    /// </summary>
    public class GenderExpression : IExpression
    {
        /// <summary> Пол </summary>
        private readonly Gender _gender;

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="gender"> пол </param>
        public GenderExpression(Gender gender)
        {
            _gender = gender;
        }

        /// <summary>
        /// Метод для интерпретации контекста
        /// </summary>
        /// <param name="context"> контекст </param>
        /// <returns></returns>
        public bool Interpret(Context context)
        {
            return _gender == context.CurrentPerson.Gen;
        }

        /// <summary>
        /// Переопределённый метод ToString() для вывода пола
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _gender == Gender.MALE ? "Муж" : "Жен";
        }
    }
}
