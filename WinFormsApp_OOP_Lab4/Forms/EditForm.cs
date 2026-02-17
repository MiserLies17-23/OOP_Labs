using WinFormsApp_OOP_Lab4.Components;
using WinFormsApp_OOP_Lab4.Exceptions;
using WinFormsApp_OOP_Lab4.Models.PersonModel;
using WinFormsApp_OOP_Lab4.Models.PersonProxy;

namespace WinFormsApp_OOP_Lab4
{
    public partial class EditForm : Form
    {
        private PersonProxy _personProxy;

        private EventProcessing _eventProcessing;
        public EditForm(PersonProxy personProxy)
        {
            InitializeComponent();
            _personProxy = personProxy;
            _eventProcessing = new(EventsLabel, _personProxy);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            _eventProcessing.ShowFirstEvent();
            ShowEditData();
            Load_ComboBox();
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
            GenderComboBox.SelectedValue = _personProxy.Gen;
            NameTextBox.Text = _personProxy.Name;
            HeightTextBox.Text = _personProxy.Height.ToString();
            WidthTextBox.Text = _personProxy.Weight.ToString();
            CountryTextBox.Text = _personProxy.Country;
            CityTextBox.Text = _personProxy.City;
            AgeTextBox.Text = _personProxy.Age.ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(AgeTextBox.Text, out int age))
                    throw new PersonValidationException(
                        "Возраст должен быть числом!",
                        nameof(_personProxy.Age),
                        AgeTextBox.Text);

                if (!float.TryParse(HeightTextBox.Text, out float height))
                    throw new PersonValidationException(
                        "Рост должен быть числом!",
                        nameof(_personProxy.Height),
                        HeightTextBox.Text);

                if (!float.TryParse(WidthTextBox.Text, out float weight))
                    throw new PersonValidationException(
                        "Вес должен быть числом!",
                        nameof(_personProxy.Weight),
                       WidthTextBox.Text);

                _personProxy.Gen = (Gender)GenderComboBox.SelectedValue;
                _personProxy.Name = NameTextBox.Text;
                _personProxy.Height = Convert.ToDouble(HeightTextBox.Text);
                _personProxy.Weight = Convert.ToDouble(WidthTextBox.Text);
                _personProxy.Age = Convert.ToInt32(AgeTextBox.Text);
                _personProxy.City = CityTextBox.Text;
                _personProxy.Country = CountryTextBox.Text;

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
