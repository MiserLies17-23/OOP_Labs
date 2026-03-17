using WinFormsApp_OOP_Lab8.DTO;
using WinFormsApp_OOP_Lab8.Model;
using WinFormsApp_OOP_Lab8.Utils;
using WinFormsApp_OOP_Lab8.View;

namespace WinFormsApp_OOP_Lab8.Presenter
{
    public class PersonPresenter
    {
        private readonly List<Person> _persons;

        private readonly IView _view;

        public PersonPresenter(IView view)
        {
            _persons = PersonRandomGenerator.GetPersons();
            _view = view;

            GetPersonsDTO();
            _view.AddPersonEvent += OnAddPerson;
            _view.EditPersonEvent += OnEditPerson;
            _view.DeletePersonEvent += OnDeletePerson;
        }

        private void OnAddPerson(string name, string city, string country)
        {
            Validator.StringParamValidation(name);
            Validator.StringParamValidation(city);
            Validator.StringParamValidation(country);

            Person person = new(name, new Address(city, country));
            _persons.Add(person);

            GetPersonsDTO();
        }

        private void OnDeletePerson(int id)
        {
            if (id < 0 || id >= _persons.Count)
                throw new ArgumentException("Неверное значение id!");
            _persons.Remove(_persons[id]);

            GetPersonsDTO();
        }

        public void OnEditPerson(int id, string name, string city, string country)
        {
            if (id < 0 || id >= _persons.Count)
                throw new ArgumentException("Неверное значение id!");

            Validator.StringParamValidation(name);
            Validator.StringParamValidation(city);
            Validator.StringParamValidation(country);

            _persons[id].Name = name;
            _persons[id].Address.City = city;
            _persons[id].Address.Country = country;

            GetPersonsDTO();
        }

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
