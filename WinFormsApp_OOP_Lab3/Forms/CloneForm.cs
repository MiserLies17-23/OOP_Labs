using WinFormsApp_OOP_Lab3.Exceptions;
using WinFormsApp_OOP_Lab3.Model;

namespace WinFormsApp_OOP_Lab3
{
    /// <summary>
    /// Форма представления клонированных объектов
    /// </summary>
    public partial class CloneForm : Form
    {
        /// <summary> Клонированный объект Person </summary>
        private Person _clonePerson;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="clonePerson"> клонированный объект </param>
        public CloneForm(Person clonePerson)
        {
            InitializeComponent();
            _clonePerson = clonePerson;
            ShowClonePersonData();
        }

        /// <summary>
        /// Обработчик события для кнопки "Изменить"
        /// </summary>
        /// <param name="sender"> объект-отправитель (кнопка) </param>
        /// <param name="e"> событие </param>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new(_clonePerson);
                editForm.ShowDialog();
                ShowClonePersonData();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка переполнения памяти",
                    16);
            }
        }

        /// <summary>
        /// Метод для вывода информации об объекте
        /// </summary>
        private void ShowClonePersonData()
        {
            GenTextBox.Text = _clonePerson.GetGenderToString(); // Вывод поля через специальный метод
            NameTextBox.Text = _clonePerson.ToString(); // Вывод поля через переопределённый метод ToString()
            HeightTextBox.Text = _clonePerson.Height.ToString();
            WidthTextBox.Text = _clonePerson.Width.ToString(); // Вывод поля через метод ToString()
            CountryTextBox.Text = _clonePerson.Country; // Непосредственнный вывод поля
            CityTextBox.Text = _clonePerson.City;
            AgeTextBox.Text = _clonePerson.Age.ToString();
        }

        /// <summary>
        /// Метод для скрытия формы
        /// </summary>
        /// <param name="sender"> объект-отправитель (кнопка) </param>
        /// <param name="e"> событие </param>
        private void HudeButton_Click(object sender, EventArgs e)
        {
            int index = Person.Persons.IndexOf(_clonePerson);
            if (index != -1)
                Person.Persons[index] = _clonePerson;
            Hide();
        }
    }
}
