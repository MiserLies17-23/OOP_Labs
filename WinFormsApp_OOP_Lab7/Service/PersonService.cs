using WinFormsApp_OOP_Lab7.DTO;
using WinFormsApp_OOP_Lab7.Model;
using WinFormsApp_OOP_Lab7.Repository;
using WinFormsApp_OOP_Lab7.Utils;

namespace WinFormsApp_OOP_Lab7.Service
{
    public class PersonService
    {
        private PersonRepository _repository;

        public PersonService()
        {
            _repository = new();
        }

        public void Add(Gender gender, string name, int age)
        {
            Validator.NameValidation(name);
            Validator.AgeValidation(age);

            Person person = new(gender, name, age);
            _repository.Add(person);
        }

        public Person GetPersonById(int id)
        {
            if (id >= 0 && id < _repository.GetCount())
                return _repository.GetById(id);
            throw new ArgumentException("Указан неверный Id!");
        }

        public void Update(int id, Gender gender, string name, int age)
        {
            if (id < 0 || id >= _repository.GetCount())
                throw new ArgumentException("Указан неверный Id!");
            Person editPerson = _repository.GetById(id);

            Validator.NameValidation(name);
            Validator.AgeValidation(age);

            editPerson.Gender = gender;
            editPerson.Name = name;
            editPerson.Age = age;
        }

        public void Delete(int id)
        {
            if (id >= 0 && id < _repository.GetCount())
                _repository.Delete(id);
            else
                throw new ArgumentException("Указан неверный Id!");
        }

        public List<Person> GetAll()
        {
            return _repository.GetAll() 
                ?? [];        
        }
    }
}
