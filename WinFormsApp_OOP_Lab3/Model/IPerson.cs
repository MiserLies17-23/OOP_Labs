namespace WinFormsApp_OOP_Lab3.Model
{
    /// <summary>
    /// Интерфейс для реализации поведенческого паттерна Prototype
    /// </summary>
    public interface IPersonCloneable
    {
        /// <summary>
        /// Метод для глубокого клонирования 
        /// </summary>
        /// <returns> Клонированный объект </returns>
        public object DeepClone();

        /// <summary>
        /// Метод для неглубокго клонирования 
        /// </summary>
        /// <returns> клонированный объект </returns>
        public object ShallowCopy();
    }
}
