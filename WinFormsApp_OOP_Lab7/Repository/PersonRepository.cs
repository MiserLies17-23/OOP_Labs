using WinFormsApp_OOP_Lab7.Model;

namespace WinFormsApp_OOP_Lab7.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> _persons;

        public PersonRepository()
        {
            _persons = [];
        }

        public PersonRepository(List<Person> persons)
        {
            _persons = persons;
        }

        public List<Person> GetAll()
        {
            return _persons;
        }

        public Person GetById(int id)
        {
            return _persons[id];
        }

        public void Add(Person person)
        {
            person.Id = _persons.Count;
            _persons.Add(person);
        }

        public void Delete(int id)
        {
            _persons.Remove(GetById(id));
        }

        public int GetCount()
        {
            return _persons.Count;
        }
    }
}
