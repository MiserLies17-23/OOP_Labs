using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab2.Stack
{
    /// <summary>
    /// Делегат для фиксации изменений в стэке
    /// </summary>
    /// <param name="message"> сообщение </param>
    public delegate void StackChanged(string message);

    /// <summary>
    /// Класс PersonStack - представляет стэк объектов Person
    /// </summary>
    public class PersonStack : Stack<Person>
    {
        /// <summary> Стэк объектов Person </summary>
        public Stack<Person> Stack { get; set; }

        /// <summary> Событие добавления элемента в стэк </summary>
        public event StackChanged? Add;

        /// <summary> Событие удаления элемента из стэка </summary>
        public event StackChanged? Remove;

        /// <summary>
        /// Конструкор по умолчанию
        /// </summary>
        public PersonStack()
        {
            Stack = new();
        }

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="stack"> стэк объектов Person </param>
        public PersonStack(Stack<Person> stack)
        {
            Stack = stack;
        }

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="size"> размера стэка </param>
        public PersonStack(int size)
        {
            Stack = new(size);
        }

        /// <summary>
        /// Метод для добавления элементов в стэк
        /// </summary>
        /// <param name="p"> добавляемый объект </param>
        public void AddItem(Person p)
        {
            Stack.Push(p);
            Add?.Invoke($"добавлен элемент {p}");
        }

        /// <summary>
        /// Метод для удаления объекта из стэка
        /// </summary>
        public void RemoveItem()
        {
            Person firstPerson = Stack.Pop();
            Remove?.Invoke($"удалён элемент {firstPerson}");
        }
    }
}
