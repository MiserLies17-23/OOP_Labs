using WinFormsApp_OOP_Lab7.DTO;
using WinFormsApp_OOP_Lab7.Model;
using WinFormsApp_OOP_Lab7.Service;

namespace WinFormsApp_OOP_Lab7.Controller
{
    /// <summary>
    /// Контроллер для работы с моделью
    /// Связывает view (форму) и model (человека) компоненты
    /// </summary>
    public class PersonController
    {
        /// <summary>
        /// Сервис для реализации логики работы с Person
        /// </summary>
        private PersonService _personService;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PersonController()
        {
            _personService = new();
        }

        /// <summary>
        /// Метод для получения всех объектов Person
        /// </summary>
        /// <returns> Список всех Person </returns>
        /// <exception cref="ArgumentNullException"> Исключение нулевого аргумента </exception>
        public List<PersonDTO> GetAllPersons()
        {
            var persons = _personService.GetAll()
                ?? throw new ArgumentNullException("Список пуст!");

            return persons.Select(p => new PersonDTO
            {
                Id = p.Id,
                Gender = p.Gender,
                Name = p.Name,
                Age = p.Age
            }).ToList();
        }

        /// <summary>
        /// Метод добавления нового Person в репозиторий
        /// </summary>
        /// <param name="gender"> Пол </param>
        /// <param name="name"> Имя </param>
        /// <param name="age"> Возраст </param>
        public void AddPerson(Gender gender, string name, int age)
        {
            _personService.Add(gender, name, age);
        }

        /// <summary>
        /// Метод для получения Person по Id
        /// </summary>
        /// <param name="id"> Id </param>
        /// <returns> Объект Person c заданным Id </returns>
        public PersonDTO GetPersonById(int id)
        {
            var person = _personService.GetPersonById(id);
            if (person == null) 
                return null;

            return new PersonDTO
            {
                Id = id,
                Gender = person.Gender,
                Name = person.Name,
                Age = person.Age
            };
        }

        /// <summary>
        /// Метод для обновления данных Person
        /// </summary>
        /// <param name="id"> Уникальный Id</param>
        /// <param name="gender"> Пол </param>
        /// <param name="name"> Имя </param>
        /// <param name="age"> Возраст </param>
        public void UpdatePerson(int id, Gender gender, string name, int age)
        {
            _personService.Update(id, gender, name, age);
        }

        /// <summary>
        /// Метод для удаления Person по Id
        /// </summary>
        /// <param name="id"> Id </param>
        public void DeletePerson(int id)
        {
            _personService.Delete(id);
        }
    }
}
