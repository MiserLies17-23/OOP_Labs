using WinFormsApp_OOP_Lab7.Model;

namespace WinFormsApp_OOP_Lab7.Repository
{
    /// <summary>
    /// Репозиторий объектов Person
    /// Реализует методы IPersonRepository
    /// </summary>
    public class PersonRepository : IPersonRepository
    {
        /// <summary> Список объектов Person </summary>
        private List<Person> _persons;

        /// <summary> Id последнего человека в списке </summary>
        private int _lastId;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PersonRepository()
        {
            _persons = [];
            _lastId = 0;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="persons"> Список объектов Person </param>
        public PersonRepository(List<Person> persons)
        {
            _persons = persons;
            _lastId = persons.Count;
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
        public Person? GetById(int id)
        {

            return _persons.FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Метод для добавления нового объекта Person
        /// </summary>
        /// <param name="person"> Объект Person </param>
        public void Add(Person person)
        {
            person.Id = _lastId++;
            _persons.Add(person);
        }

        /// <summary>
        /// Метод для обновления объекта Person
        /// </summary>
        /// <param name="id"> Id </param>
        /// <param name="person"> Объект Person </param>
        public void Update(int id, Person person)
        {
            _persons[id] = person;
        }

        /// <summary>
        /// Метод для удаления объекта Person по Id
        /// </summary>
        /// <param name="id"> Id </param>
        public void Delete(int id)
        {
            var person = GetById(id);
            if (person != null)
                _persons.Remove(person);
        }

        /// <summary>
        /// Метод для получения длины списка
        /// </summary>
        /// <returns> Длина списка </returns>
        public int GetLastId()
        {
            return _lastId;
        }
    }
}
