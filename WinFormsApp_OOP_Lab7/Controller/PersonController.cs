using WinFormsApp_OOP_Lab7.DTO;
using WinFormsApp_OOP_Lab7.Model;
using WinFormsApp_OOP_Lab7.Service;

namespace WinFormsApp_OOP_Lab7.Controller
{
    public class PersonController
    {
        private PersonService _personService;

        public PersonController()
        {
            _personService = new();
        }

        public List<PersonDTO> GetAllPersons()
        {
            List<Person> persons = _personService.GetAll()
                ?? throw new ArgumentNullException("Список пуст!");
            return (List<PersonDTO>)persons.Select(p => new PersonDTO
            {
                Id = p.Id,
                Gender = p.Gender,
                Name = p.Name,
                Age = p.Age
            }).ToList();
        }

        public void AddPerson(Gender gender, string name, int age)
        {
            _personService.Add(gender, name, age);
        }

        public PersonDTO GetPersonById(int id)
        {
            Person person = _personService.GetPersonById(id);
            return new PersonDTO
            {
                Id = id,
                Gender = person.Gender,
                Name = person.Name,
                Age = person.Age
            };
        }

        public void UpdatePerson(int id, Gender gender, string name, int age)
        {
            _personService.Update(id, gender, name, age);
        }

        public void DeletePerson(int id)
        {
            _personService.Delete(id);
        }
    }
}
