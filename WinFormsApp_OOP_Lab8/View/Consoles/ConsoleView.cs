using WinFormsApp_OOP_Lab8.DTO;

namespace WinFormsApp_OOP_Lab8.View.Consoles
{
    /// <summary>
    /// Консольный UI-компонент приложения
    /// Реализует интерфейс IView
    /// </summary>
    public class ConsoleView : IView
    {
        /// <summary> Список объектов PersonDTO </summary>
        private List<PersonDTO> _persons;

        /// <summary> Событий добавления нового объекта </summary>
        public event Action<string, string, string> AddPersonEvent;

        /// <summary> Событие изменения объекта </summary>
        public event Action<int, string, string, string> EditPersonEvent;

        /// <summary> Событие удаления объекта </summary>
        public event Action<int> DeletePersonEvent;

        /// <summary>
        /// Свойство для списка объектов
        /// </summary>
        public List<PersonDTO> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }
        
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ConsoleView()
        {
            _persons = new();
            AddPersonEvent = delegate { };
            EditPersonEvent = delegate { };
            DeletePersonEvent = delegate { };
        }

        /// <summary>
        /// Метод для вывода главного меню
        /// </summary>
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

        /// <summary>
        /// Главный метод работы UI-компонента
        /// </summary>
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

        /// <summary>
        /// Метод для добавления нового человека
        /// </summary>
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

        /// <summary>
        /// Метод лдя вывода содержимого репозитория
        /// </summary>
        private void ShowAllPersons()
        {
            foreach (PersonDTO person in _persons)
            {
                ShowPersonData(person);
            }
        }

        /// <summary>
        /// Метод для вывода информации о конкретном объекте
        /// </summary>
        /// <param name="person"> DTO объекта</param>
        private void ShowPersonData(PersonDTO person)
        {
            Console.Write($"\nId: {person.Id}, Имя: {person.Name}, страна: {person.Country}, город: {person.City}");
        }

        /// <summary>
        /// Метод для работы с пользователем по id
        /// </summary>
        /// <exception cref="ArgumentException"> Исключение неверного аргумента id </exception>
        private void GetPersonById()
        {
            Console.Write("\nВведите id: ");
            string? idString = Console.ReadLine();
            if (!int.TryParse(idString, out int id))
                throw new ArgumentException("id должен быть числом!");

            PersonDTO? person = _persons.FirstOrDefault(person => person.Id == id);
            if (person == null)
                throw new ArgumentException($"Объект с id {id} не найден!");

            ShowPersonData(person);
            PersonActivity(id, person);
        }

        /// <summary>
        /// Метод, инициирующий действия над объектом
        /// </summary>
        /// <param name="id"> Id </param>
        /// <param name="person"> Объект для взаимодействия </param>
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

        /// <summary>
        /// Метод для изменения данных объекта
        /// </summary>
        /// <param name="id"> id </param>
        /// <param name="person"> DTO объекта </param>
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

        /// <summary>
        /// Метод для удаления объекта по id
        /// </summary>
        /// <param name="id"> Id </param>
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
