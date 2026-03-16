using WinFormsApp_OOP_Lab7.Controller;
using WinFormsApp_OOP_Lab7.DTO;
using WinFormsApp_OOP_Lab7.Model;

namespace WinFormsApp_OOP_Lab7.View.Consoles
{
    /// <summary>
    /// Консольный UI-компонент приложения
    /// </summary>
    public class ConsoleView
    {
        /// <summary> Контроллер для взаимодействия с моделью (реализация паттерна MVC) </summary>
        private readonly PersonController _personController;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public ConsoleView()
        {
            _personController = new();
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
        /// <exception cref="ArgumentException"> Исключение неверного аргумента </exception>
        private void AddNewPerson()
        {
            Console.Write("Введите имя: ");
            string? name = Console.ReadLine();

            Console.Write("Введите пол (м/ж): ");
            string? gen = Console.ReadLine()?.ToLower();
            Gender gender = gen == "м" ? Gender.MALE : gen == "ж" ? Gender.FEMALE : 
                throw new ArgumentException("Пол не распознан!");

            Console.Write("Введите возраст: ");
            string? ageString = Console.ReadLine();
            int age;
            if (!int.TryParse(ageString, out _))
                throw new ArgumentException("Возраст должен быть числом!");
            else
                age = Convert.ToInt32(ageString);

            _personController.AddPerson(gender, name!, age);
            Console.WriteLine("Человек успешно добавлен!");
        }

        /// <summary>
        /// Метод лдя вывода содержимого репозитория
        /// </summary>
        private void ShowAllPersons()
        {
            List<PersonDTO> persons = _personController.GetAllPersons() ?? [];
            foreach (PersonDTO person in persons)
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
            Console.Write($"\nИмя: {person.Name}, пол: {person.GetGenderToString()}, возраст: {person.Age}");
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

            PersonDTO person = _personController.GetPersonById(id);
            ShowPersonData(person);
            PersonActivity(id, person);
        }

        /// <summary>
        /// Метод, инициирующий действия над объектом
        /// </summary>
        /// <param name="id"></param>
        /// <param name="person"></param>
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
        /// <exception cref="ArgumentException"> Исключение неверного аргумента </exception>
        private void EditPerson(int id, PersonDTO person)
        {
            Console.WriteLine("\nВведите новые значения. Если хотите оставить текущие, нажмите Enter:");
            
            Console.WriteLine($"Теущий пол: {person.Gender}");
            Console.Write($"Новое значение (м/ж): ");
            string? gen = Console.ReadLine()?.ToLower();
            Gender gender = gen == "м" ? Gender.MALE : gen == "ж" ? Gender.FEMALE :
                gen == "" ? person.Gender : throw new ArgumentException("Пол не распознан!");
            
            Console.WriteLine($"Теущее имя: {person.Name}");
            Console.Write($"Новое значение: ");
            string? nameVar = Console.ReadLine();
            string? name = nameVar == "" ? person.Name : nameVar;
            
            Console.WriteLine($"Текущий возраст: {person.Age}");
            Console.Write($"Новое значение: ");
            string? ageString = Console.ReadLine();
            int age;
            if (ageString == "")
                age = person.Age;
            else if (!int.TryParse(ageString, out _))
                throw new ArgumentException("Возраст должен быть числом!");
            else
                age = Convert.ToInt32(ageString);

            _personController.UpdatePerson(id, gender, name!, age);
            Console.WriteLine("Данные успешно обновлены!");
        }

        /// <summary>
        /// Метод для удаления объекта по id
        /// </summary>
        /// <param name="id"> id </param>
        private void DeletePerson(int id)
        {
            Console.Write("\nВы уверены, что хотите удалить человека?");
            Console.WriteLine("Ваш выбор (д/н):");
            string? input = Console.ReadLine()?.ToLower();
            switch(input)
            {
                case "д":
                    _personController.DeletePerson(id);
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
