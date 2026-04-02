
using WinFormsApp_OOP_Lab8.Utils;

namespace WinFormsApp_OOP_Lab8.Model
{
    /// <summary>
    /// Класс, представляющий адрес проживания человека
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Свойство для страны проживания
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Свойство для города проживания
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Address()
        {
            Country = "Неизвестна";
            City = "Неизвестен";
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="country"> страна проживания </param>
        /// <param name="city"> город проживания </param>
        public Address(string country, string city) : this()
        {
            Country = country;
            City = city;
        }
    }
}
