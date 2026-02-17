using WinFormsApp_OOP_Lab1.Exceptions;
using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab1
{
    /// <summary>
    /// Класс главной формы приложения
    /// </summary>
    public partial class MainForm : Form
    {
        // Объект класса Person - человек
        private Person _person;

        // Форма приветствия
        private HelloForm _helloForm;

        // Форма изменения данных человека
        private EditForm _editForm;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _person = new Person();
            _helloForm = new HelloForm();
            _editForm = new EditForm(_person);
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"> объект, вызывающий событие </param>
        /// <param name="e"> событие </param>
        private void CreateForm_Load(object sender, EventArgs e)
        {
            _helloForm.ShowDialog();
            ShowData();
        }

        /// <summary>
        /// Событие для кнопки "Изменить"
        /// </summary>
        /// <param name="sender"> объект, вызывающий событие </param>
        /// <param name="e"> событие </param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                _editForm.ShowDialog();
                ShowData();
            }
            catch (OutOfMemoryException ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка переполнения памяти",
                    16);
            }
        }

        /// <summary>
        /// Метод для отображения пользовательских данных
        /// </summary>
        private void ShowData()
        {
            CountLabel.Text = $"Всего объектов: { Person.Count}";
            GenderTextBox.Text = _person.GetMaleToString(); // Вывод поля через специальный метод
            NameTextBox.Text = _person.ToString(); // Вывод поля через переопределённый метод ToString()
            HeightTextBox.Text = _person.Height.ToString();
            WidthTextBox.Text = _person.Width.ToString(); // Вывод поля через метод ToString()
            CountryTextBox.Text = _person.Country; // Непосредственнный вывод поля
            CityTextBox.Text = _person.City;
            AgeTextBox.Text = "0x" + _person.Age.ToString("x");
            CurrentLabel.Text = $"Текущий объект: {Person.Persons.IndexOf(_person)}";
        }

        /// <summary>
        /// Событие для кнопки "Выйти"
        /// </summary>
        /// <param name="sender"> объект, вызывающий событие </param>
        /// <param name="e"> событие </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
