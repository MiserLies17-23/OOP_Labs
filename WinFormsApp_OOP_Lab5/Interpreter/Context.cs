using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Interpreter
{
    /// <summary>
    /// Класс контектса
    /// Представляет общую для интерпретации информацию
    /// </summary>
    public class Context
    {
        /// <summary>
        /// Свойство - текущий человек
        /// </summary>
        public Person CurrentPerson { get; set; }

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="currentPerson"> текущий человек </param>
        public Context(Person currentPerson)
        { 
            CurrentPerson = currentPerson;
        }
    }
}
