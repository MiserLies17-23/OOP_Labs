using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Interpreter
{
    public class Context
    {
        public Person CurrentPerson { get; set; }

        public Context(Person currentPerson)
        { 
            CurrentPerson = currentPerson;
        }
    }
}
