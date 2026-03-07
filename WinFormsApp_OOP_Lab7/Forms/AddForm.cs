using WinFormsApp_OOP_Lab7.Controller;
using WinFormsApp_OOP_Lab7.Model;
using WinFormsApp_OOP_Lab7.Utils;

namespace WinFormsApp_OOP_Lab7.Forms
{
    /// <summary>
    /// Форма добавления нового человекаЫ
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary> Объект PersonController для эффективного взаимодействия с моделью </summary>
        private PersonController _personController;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="personController"> Контроллер </param>
        public AddForm(PersonController personController)
        {
            InitializeComponent();
            _personController = personController;
        }

        /// <summary>
        /// Обработчик событий для загрузки формы
        /// </summary>
        /// <param name="sender"> Объект-отправитель (форма) </param>
        /// <param name="e"></param>
        private void AddForm_Load(object sender, EventArgs e)
        {
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
        /// Обработчик событий для кнопки "Добавить"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        /// <exception cref="ArgumentException"> Исключение неверного аргументо </exception>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(AgeTextBox.Text, out int age))
                    throw new ArgumentException("Возраст должен быть числом!");

                Gender gender = GenderComboBox.SelectedValue is Gender gen ? gen : throw new ArgumentException(
                    "Вес не выбран!");
                string name = NameTextBox.Text;
                age = Convert.ToInt32(AgeTextBox.Text);
                _personController.AddPerson(gender, name, age);
                MessageBox.Show("Человек успешно добавлен!");
                Close();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.Message,
                    "Ошибка добавления",
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
