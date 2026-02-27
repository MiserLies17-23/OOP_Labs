using WinFormsApp_OOP_Lab7.Controller;
using WinFormsApp_OOP_Lab7.Model;
using WinFormsApp_OOP_Lab7.Utils;

namespace WinFormsApp_OOP_Lab7.Forms
{
    public partial class AddForm : Form
    {
        private PersonController _personController;

        public AddForm(PersonController personController)
        {
            InitializeComponent();
            _personController = personController;
        }

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
                    ex.ToString(),
                    "Ошибка добавления",
                    16);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
