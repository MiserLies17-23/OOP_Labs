namespace WinFormsApp_OOP_Lab8.Model
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
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес проживания
        /// </summary>
        public Address Address {  get; set; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="gender"> Пол </param>
        /// <param name="name"> Имя </param>
        /// <param name="age"> Возраст </param>
        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }
    }
}