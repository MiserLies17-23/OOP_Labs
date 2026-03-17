
using WinFormsApp_OOP_Lab8.Utils;

namespace WinFormsApp_OOP_Lab8.Model
{
    /// <summary>
    /// Класс, представляющий адрес проживания человека
    /// </summary>
    public class Address
    {
        /// <summary> Страна проживания </summary>
        private string? _country;

        /// <summary> Город проживания </summary>
        private string? _city;

        /// <summary>
        /// Свойство для страны проживания
        /// </summary>
        public string Country
        {
            get => _country ?? "";
            set
            {
                Validator.StringParamValidation(value);
                _country = value;
            }
        }

        /// <summary>
        /// Свойство для города проживания
        /// </summary>
        public string City
        {
            get => _city ?? "";
            set
            {
                Validator.StringParamValidation(value);
                _city = value;
            }
        }

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

        /// <summary>
        /// Конструктор с параметром
        /// Глубокое копирование объекта
        /// </summary>
        /// <param name="address"> адрес </param>
        public Address(Address address) : this()
        {
            if (address == null)
                throw new ArgumentNullException(nameof(address));

            Country = address.Country;
            City = address.City;
        }
    }
}
