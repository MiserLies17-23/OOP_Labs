namespace WinFormsApp_OOP_Lab1.Exceptions
{
    /// <summary>
    /// Класс для обработки ошибок памяти
    /// Наследует от OutOfMemoryException
    /// </summary>
    public class MemoryException : OutOfMemoryException
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public MemoryException() : base("Переполнение памяти объектами класса Person!") { }
    }
}
