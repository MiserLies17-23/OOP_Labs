using WinFormsApp_OOP_Lab3.Exceptions;
using WinFormsApp_OOP_Lab3.Model;

namespace WinFormsApp_OOP_Lab3
{
    /// <summary>
    /// Класс, представляющий форму для изменения данных человека
    /// </summary>
    public partial class EditForm : Form
    {
        /// <summary> Объект класса Person - человек </summary>
        private Person _person;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="person"> объект класса Person </param>
        public EditForm(Person person)
        {
            InitializeComponent();
            Load_ComboBox();
            _person = person;
        }

        /// <summary>
        /// Метод для загрузки формы
        /// </summary>
        /// <param name="sender"> объект-отправитель (форма) </param>
        /// <param name="e"> событие </param>
        private void EditForm_Load(object sender, EventArgs e)
        {
            ShowEditData();
        }

        /// <summary>
        /// Метод для загрузки GenderComboBox
        /// </summary>
        private void Load_ComboBox()
        {
            var displayValues = new Dictionary<Gender, string>
            {
                { Gender.MALE, "Муж" },
                { Gender.FEMALE, "Жен" },

            };
            GenderComboBox.DataSource = new BindingSource(displayValues, null);
            GenderComboBox.DisplayMember = "Value";
            GenderComboBox.ValueMember = "Key";
        }

        /// <summary>
        /// Метод для отображения данных человека
        /// </summary>
        public void ShowEditData()
        {
            GenderComboBox.SelectedValue = _person.Gen;
            NameTextBox.Text = _person.Name;
            HeightTextBox.Text = _person.Height.ToString();
            WidthTextBox.Text = _person.Width.ToString();
            CountryTextBox.Text = _person.Address.Country;
            CityTextBox.Text = _person.Address.City;
            AgeTextBox.Text = _person.Age.ToString();
        }

        /// <summary>
        /// Обработчик событий для кнопки "Сохранить"
        /// </summary>
        /// <param name="sender"> объект-отправитель </param>
        /// <param name="e"> событие </param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(AgeTextBox.Text, out int age))
                    throw new PersonValidationException(
                        "Возраст должен быть числом!",
                        nameof(_person.Age),
                        AgeTextBox.Text);

                if (!float.TryParse(HeightTextBox.Text, out float height))
                    throw new PersonValidationException(
                        "Рост должен быть числом!",
                        nameof(_person.Height),
                        HeightTextBox.Text);

                if (!float.TryParse(WidthTextBox.Text, out float weight))
                    throw new PersonValidationException(
                        "Вес должен быть числом!",
                        nameof(_person.Width),
                       WidthTextBox.Text);

                _person.Gen = (Gender)GenderComboBox.SelectedValue;
                _person.Name = NameTextBox.Text;
                _person.Height = Convert.ToDouble(HeightTextBox.Text);
                _person.Width = Convert.ToDouble(WidthTextBox.Text);
                _person.Age = Convert.ToInt32(AgeTextBox.Text);
                _person.Address.City = CityTextBox.Text;
                _person.Address.Country = CountryTextBox.Text;

                MessageBox.Show("Данные успешно обновлены!");
                Close();
            }
            catch (PersonValidationException ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.ToString(),
                    "Ошибка валидации",
                    16);
            }
        }

        /// <summary>
        /// События для кнопки "Назад"
        /// </summary>
        /// <param name="sender"> объект-отправитель (кнопка) </param>
        /// <param name="e"> событие </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
