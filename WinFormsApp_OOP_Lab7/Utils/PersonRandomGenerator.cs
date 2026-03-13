using WinFormsApp_OOP_Lab7.Model;

namespace WinFormsApp_OOP_Lab7.Utils
{
    /// <summary>
    /// Статический утилитный класс для генерации случайного объекта Person
    /// </summary>
    public static class PersonRandomGenerator
    {
        /// <summary> Статический объект Random для генерации случайных числовых значений </summary>
        private static readonly Random _RND = new();

        /// <summary> Статический массив возможных значений пола человека </summary>
        private static readonly Array _GENDERS = Enum.GetValues(typeof(Gender));
        
        /// <summary> Статический массив мужских имён </summary>
        private static readonly string[] _MALE_NAMES =
        {
            "Максим", "Михаил", "Андрей", "Александр", "Артём", "Павел", "Вадим", "Иван"
        };

        /// <summary> Статический массив женских имён </summary>
        private static readonly string[] _FEMALE_NAMES =
        {
            "Елизавета", "Екатерина", "София", "Александра", "Евгения", "Наталья", "Елена", "Ольга"
        };

        /// <summary>
        /// Статический метод для получения случайного пола
        /// </summary>
        /// <returns> Случайный пол человека </returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static Gender GetRandomGender()
        {
            var value = _GENDERS.GetValue(_RND.Next(_GENDERS.Length));
            return value is Gender gender ? gender : throw new ArgumentNullException(nameof(_GENDERS));
        }

        /// <summary>
        /// Статический метод для получения случайного мужского имени
        /// </summary>
        /// <returns> Случайное мужское имя </returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static string GetRandomMaleName()
        {
            var value = _MALE_NAMES.GetValue(_RND.Next(_MALE_NAMES.Length));
            return value as string ?? throw new ArgumentNullException(nameof(_MALE_NAMES));
        }

        /// <summary>
        /// Статический метод для получения случайного женского имени
        /// </summary>
        /// <returns> Случайное женское имя </returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static string GetRandomFemaleName()
        {
            var value = _FEMALE_NAMES.GetValue(_RND.Next(_FEMALE_NAMES.Length));
            return value as string ?? throw new ArgumentNullException(nameof(_FEMALE_NAMES));
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
        /// Статический метод для генерации случайного объекта Person
        /// </summary>
        /// <returns> Случайный объект Person </returns>
        public static Person CreateRandomPerson()
        {
            Gender gen = GetRandomGender();
            string name = gen == Gender.MALE ? GetRandomMaleName() : GetRandomFemaleName();
            int age = GetRandomAge();
            return new Person(gen, name, age);
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
