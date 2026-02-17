using WinFormsApp_OOP_Lab1.Exceptions;
using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab1
{
    /// <summary>
    /// Форма для изменения данных человека
    /// </summary>
    public partial class EditForm : Form
    {
        // Объект класса Person - человек
        private Person _person;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public EditForm()
        {
            InitializeComponent();
            Load_ComboBox();
            _person = new Person();
        }

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
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"> объект, вызывающий событие </param>
        /// <param name="e"> событие </param>
        private void EditForm_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        /// <summary>
        /// Метод для отображения данных человека
        /// </summary>
        public void ShowData()
        {
            GenderComboBox.SelectedValue = _person.Gen;
            NameTextBox.Text = _person.Name; 
            HeightTextBox.Text = _person.Height.ToString();
            WidthTextBox.Text = _person.Width.ToString();
            CountryTextBox.Text = _person.Country; 
            CityTextBox.Text = _person.City;
            AgeTextBox.Text = _person.Age.ToString();
            CurrentLabel.Text = $"Текущий объект: {Person.Persons.IndexOf(_person)}" ;
        }

        /// <summary>
        /// События для кнопки "Назад"
        /// </summary>
        /// <param name="sender"> объект, вызывающий событие </param>
        /// <param name="e"> событие </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Событие для кнопки "Сохранить"
        /// </summary>
        /// <param name="sender"> объект, вызывающий событие </param>
        /// <param name="e"> событие </param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(AgeTextBox.Text, out int age))
                    throw new PersonValidationException(
                        "Возраст должен быть числом!",
                        nameof(_person.Age),
                        AgeTextBox.Text
                        );

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
                _person.City = CityTextBox.Text;
                _person.Country = CountryTextBox.Text;

                MessageBox.Show("Данные успешно обновлены!");
                Close();
            }
            catch (PersonValidationException ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка валидации",
                    16);
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
    }
}
