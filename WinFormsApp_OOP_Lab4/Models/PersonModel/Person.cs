namespace WinFormsApp_OOP_Lab4.Models.PersonModel
{
    /// <summary>
    /// Класс Человек
    /// Реализует функционал интерфейса IPerson
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
        /// <param name="gen"> пол </param>
        /// <param name="name"> имя </param>
        /// <param name="height"> рост </param>
        /// <param name="width"> вес </param>
        /// <param name="country"> страна </param>
        /// <param name="city"> город </param>
        /// <param name="age"> возраст </param>
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
    }
}
