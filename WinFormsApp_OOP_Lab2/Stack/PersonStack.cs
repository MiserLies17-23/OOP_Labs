using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab2
{
    public delegate void StackChanged(string message);
    public class PersonStack : Stack<Person>
    {
        public Stack<Person> Stack { get; set; }

        public event StackChanged? Add;

        public event StackChanged? Remove;

        public PersonStack()
        {
            Stack = new();
        }

        public PersonStack(Stack<Person> stack)
        {
            Stack = stack;
        }

        public PersonStack(int size)
        {
            Stack = (Stack<Person>)new(size);
        }

        public void AddItem(Person p)
        {
            Stack.Push(p);
            Add?.Invoke($"добавлен элемент {p}");
        }

        public void RemoveItem()
        {
            Person firstPerson = Stack.Pop();
            Remove?.Invoke($"удалён элемент {firstPerson}");
        }
    }
}
