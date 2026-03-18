using System.ComponentModel;
using WinFormsApp_OOP_Lab8.Model;

namespace WinFormsApp_OOP_Lab8.Utils
{
    /// <summary>
    /// Утилитный класс для генерации случайных объектов Person
    /// </summary>
    public class PersonRandomGenerator
    {
        /// <summary> Статический объект Random для генерации случайных значений </summary>
        private static readonly Random _RND = new();

        /// <summary> Статический массив мужских имён </summary>
        private static string[] _NAMES =
        {
            "Максим", "Михаил", "Андрей", "Александр", "Артём", "Павел", "Вадим", "Иван",
            "Елизавета", "Екатерина", "София", "Александра", "Евгения", "Наталья", "Елена", "Ольга"
        };

        /// <summary> Статический массив женских имён </summary>
        private static Dictionary<string, string[]> _COUNTRY_CITY = new()
        {
            {"Россия", ["Москва", "Пенза", "Ростов", "Самара", "Саранск", "Владивосток"] },
            {"Китай", ["Пекин", "Шанхай"] }
        };

        /// <summary>
        /// Статический метод для получения случайного имени
        /// </summary>
        /// <returns> Случайное мужское имя </returns>
        private static string GetRandomName()
        {
            var value = _NAMES.GetValue(_RND.Next(_NAMES.Length));
            return value as string ?? throw new ArgumentNullException(nameof(_NAMES));
        }

        /// <summary>
        /// Статический метод для получения случайной страны
        /// </summary>
        /// <param name="index"> Индекс случайной страны </param>
        /// <returns> Случайная страна </returns>
        private static string GetRandomCountry(out int index)
        {
            index = _RND.Next(_COUNTRY_CITY.Count);
            return _COUNTRY_CITY.Keys.ElementAt(index);
        }

        /// <summary>
        /// Статический метод для получения случайного города
        /// </summary>
        /// <param name="countryIndex"> индекс страны </param>
        /// <returns> Случайный город для страны заданного индекса </returns>
        private static string GetRandomCity(int countryIndex)
        {
            string[] currentValues = _COUNTRY_CITY.Values.ElementAt(countryIndex);
            var value = currentValues.GetValue(_RND.Next(currentValues.Length));
            return value as string ?? throw new ArgumentNullException(nameof(_COUNTRY_CITY));
        }

        /// <summary>
        /// Статический метод для генерации случайного объекта Person
        /// </summary>
        /// <returns> Случайный объект Person </returns>
        public static Person CreateRandomPerson()
        {
            string name = GetRandomName();
            string country = GetRandomCountry(out int index);
            string city = GetRandomCity(index);
            return new Person(name, new Address(country, city));
        }

        /// <summary>
        /// Метод для возвращения всех людей
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static List<Person> GetPersons(int count = 100)
        {
            if (count <= 0)
                throw new ArgumentException($"Невозможно создать список заданной длины: {count}");

            List<Person> persons = [];
            for (int i = 0; i < count; i++)
            {
                persons.Add(CreateRandomPerson());
            }
            return persons;
        }
    }
}
