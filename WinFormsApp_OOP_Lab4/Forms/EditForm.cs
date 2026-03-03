using WinFormsApp_OOP_Lab4.Components;
using WinFormsApp_OOP_Lab4.Exceptions;
using WinFormsApp_OOP_Lab4.Models.PersonModel;
using WinFormsApp_OOP_Lab4.Models.PersonProxy;

namespace WinFormsApp_OOP_Lab4.Forms
{
    /// <summary>
    /// Класс, представляющий форму изменения данных человека
    /// </summary>
    public partial class EditForm : Form
    {
        /// <summary> Объект PersonProxy для безопасной работы с Person </summary>
        private readonly PersonProxy _personProxy;

        /// <summary> Объект EventProcessing для отображения последних событий </summary>
        private readonly EventProcessing _eventProcessing;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="personProxy"> PersonProxy </param>
        public EditForm(PersonProxy personProxy)
        {
            InitializeComponent();
            _personProxy = personProxy;
            _eventProcessing = new(EventsLabel, _personProxy);
        }

        /// <summary>
        /// Обработчик событий для загрузки формы
        /// </summary>
        /// <param name="sender"> Объект-отправитель (форма) </param>
        /// <param name="e"> Событие </param>
        private void EditForm_Load(object sender, EventArgs e)
        {
            _eventProcessing.ShowFirstEvent();
            Load_ComboBox();
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
        private void ShowEditData()
        {
            GenderComboBox.SelectedValue = _personProxy.Gen;
            NameTextBox.Text = _personProxy.Name;
            HeightTextBox.Text = _personProxy.Height.ToString();
            WidthTextBox.Text = _personProxy.Weight.ToString();
            CountryTextBox.Text = _personProxy.Country;
            CityTextBox.Text = _personProxy.City;
            AgeTextBox.Text = _personProxy.Age.ToString();
        }

        /// <summary>
        /// Обработчик события для кнопки "Сохранить"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(AgeTextBox.Text, out _))
                    throw new PersonValidationException(
                        "Возраст должен быть числом!",
                        nameof(_personProxy.Age),
                        AgeTextBox.Text);

                if (!float.TryParse(HeightTextBox.Text, out _))
                    throw new PersonValidationException(
                        "Рост должен быть числом!",
                        nameof(_personProxy.Height),
                        HeightTextBox.Text);

                if (!float.TryParse(WidthTextBox.Text, out _))
                    throw new PersonValidationException(
                        "Вес должен быть числом!",
                        nameof(_personProxy.Weight),
                       WidthTextBox.Text);

                _personProxy.Gen = GenderComboBox.SelectedValue is Gender gender ? gender : throw new ArgumentNullException();
                _personProxy.Name = NameTextBox.Text;
                _personProxy.Height = Convert.ToDouble(HeightTextBox.Text);
                _personProxy.Weight = Convert.ToDouble(WidthTextBox.Text);
                _personProxy.Age = Convert.ToInt32(AgeTextBox.Text);
                _personProxy.City = CityTextBox.Text;
                _personProxy.Country = CountryTextBox.Text;

                MessageBox.Show(@"Данные успешно обновлены!");
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
        /// <param name="sender"> Объект, вызывающий событие </param>
        /// <param name="e"> Событие </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
