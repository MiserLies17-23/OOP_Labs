using System;

namespace WinFormsApp_OOP_Lab3
{
    public partial class EditForm : Form
    {
        // Объект класса Person - человек
        private Person person;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="person"> объект класса Person </param>
        public EditForm(Person _person)
        {
            InitializeComponent();
            Load_ComboBox();
            person = _person;
        }
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
            GenderComboBox.SelectedValue = person.Gen;
            NameTextBox.Text = person.Name;
            HeightTextBox.Text = person.Height.ToString();
            WidthTextBox.Text = person.Width.ToString();
            CountryTextBox.Text = person.Country;
            CityTextBox.Text = person.City;
            AgeTextBox.Text = person.Age.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(AgeTextBox.Text, out int age))
                    throw new PersonValidationException(
                        "Возраст должен быть числом!",
                        nameof(person.Age),
                        AgeTextBox.Text);

                if (!float.TryParse(HeightTextBox.Text, out float height))
                    throw new PersonValidationException(
                        "Рост должен быть числом!",
                        nameof(person.Height),
                        HeightTextBox.Text);

                if (!float.TryParse(WidthTextBox.Text, out float weight))
                    throw new PersonValidationException(
                        "Вес должен быть числом!",
                        nameof(person.Width),
                       WidthTextBox.Text);

                person.Gen = (Gender)GenderComboBox.SelectedValue;
                person.Name = NameTextBox.Text;
                person.Height = Convert.ToDouble(HeightTextBox.Text);
                person.Width = Convert.ToDouble(WidthTextBox.Text);
                person.Age = Convert.ToInt32(AgeTextBox.Text);
                person.City = CityTextBox.Text;
                person.Country = CountryTextBox.Text;

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
    }
}
