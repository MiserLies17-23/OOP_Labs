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
        public IPersonCloneable DeepClone();

        /// <summary>
        /// Метод для неглубокго клонирования 
        /// </summary>
        /// <returns> клонированный объект </returns>
        public IPersonCloneable ShallowClone();
    }
}
