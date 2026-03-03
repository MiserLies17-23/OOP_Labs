namespace WinFormsApp_OOP_Lab4.Models.PersonModel
{
    /// <summary>
    /// Класс Человек
    /// реализует функционал интерфейса IPerson
    /// </summary>
    public class Person : IPerson
    {
        /// <summary>
        /// Свойство - пол человека
        /// </summary>
        public Gender Gen {  get; set; }

        /// <summary>
        /// Свойство - имя человека
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Свойство - рост человека
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Свойство - вес человека
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Свойство - страна проживания
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Свойство - город проживания
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Свойство - возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="gen"> Пол </param>
        /// <param name="name"> Имя </param>
        /// <param name="height"> Рост </param>
        /// <param name="width"> Вес </param>
        /// <param name="country"> Страна </param>
        /// <param name="city"> Город </param>
        /// <param name="age"> Возраст </param>
        public Person (Gender gen, string name, double height, double width, string country, string city, int age)
        {
            Gen = gen;
            Name = name;
            Height = height;
            Weight = width;
            Country = country;
            City = city;
            Age = age;
        }

        /// <summary>
        /// Метод для вывода пола
        /// </summary>
        /// <returns> Строка - пол человека </returns>
        public string GetGenderToString()
        {
            return Gen == Gender.MALE ? "Муж" : "Жен";
        }

        /// <summary>
        /// Переопределенный метод ToString() для класса
        /// </summary>
        /// <returns> Имя человека </returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
