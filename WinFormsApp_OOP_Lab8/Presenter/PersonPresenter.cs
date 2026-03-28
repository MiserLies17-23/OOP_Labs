using WinFormsApp_OOP_Lab8.DTO;
using WinFormsApp_OOP_Lab8.Model;
using WinFormsApp_OOP_Lab8.Utils;
using WinFormsApp_OOP_Lab8.View;

namespace WinFormsApp_OOP_Lab8.Presenter
{
    /// <summary>
    /// Класс презентера для предметной области Человек
    /// Содержит основную логику взаимодействия с моделью и обработку событий view
    /// </summary>
    public class PersonPresenter
    {
        /// <summary> Список всех объектов класса Person </summary>
        private readonly List<Person> _persons;

        /// <summary> View-компонент </summary>
        private readonly IView _view;

        /// <summary> Поле для назначения id объектов </summary>
        private int _nextId;

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="view"> View-компонент </param>
        public PersonPresenter(IView view)
        {
            _persons = PersonRandomGenerator.GetPersons();
            _view = view;
            _nextId = _persons.Count > 0 ? _persons.Max(p => p.Id) + 1 : 0;

            GetPersonsDTO();
            _view.AddPersonEvent += OnAddPerson;
            _view.EditPersonEvent += OnEditPerson;
            _view.DeletePersonEvent += OnDeletePerson;
        }

        /// <summary>
        /// Метод для добавления нового объекта
        /// </summary>
        /// <param name="name"> Имя </param> 
        /// <param name="country"> Страна </param>
        /// <param name="city"> Город </param>
        private void OnAddPerson(string name, string country, string city)
        {
            Validator.StringParamValidation(name);
            Validator.StringParamValidation(country);
            Validator.StringParamValidation(city);

            Person person = new(name, new Address(country, city));
            person.Id = _nextId++;
            _persons.Add(person);

            GetPersonsDTO();
        }

        /// <summary>
        /// Метод для удаления обхекта по id
        /// </summary>
        /// <param name="id"> Id </param>
        /// <exception cref="ArgumentException"> Исключение неверного аргумента </exception>
        private void OnDeletePerson(int id)
        {
            var person = _persons.FirstOrDefault(p => p.Id == id);
            if (person != null)
            {
                _persons.Remove(person);
                GetPersonsDTO();
            }
            else
            {
                throw new ArgumentException($"Человек с Id {id} не найден");
            }
        }

        /// <summary>
        /// Метод для изменения данных объектов
        /// </summary>
        /// <param name="id"> Id </param>
        /// <param name="name"> Имя </param> 
        /// <param name="country"> Страна </param>
        /// <param name="city"> Город </param>
        /// <exception cref="ArgumentException"></exception>
        public void OnEditPerson(int id, string name, string country, string city)
        {
            var person = _persons.FirstOrDefault(p => p.Id == id);
            if (person == null)
                throw new ArgumentException($"Человек с Id {id} не найден");

            Validator.StringParamValidation(name);
            Validator.StringParamValidation(country);
            Validator.StringParamValidation(city);

            _persons[id].Name = name;
            _persons[id].Address.Country = country;
            _persons[id].Address.City = city;

            GetPersonsDTO();
        }

        /// <summary>
        /// Метод для обновления списка объектов view-компонента
        /// </summary>
        private void GetPersonsDTO()
        {
            _view.Persons = _persons.Select(p => new PersonDTO
            {
                Id = p.Id,
                Name = p.Name,
                Country = p.Address.Country,
                City = p.Address.City
            }).ToList();
        }
    }
}
