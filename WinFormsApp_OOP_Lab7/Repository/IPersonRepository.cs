using WinFormsApp_OOP_Lab7.Model;

namespace WinFormsApp_OOP_Lab7.Repository
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
        Person GetById(int id);
        void Add(Person person);
        void Delete(int id);
    }
}
