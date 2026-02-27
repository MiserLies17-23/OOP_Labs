namespace WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression
{
    /// <summary>
    /// Класс, представляющий диапазон возрастов
    /// </summary>
    public class AgeRange
    {
        /// <summary> Нижняя граница возраста</summary>
        public int Down { get; set; }

        /// <summary> Верхняя граница возраста </summary>
        public int Top { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public AgeRange()
        {
            Down = 0;
            Top = 0;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="down"> нижняя граница </param>
        /// <param name="top"> верхняя граница </param>
        public AgeRange(int down, int top)
        {
            Down = down;
            Top = top;
        }
    }
}
