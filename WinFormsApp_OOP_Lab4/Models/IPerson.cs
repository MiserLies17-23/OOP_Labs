using WinFormsApp_OOP_Lab4.Models.PersonModel;

namespace WinFormsApp_OOP_Lab4.Models
{
    /// <summary>
    /// Общий интерфейс для базового объекта и его Proxy
    /// Определяет поведение proxy и базового класса
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Свойство - пол человека
        /// </summary>
        Gender Gen { get; set; }

        /// <summary>
        /// Свойство - имя человека
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Свойство - рост человека
        /// </summary>
        double Height { get; set; }

        /// <summary>
        /// Свойство - вес человека
        /// </summary>
        double Weight { get; set; }

        /// <summary>
        /// Свойство - страна проживания
        /// </summary>
        string Country { get; set; }

        /// <summary>
        /// Свойство - город проживания
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// Свойство - возраст
        /// </summary>
        int Age { get; set; }

        /// <summary>
        /// Метод для вывода пола
        /// </summary>
        /// <returns> строка - пол человека </returns>
        string GetGenderToString();

        /// <summary>
        /// Переопределённый метод ToString() для класса
        /// </summary>
        /// <returns> имя человека </returns>
        string ToString();
    }
}
