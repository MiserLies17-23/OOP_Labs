namespace WinFormsApp_OOP_Lab7.Model
{
    /// <summary>
    /// Модель предметной области
    /// Класс представления человека
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Пол человека
        /// </summary>
        public Gender Gender { get; set; }
        
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="gender"> Пол </param>
        /// <param name="name"> Имя </param>
        /// <param name="age"> Возраст </param>
        public Person(Gender gender, string name, int age)
        {
            Gender = gender;
            Name = name;
            Age = age;
        }
    }
}
