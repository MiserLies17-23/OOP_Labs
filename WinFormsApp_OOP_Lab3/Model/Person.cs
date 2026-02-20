using WinFormsApp_OOP_Lab3.Utils;

namespace WinFormsApp_OOP_Lab3.Model
{
    public class Person : IPersonCloneable
    {
        /// <summary> Пол человека </summary>
        private Gender _gen;

        /// <summary> Имя человека </summary>
        private string _name;

        /// <summary> Рост человека </summary>
        private double _height;

        /// <summary> Вес человека </summary>
        private double _width;

        /// <summary> Адрес проживания человека </summary>
        private Address _address;

        /// <summary> Возраст человека </summary>
        private int _age;

        /// <summary> Список клонированных объектов </summary>
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
        /// Свойство для адреса объекта
        /// </summary>
        public Address Address
        {
            get => _address;
            set => _address = value;
        }

        /// <summary>
        /// Свойстыо для списка клонированных объектов
        /// </summary>
        public static List<Person> Persons {get => _persons; private set => _persons = value; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="gen"> пол </param>
        /// <param name="name"> имя </param>
        /// <param name="height"> рост </param>
        /// <param name="width"> вес </param>
        /// <param name="country"> страна </param>
        /// <param name="city"> город </param>
        /// <param name="age"> возраст </param>
        public Person(Gender gen, string name, double height, double width, Address address, int age)
        {
            Gen = gen;
            Name = name;
            Height = height;
            Width = width;
            Address = address;
            Age = age;
        }

        /// <summary>
        /// Метод для вывода пола
        /// </summary>
        /// <returns> строка - пол человека </returns>
        public string GetGenderToString()
        {
            if (Gen == Gender.MALE)
                return "Муж";
            return "Жен";
        }

        /// <summary>
        /// Переопределённый метод ToString() для класса
        /// </summary>
        /// <returns> имя человека </returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Метод неглубокого копирования
        /// Определяется наследуемым интерфейсом
        /// </summary>
        /// <returns> ссылака на текущий объект </returns>
        public IPersonCloneable ShallowCopy()
        {
            Person clonePerson = (Person)MemberwiseClone();
            Persons.Add(clonePerson);
            return clonePerson;
        }

        /// <summary>
        /// Метод для глубокого копирования
        /// Определяется наследуемым интерфейсом
        /// </summary>
        /// <returns> клонированный объект </returns>
        public IPersonCloneable DeepClone()
        {
            Person clonePerson = new(
                this.Gen,
                new string(this.Name),
                this.Height,
                this.Width,
                new Address(this.Address),
                this.Age);
            Persons.Add(clonePerson);
            return clonePerson;
        }
    }
}
