using WinFormsApp_OOP_Lab7.Model;

namespace WinFormsApp_OOP_Lab7.Repository
{
    public class PersonRepository : IPersonRepository
    {
        /// <summary> Список объектов Person </summary>
        private List<Person> _persons;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PersonRepository()
        {
            _persons = [];
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="persons"> Список объектов Person </param>
        public PersonRepository(List<Person> persons)
        {
            _persons = persons;
        }

        /// <summary>
        /// Метод для получения всех объектов Person
        /// </summary>
        /// <returns> Список Person </returns>
        public List<Person> GetAll()
        {
            return _persons;
        }

        /// <summary>
        /// Метод для получения данных Person по Id
        /// </summary>
        /// <param name="id"> Id </param>
        /// <returns> Объект Person с заданным Id </returns>
        public Person GetById(int id)
        {
            return _persons[id];
        }

        /// <summary>
        /// Метод для добавления нового объекта Person
        /// </summary>
        /// <param name="person"> Объект Person </param>
        public void Add(Person person)
        {
            person.Id = _persons.Count;
            _persons.Add(person);
        }

        /// <summary>
        /// Метод для удаления объекта Person по Id
        /// </summary>
        /// <param name="id"> Id </param>
        public void Delete(int id)
        {
            _persons.Remove(GetById(id));
        }

        /// <summary>
        /// Метод для получения длины списка
        /// </summary>
        /// <returns> Длина списка </returns>
        public int GetCount()
        {
            return _persons.Count;
        }
    }
}
