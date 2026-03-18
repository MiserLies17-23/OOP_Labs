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

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="view"> View-компонент </param>
        public PersonPresenter(IView view)
        {
            _persons = PersonRandomGenerator.GetPersons();
            _view = view;

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
            if (id < 0 || id >= _persons.Count)
                throw new ArgumentException("Неверное значение id!");
            _persons.Remove(_persons[id]);

            GetPersonsDTO();
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
            if (id < 0 || id >= _persons.Count)
                throw new ArgumentException("Неверное значение id!");

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
            _view.Persons = _persons.Select((p, index) => new PersonDTO
            {
                Id = index,
                Name = p.Name,
                Country = p.Address.Country,
                City = p.Address.City
            }).ToList();
        }
    }
}
