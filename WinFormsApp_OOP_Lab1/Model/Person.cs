using WinFormsApp_OOP_Lab1.Exceptions;
using WinFormsApp_OOP_Lab1.Utils;

namespace WinFormsApp_OOP_Lab1.Model
{
    /// <summary>
    /// Класс Человек
    /// </summary>
    public class Person
    {
        // Статическое поле для подсчёта количества созданных объектов
        private static int _count = 0;

        // Список для хранения объектов класса
        private static List<Person> _persons = [];

        // Пол человека
        private Gender _gen;

        // Имя человека
        private string _name;

        // Рост человека
        private double _height;

        // Вес человека
        private double _width;

        // Город проживания человека
        private string _city;

        // Страна проживания человека
        private string _country;

        // Возраст человека
        private int _age;

        /// <summary>
        /// Свойство для подсчёта количества созданных объектов
        /// </summary>
        public static int Count { get => _count; private set => _count = value; }

        /// <summary>
        /// Свойство для пола объекта
        /// </summary>
        public Gender Gen { get => _gen; set => _gen = value;}

        /// <summary>
        /// Свойство для имени объекта
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Validator.StringParamValidation(value, nameof(Name)); 
                _name = value;
            }
        }

        /// <summary>
        /// Свойство для роста объекта
        /// </summary>
        public double Height
        {
            get => _height;
            set
            {
                Validator.HeightValidation(value);
                _height = value;
            }
        }

        /// <summary>
        /// Свойство для веса объекта
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.WidthValidation(value);
                _width = value;

            }
        }

        /// <summary>
        /// Свойство для возраста объекта
        /// </summary>
        public int Age
        {
            get => _age;
            set
            {
                Validator.AgeValidation(value);
                _age = value;
            }
        }

        /// <summary>
        /// Свойство для страны объекта
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                Validator.StringParamValidation(value, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Свойство для города проживания объекта
        /// </summary>
        public string City 
        { 
            get => _city;
            set
            {
                Validator.StringParamValidation(value, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Свойство для списка созданных объектов 
        /// </summary>
        public static List<Person> Persons
        {
            get => _persons;
            set
            {
                if (value.Count > 2_000_000)
                    throw new MemoryException();
                _persons = value;
            }
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Person()
        {
            Gen = Gender.MALE;
            Name = "Undefinded";
            Height = 170;
            Width = 65;
            Age = 20;
            Country = "Undefinded"!;
            City = "Undefinded"!;
            Count++;
            Persons.Add(this);
        }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="gender"> Пол человека </param>
        public Person(Gender gender) : this()
        {
            Gen = gender;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="gender"> Пол человека </param>
        /// <param name="name"> Имя </param>
        public Person(Gender gender, string name) : this()
        {
            Gen = gender;
            Name = name;
        }

        /// <summary>
        /// Конструктор с количеством параметров, равным количеству полей класса
        /// </summary>
        /// <param name="gender"> Пол человека </param>
        /// <param name="name"> Имя </param>
        /// <param name="height"> Рост </param>
        /// <param name="width"> Вес </param>
        /// <param name="age"> Возраст </param>
        /// <param name="country"> Страна </param>
        /// <param name="city"> Город проживания </param>
        public Person(Gender gender, string name, double height, double width, int age,
            string country, string city) : this()
        {
            Gen = gender;
            Name = name;
            Height = height;
            Width = width;
            Age = age;
            Country = country;
            City = city;
        }

        /// <summary>
        /// Метод для вывода пола человка
        /// </summary>
        /// <returns> Пол человека в формате строки </returns>
        public string GetMaleToString()
        {
            if (Gen == Gender.FEMALE)
                return "Жен";
            return "Муж";
        }

        /// <summary>
        /// Переопределённый метод ToString() для всего класса
        /// </summary>
        /// <returns> Имя объекта класса в формате строки </returns>
        public override string ToString()
        {
            return Name;
        }
    }
}