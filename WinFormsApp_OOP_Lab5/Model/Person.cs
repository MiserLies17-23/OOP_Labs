namespace WinFormsApp_OOP_Lab5.Model
{
    /// <summary>
    /// Класс человек
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Свойство - пол человека
        /// </summary>
        public Gender Gen { get; set; }

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
        /// Свойство - профессия
        /// </summary>
        public Profession Profession { get; set; }

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
        /// <param name="profession"> профессия </param>
        /// <param name="age"> возраст </param>
        public Person(Gender gen, string name, double height, double width, string country, Profession profession, int age)
        {
            Gen = gen;
            Name = name;
            Height = height;
            Weight = width;
            Country = country;
            Profession = profession;
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
        /// Метод для вывода профессии
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public string GetProfessionToString()
        {
            return Profession switch
            {
                Profession.PROGRAMMER => "Программист",
                Profession.BUILDER => "Строитель",
                Profession.TEACHER => "Учитель",
                Profession.COOK => "Повар",
                Profession.ACCOUNTANT => "Бухгалтер",
                Profession.HAIRDRESSER => "Парикмахер",
                _ => throw new ArgumentException("Профессия не распознана!")
            };
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
