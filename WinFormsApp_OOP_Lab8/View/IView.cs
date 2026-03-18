using WinFormsApp_OOP_Lab8.DTO;

namespace WinFormsApp_OOP_Lab8.View
{
    /// <summary>
    /// Интерфейс для view-компонентов приложения
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Свойство для списков объектов предметной области
        /// </summary>
        List<PersonDTO> Persons {get; set;}

        /// <summary>
        /// Событие добавления нового объекта
        /// </summary>
        event Action<string, string, string> AddPersonEvent;

        /// <summary>
        /// Событие изменения объекта
        /// </summary>
        event Action<int, string, string, string> EditPersonEvent;

        /// <summary>
        /// Событие удаления объекта
        /// </summary>
        event Action<int> DeletePersonEvent;
    }
}
