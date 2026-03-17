using WinFormsApp_OOP_Lab8.DTO;

namespace WinFormsApp_OOP_Lab8.View
{
    public interface IView
    {
        List<PersonDTO> Persons {get; set;}

        event Action<string, string, string> AddPersonEvent;

        event Action<int, string, string, string> EditPersonEvent;

        event Action<int> DeletePersonEvent;
    }
}
