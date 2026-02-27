namespace WinFormsApp_OOP_Lab5.Interpreter
{
    /// <summary>
    /// Интерфейс выражения
    /// </summary>
    public interface IExpression
    {
        /// <summary>
        /// Метод интерпретации контекста
        /// </summary>
        /// <param name="context"> контекст </param>
        /// <returns> результат интерпретации </returns>
        public bool Interpret(Context context);
    }
}
