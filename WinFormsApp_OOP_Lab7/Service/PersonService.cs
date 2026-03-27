using WinFormsApp_OOP_Lab7.Model;
using WinFormsApp_OOP_Lab7.Repository;
using WinFormsApp_OOP_Lab7.Utils;

namespace WinFormsApp_OOP_Lab7.Service
{
    /// <summary>
    /// Сервис для работы с объектами Person
    /// Основной слой бизнес-логики
    /// </summary>
    public class PersonService
    {
        /// <summary> Репозиторий объектов Person </summary>
        private readonly PersonRepository _repository;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PersonService()
        {
            _repository = new(PersonRandomGenerator.GetPersons());
        }

        /// <summary>
        /// Метод для добавления нового объекта Person
        /// </summary>
        /// <param name="gender"> Пол </param>
        /// <param name="name"> Имя </param>
        /// <param name="age"> Возраст </param>
        public void Add(Gender gender, string name, int age)
        {
            Validator.NameValidation(name);
            Validator.AgeValidation(age);

            Person person = new(gender, name, age);
            
            _repository.Add(person);
        }

        /// <summary>
        /// Метод для получения объекта Person по Id
        /// </summary>
        /// <param name="id"> Id </param>
        /// <returns> Объект Person с заданным Id </returns>
        /// <exception cref="ArgumentException"> Исключение неверного аргумента </exception>
        public Person? GetPersonById(int id)
        {
            if (id >= 0 && id < _repository.GetLastId())
                return _repository.GetById(id);

            throw new ArgumentException("Указан неверный Id!");
        }

        /// <summary>
        /// Метод для обновления данных Person 
        /// </summary>
        /// <param name="id"> Id </param>
        /// <param name="gender"> Пол </param>
        /// <param name="name"> Имя </param>
        /// <param name="age"> Возраст </param>
        /// <exception cref="ArgumentException"> Исключение неверного аргумента </exception>
        public void Update(int id, Gender gender, string name, int age)
        {
            if (id < 0 || id >= _repository.GetLastId())
                throw new ArgumentException("Указан неверный Id!");

            Person? editPerson = _repository.GetById(id);
            if (editPerson == null)
                return;

            Validator.NameValidation(name);
            Validator.AgeValidation(age);

            editPerson.Gender = gender;
            editPerson.Name = name;
            editPerson.Age = age;

            _repository.Update(id, editPerson);
        }

        /// <summary>
        /// Метод для удаления Person по заданному Id
        /// </summary>
        /// <param name="id"> Id </param>
        /// <exception cref="ArgumentException"> Исключение неверного аргумента </exception>
        public void Delete(int id)
        {
            if (id < 0 || id >= _repository.GetLastId())
                throw new ArgumentException("Указан неверный Id!");
            
            var person = _repository.GetById(id);
            if (person != null)
                _repository.Delete(id);
        }

        /// <summary>
        /// Метод для получения всех объектов Person из репозитория
        /// </summary>
        /// <returns> Список всех объектов Person </returns>
        public List<Person> GetAll()
        {
            return _repository.GetAll() 
                ?? [];     
        }
    }
}
