using WinFormsApp_OOP_Lab7.Controller;
using WinFormsApp_OOP_Lab7.DTO;
using WinFormsApp_OOP_Lab7.Model;

namespace WinFormsApp_OOP_Lab7.Forms
{
    public partial class EditForm : Form
    {
        private PersonController _personController;

        private PersonDTO _personDTO;

        public EditForm(PersonDTO personDTO, PersonController personController)
        {
            InitializeComponent();
            _personController = personController;
            _personDTO = personDTO;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            Load_ComboBox();
            ShowPersonDatat();
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

        private void ShowPersonDatat()
        {
            IdLabel.Text += _personDTO.Id.ToString();
            GenderComboBox.SelectedValue = _personDTO.Gender;
            NameTextBox.Text = _personDTO.Name;
            AgeTextBox.Text = _personDTO.Age.ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(AgeTextBox.Text, out _))
                throw new ArgumentException("Возраст должен быть числом!");

            Gender gender = GenderComboBox.SelectedValue is Gender gen ? gen : throw new ArgumentException(
                "Вес не выбран!");
            string name = NameTextBox.Text;
            int age = Convert.ToInt32(AgeTextBox.Text);
            _personController.UpdatePerson(_personDTO.Id, gender, name, age);

            MessageBox.Show("Данные успешно обновлены!");
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
