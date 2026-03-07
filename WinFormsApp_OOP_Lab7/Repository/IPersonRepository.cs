using WinFormsApp_OOP_Lab7.Model;

namespace WinFormsApp_OOP_Lab7.Repository
{
    /// <summary>
    /// Интерфейс репозитория
    /// </summary>
    public interface IPersonRepository
    {
        /// <summary>
        /// Метод для получения всех объектов Person
        /// </summary>
        /// <returns> Список Person </returns>
        List<Person> GetAll();

        /// <summary>
        /// Метод для получения данных Person по Id
        /// </summary>
        /// <param name="id"> Id </param>
        /// <returns> Объект Person с заданным Id </returns>
        Person GetById(int id);

        /// <summary>
        /// Метод для добавления нового объекта Person
        /// </summary>
        /// <param name="person"> Объект Person </param>
        void Add(Person person);

        /// <summary>
        /// Метод для удаления объекта Person по Id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
