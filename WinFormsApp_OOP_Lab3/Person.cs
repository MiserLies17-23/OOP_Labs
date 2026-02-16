using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace WinFormsApp_OOP_Lab3
{
    public class Person : IPersonCloneable
    {
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


        private static List<Person> _persons = new();

        /// <summary>
        /// Свойство для пола объекта
        /// </summary>
        public Gender Gen { get => _gen; set => _gen = value; }

        /// <summary>
        /// Свойство для имени объекта
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Validation.StringParamValidation(value, nameof(Name));
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
                Validation.HeightValidation(value);
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
                Validation.WidthValidation(value);
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
                Validation.AgeValidation(value);
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
                Validation.StringParamValidation(value, nameof(Country));
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
                Validation.StringParamValidation(value, nameof(City));
                _city = value;
            }
        }

        public static List<Person> Persons {get => _persons; private set => _persons = value; }

        public Person(Gender gen, string name, double height, double width, string country, string city, int age)
        {
            Gen = gen;
            Name = name;
            Height = height;
            Width = width;
            Country = country;
            City = city;
            Age = age;
        }

        public string GetGenderToString()
        {
            if (Gen == Gender.MALE)
                return "Муж";
            return "Жен";
        }

        public override string ToString()
        {
            return Name;
        }

        public object ShallowCopy()
        {
            Person clonePerson = this;
            return clonePerson;
        }

        public object DeepClone()
        {
            Person clonePerson = (Person)this.MemberwiseClone();
            return clonePerson;
        }
    }
}
