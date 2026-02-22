using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab2.Utils
{
    /// <summary>
    /// Статический утилитный класс для генерации случайных параметров объекта Person
    /// </summary>
    public static class RandomValuesGenerator
    {
        /// <summary> Статический объект Random для генерации случайных значений </summary>
        private static readonly Random _RND = new();

        /// <summary> Статический массив возможных значений пола человека </summary>
        private static readonly Array _GENDERS = Enum.GetValues(typeof(Gender));

        /// <summary> Статический массив мужских имён </summary>
        private static string[] _MALE_NAMES =
        { 
            "Максим", "Михаил", "Андрей", "Александр", "Артём", "Павел", "Вадим", "Иван"
        };

        /// <summary> Статический массив женских имён </summary>
        private static string[] _FEMALE_NAMES =
        {
            "Елизавета", "Екатерина", "София", "Александра", "Евгения", "Наталья", "Елена", "Ольга"
        };

        /// <summary> Статический массив женских имён </summary>
        private static Dictionary<string, string[]> _COUNTRY_CITY = new()
        {
            {"Россия", ["Москва", "Пенза", "Ростов", "Самара", "Саранск", "Владивосток"] },
            {"Китай", ["Пекин", "Шанхай"] }
        };

        /// <summary>
        /// Статический метод для получения случайного пола
        /// </summary>
        /// <returns> Случайный пол человека </returns>
        private static Gender GetRandomGender()
        {
            var value = _GENDERS.GetValue(_RND.Next(_GENDERS.Length));
            return value is Gender gender ? gender : throw new NullReferenceException();
        }

        /// <summary>
        /// Статический метод для получения случайного мужского имени
        /// </summary>
        /// <returns> Случайное мужское имя </returns>
        private static string GetRandomMaleName()
        {
            var value = _MALE_NAMES.GetValue(_RND.Next(_MALE_NAMES.Length));
            return value as string ?? throw new ArgumentNullException(nameof(_MALE_NAMES));
        }

        /// <summary>
        /// Статический метод для получения случайного женского имени
        /// </summary>
        /// <returns> Случайное женское имя </returns>
        private static string GetRandomFemaleName()
        {
            var value = _FEMALE_NAMES.GetValue(_RND.Next(_FEMALE_NAMES.Length));
            return value as string ?? throw new ArgumentNullException(nameof(_FEMALE_NAMES));
        }

        /// <summary>
        /// Статический метод для получения случайного веса 
        /// </summary>
        /// <returns> Случайный вес </returns>
        private static double GetRamdomWidth()
        {
            return _RND.Next(1, 250);
        }

        /// <summary>
        /// Статический метод для получения случайного роста
        /// </summary>
        /// <returns> Случайный рост </returns>
        private static double GetRamdomHeight()
        {
            return _RND.Next(1, 250);
        }

        /// <summary>
        /// Статический метод для получения случайного возраста 
        /// </summary>
        /// <returns> Случайный возраст </returns>
        private static int GetRandomAge()
        {
            return _RND.Next(0, 100);
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
            Gender gen = GetRandomGender();
            string name = "";
            if (gen == Gender.MALE)
                name = GetRandomMaleName();
            else
                name = GetRandomFemaleName();
            double height = GetRamdomHeight();
            double width = GetRamdomWidth();
            int age = GetRandomAge();
            string country = GetRandomCountry(out int index);
            string city = GetRandomCity(index);
            return new Person(gen, name, height, width, age, country, city);
        }
    }
}
