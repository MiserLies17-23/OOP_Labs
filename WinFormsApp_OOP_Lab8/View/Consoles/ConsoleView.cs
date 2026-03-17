using WinFormsApp_OOP_Lab8.DTO;

namespace WinFormsApp_OOP_Lab8.View.Consoles
{
    public class ConsoleView : IView
    {
        private List<PersonDTO> _persons;

        public event Action<string, string, string> AddPersonEvent;

        public event Action<int, string, string, string> EditPersonEvent;

        public event Action<int> DeletePersonEvent;

        public List<PersonDTO> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }
        
        public ConsoleView()
        {
            _persons = new();
            AddPersonEvent = delegate { };
            EditPersonEvent = delegate { };
            DeletePersonEvent = delegate { };
        }

        private void MainMenu()
        {
            ConsoleManager.Show();
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Просмотреть содержимое репозитория");
            Console.WriteLine("2. Выбрать человека по id");
            Console.WriteLine("3. Добавить нового человека");
            Console.WriteLine("4. Очистить консоль");
            Console.WriteLine("0. Выйти");
            Console.Write("Выберите действие: ");
        }

        public void Run()
        {
            MainMenu();
            string? input = Console.ReadLine();

            while (input != null || input != "0")
            {
                try
                {
                    switch (input)
                    {
                        case "1":
                            ShowAllPersons();
                            break;
                        case "2":
                            GetPersonById();
                            break;
                        case "3":
                            AddNewPerson();
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("История была очищена");
                            break;
                        case "0":
                            ConsoleManager.Close();
                            return;
                        default:
                            Console.WriteLine("Действие не распознано!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                MainMenu();
                input = Console.ReadLine();
            }
            ConsoleManager.Close();
        }

        private void AddNewPerson()
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();

            Console.Write("Введите страну: ");
            var country = Console.ReadLine();

            Console.Write("Введите город: ");
            var city = Console.ReadLine();

            AddPersonEvent?.Invoke(name!, country!, city!);
            Console.WriteLine("Человек успешно добавлен!");
        }

        private void ShowAllPersons()
        {
            foreach (PersonDTO person in _persons)
            {
                ShowPersonData(person);
            }
        }

        public void ShowPersonData(PersonDTO person)
        {
            Console.Write($"\nId: {person.Id}, Имя: {person.Name}, страна: {person.Country}, город: {person.City}");
        }

        private void GetPersonById()
        {
            Console.Write("\nВведите id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            PersonDTO person = _persons[id];
            ShowPersonData(person);
            PersonActivity(id, person);
        }

        private void PersonActivity(int id, PersonDTO person)
        {
            Console.WriteLine("\nВыберите действие над человеком:");
            Console.WriteLine("1. Изменить");
            Console.WriteLine("2. Удалить");
            Console.WriteLine("0. Назад");
            Console.Write("Выберите действие: ");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    EditPerson(id, person);
                    break;
                case "2":
                    DeletePerson(id);
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Действие не распознано!");
                    break;
            }
        }

        private void EditPerson(int id, PersonDTO person)
        {
            Console.WriteLine("\nВведите новые значения. Если хотите оставить текущие, нажмите Enter:");

            Console.WriteLine($"Теущее имя: {person.Name}");
            Console.Write($"Новое значение: ");
            var nameVar = Console.ReadLine();
            var name = nameVar == "" ? person.Name : nameVar;

            Console.WriteLine($"Теущая стран: {person.Country}");
            Console.Write($"Новое значение: ");
            var countryVar = Console.ReadLine();
            var country = countryVar == "" ? person.Country : countryVar;

            Console.WriteLine($"Теущий город: {person.City}");
            Console.Write($"Новое значение: ");
            var cityVar = Console.ReadLine();
            var city = cityVar == "" ? person.City : cityVar;

            EditPersonEvent?.Invoke(id, name!, country!, city!);
            Console.WriteLine("Данные успешно обновлены!");
        }

        private void DeletePerson(int id)
        {
            Console.Write("\nВы уверены, что хотите удалить человека?");
            Console.WriteLine("Ваш выбор (д/н):");
            string? input = Console.ReadLine()?.ToLower();
            switch (input)
            {
                case "д":
                    DeletePersonEvent?.Invoke(id);
                    Console.WriteLine("Человек успешно удалён!");
                    break;
                case "н":
                    Console.WriteLine("Отмена удаления");
                    break;
                default:
                    Console.WriteLine("Действие не распознано!");
                    break;
            }
        }
    }
}
