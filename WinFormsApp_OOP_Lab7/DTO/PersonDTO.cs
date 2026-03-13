using WinFormsApp_OOP_Lab7.Model;

namespace WinFormsApp_OOP_Lab7.DTO
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
        /// Пол модели
        /// </summary>
        public string? Gender { get; set; }

        /// <summary>
        /// Имя модели
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Возраст модели
        /// </summary>
        public int Age { get; set; }


    }
}
