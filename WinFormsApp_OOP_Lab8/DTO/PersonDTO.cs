using WinFormsApp_OOP_Lab8.Model;

namespace WinFormsApp_OOP_Lab8.DTO
{
    /// <summary>
    /// DTO для представления данных модели
    /// </summary>
    public class PersonDTO
    {
        /// <summary>
        /// Id модели
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя модели
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Город проживания
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Страна проживания
        /// </summary>
        public string? Country { get; set; }

    }
}
