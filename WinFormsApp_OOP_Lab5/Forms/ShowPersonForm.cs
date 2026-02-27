using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Forms
{
    /// <summary>
    /// Класс, представляющий UI компонент для просмотра данных человека
    /// </summary>
    public partial class ShowPersonForm : Form
    {
        /// <summary> Человек </summary>
        private readonly Person _person;

        /// <summary> Индекс в реестре (id) </summary>
        private readonly int _id;

        /// <summary>
        /// Уонструктор с параметрами
        /// </summary>
        /// <param name="person"> человек </param>
        /// <param name="id"> id </param>
        public ShowPersonForm(Person person, int id)
        {
            InitializeComponent();
            _person = person;
            _id = id;
        }
        
        /// <summary>
        /// Обработчик событий для загрузки формы
        /// </summary>
        /// <param name="sender"> объект-отправитель (форма) </param>
        /// <param name="e"> событие </param>
        private void ShowPersonForm_Load(object sender, EventArgs e)
        {
            ShowPersonData();
        }
        
        /// <summary>
        /// Метод для отображения данных человека 
        /// </summary>
        private void ShowPersonData()
        {
            IdLabel.Text += _id.ToString();
            GenTextBox.Text = _person.GetGenderToString();
            NameTextBox.Text = _person.ToString();
            HeightTextBox.Text = _person.Height.ToString();
            WidthTextBox.Text = _person.Weight.ToString();
            CountryTextBox.Text = _person.Country;
            ProfessionTextBox.Text = _person.GetProfessionToString();
            AgeTextBox.Text = _person.Age.ToString();
        }

        /// <summary>
        /// Обработчик событий для кнопки "Назад"
        /// </summary>
        /// <param name="sender"> объект-отправитель (кнопка) </param>
        /// <param name="e"> событие </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
