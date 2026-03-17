using WinFormsApp_OOP_Lab8.DTO;
using WinFormsApp_OOP_Lab8.Utils;
using WinFormsApp_OOP_Lab8.View;

namespace WinFormsApp_OOP_Lab8
{
    public partial class MainForm : Form, IView
    {
        private int _mode;

        private List<PersonDTO> _persons;

        public event Action<string, string, string> AddPersonEvent;

        public event Action<int, string, string, string> EditPersonEvent;

        public event Action<int> DeletePersonEvent;

        public List<PersonDTO> Persons
        {
            get => _persons;
            set => _persons = value;
        }
        public MainForm()
        {
            InitializeComponent();
            _mode = 0;
            _persons = new();
            AddPersonEvent = delegate { };
            EditPersonEvent = delegate { };
            DeletePersonEvent = delegate { };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ShowAllPersons();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.Message,
                    "Ошибка загрузки формы",
                    16);
            }

        }

        private void ShowAllPersons()
        {
            PersonDataGridView.Rows.Clear();
            foreach (PersonDTO person in _persons)
            {
                int rowIndex = PersonDataGridView.Rows.Add();
                PersonDataGridView.Rows[rowIndex].Cells[0].Value = person.Id;
                PersonDataGridView.Rows[rowIndex].Cells[1].Value = person.Name;
                PersonDataGridView.Rows[rowIndex].Cells[2].Value = person.Country;
                PersonDataGridView.Rows[rowIndex].Cells[3].Value = person.City;
                PersonDataGridView.Rows[rowIndex].Cells[4].Value = "Изменить";
                PersonDataGridView.Rows[rowIndex].Cells[5].Value = "Удалить";
            }
        }

        private void PersonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 4)
                {
                    int personIndex = e.RowIndex;
                    PersonDTO editPerson = _persons[personIndex];

                    _mode = personIndex;

                    ActivityLabel.Text = "Форма изменения данных человека";
                    IdLabel.Text = personIndex.ToString();
                    NameTextBox.Text = editPerson.Name;
                    CountryTextBox.Text = editPerson.Country;
                    CityTextBox.Text = editPerson.City;

                    ActivityPanel.Visible = true;
                    AddButton.Enabled = false;
                }
                if (e.RowIndex >= 0 && e.ColumnIndex == 5)
                {
                    DialogResult result = MessageBox.Show("Вы действительно хотите удалить объект?",
                        "Согласие на удаление",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        int personIndex = e.RowIndex;
                        DeletePersonEvent?.Invoke(personIndex);
                    }
                    ShowAllPersons();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.Message,
                    "Ошибка",
                    16);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _mode = _persons.Count;

            ActivityLabel.Text = "Форма добавления нового человека";
            IdLabel.Text = _persons.Count.ToString();

            ActivityPanel.Visible = true;
            AddButton.Enabled = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mode == _persons.Count)
                {
                    var name = NameTextBox.Text;
                    var country = CountryTextBox.Text;
                    var city = CityTextBox.Text;

                    AddPersonEvent?.Invoke(name, country, city);
                }
                else
                {
                    int id = Convert.ToInt32(IdLabel.Text);
                    var name = NameTextBox.Text;
                    var country = CountryTextBox.Text;
                    var city = CityTextBox.Text;

                    EditPersonEvent?.Invoke(id, name, country, city);
                }

                ActivityPanel.Visible = false;
                AddButton.Enabled = true;

                ShowAllPersons();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.Message,
                    "Ошибка",
                    16);
            }
        }
        private void CancellButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = string.Empty;
            CountryTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;

            ActivityPanel.Visible = false;
            AddButton.Enabled = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
