namespace WinFormsApp_OOP_Lab5.Interpreter.NonTerminalExpression
{
    /// <summary>
    /// Класс, представляющий 
    /// Реализует метод Intepret интерфейса IExpression
    /// </summary>
    public class LogicalExpression : IExpression
    {
        /// <summary> Левая часть выражения </summary>
        private readonly IExpression _left;

        /// <summary> Правая часть выражения </summary>
        private readonly IExpression _right;

        /// <summary> Оператор </summary>
        private readonly Operation _operator;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="left"> левый операнд </param>
        /// <param name="right"> правй операнд </param>
        /// <param name="operator"> операция </param>
        public LogicalExpression(IExpression left, IExpression right, Operation @operator)
        {
            _left = left;
            _right = right;
            _operator = @operator;
        }

        /// <summary>
        /// Метод для интерпретации контекста
        /// </summary>
        /// <param name="context"> Контекст </param>
        /// <returns> результат интерпретации </returns>
        /// <exception cref="NotImplementedException"> Исключение распознавания оператора </exception>
        public bool Interpret(Context context)
        {
            return _operator switch
            {
                Operation.AND => _left.Interpret(context) && _right.Interpret(context),
                Operation.OR => _left.Interpret(context) || _right.Interpret(context),
                _ => throw new NotImplementedException("Оператор не распознан!")
            };
        }
    }
}
