using WinFormsApp_OOP_Lab1.Exceptions;
using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab1
{
    /// <summary>
    /// Главный UI-компонент приложения
    /// </summary>
    public partial class MainForm : Form
    {
        // Объект класса Person - человек
        private Person _person;

        // Приветственная форма
        private readonly HelloForm _helloForm;

        // Форма для изменения данных человека
        private readonly EditForm _editForm;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _person = new Person();
            _helloForm = new HelloForm();
            _editForm = new EditForm(_person);
        }

        /// <summary>
        /// Обработчик событий для загрузки формы
        /// </summary>
        /// <param name="sender"> Объект-отправитель (форма) </param>
        /// <param name="e"> Событие </param>
        private void CreateForm_Load(object sender, EventArgs e)
        {
            _helloForm.ShowDialog();
            ShowData();
        }

        /// <summary>
        /// Обработчик событий для кнопки "Изменить"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
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
                    ex.Message,
                    "Ошибка изменения данных",
                    16);
            }
        }

        /// <summary>
        /// Метод для отображения данных человека
        /// </summary>
        private void ShowData()
        {
            CountLabel.Text = $"Количество человек: { Person.Count}";
            GenderTextBox.Text = _person.GetMaleToString(); 
            NameTextBox.Text = _person.ToString(); 
            HeightTextBox.Text = _person.Height.ToString();
            WidthTextBox.Text = _person.Width.ToString(); 
            CountryTextBox.Text = _person.Country; 
            CityTextBox.Text = _person.City;
            AgeTextBox.Text = "0x" + _person.Age.ToString("x");
            CurrentLabel.Text = $"Текущий объект: {Person.Persons.IndexOf(_person)}";
        }

        /// <summary>
        /// Обработчик событий для кнопки "Выйти"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
