using WinFormsApp_OOP_Lab7.Controller;
using WinFormsApp_OOP_Lab7.DTO;
using WinFormsApp_OOP_Lab7.Model;
using WinFormsApp_OOP_Lab7.Utils;

namespace WinFormsApp_OOP_Lab7.Forms
{
    /// <summary>
    /// Форма изменения данных человека
    /// </summary>
    public partial class EditForm : Form
    {
        /// <summary> Контроллер для эффективного взаимодействия с моделью </summary>
        private PersonController _personController;

        /// <summary> DTO текущего Person </summary>
        private PersonDTO _personDTO;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="personDTO"> DTO текущего Person для изменения данных </param>
        /// <param name="personController"> Контроллер </param>
        public EditForm(PersonDTO personDTO, PersonController personController)
        {
            InitializeComponent();
            _personController = personController;
            _personDTO = personDTO;
        }

        /// <summary>
        /// Обработчик событий для загрузки формы
        /// </summary>
        /// <param name="sender"> Объект отправитель (форма) </param>
        /// <param name="e"> Событие </param>
        private void EditForm_Load(object sender, EventArgs e)
        {
            Load_ComboBox();
            ShowPersonData();
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
        /// Метод для отображения исходных данных человека
        /// </summary>
        private void ShowPersonData()
        {
            IdLabel.Text += _personDTO.Id.ToString();
            GenderComboBox.SelectedValue = _personDTO.Gender;
            NameTextBox.Text = _personDTO.Name;
            AgeTextBox.Text = _personDTO.Age.ToString();
        }

        /// <summary>
        /// Обработчик событий для кнопки "Изменить"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (форма) </param>
        /// <param name="e"> Событие </param>
        /// <exception cref="ArgumentException"> Исключение неверного аргумента </exception>
        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(AgeTextBox.Text, out _))
                    throw new ArgumentException("Возраст должен быть числом!");

                Gender gender = GenderComboBox.SelectedValue is Gender gen ? gen : throw new ArgumentException(
                    "Пол не выбран!");
                string name = NameTextBox.Text;
                int age = Convert.ToInt32(AgeTextBox.Text);
                _personController.UpdatePerson(_personDTO.Id, gender, name, age);

                MessageBox.Show("Данные успешно обновлены!");
                Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.Message,
                    "Ошибка обновления данных",
                    16);
            }
        }

        /// <summary>
        /// Обработчик событий для кнопки "Выйти"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
