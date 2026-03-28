using WinFormsApp_OOP_Lab8.DTO;
using WinFormsApp_OOP_Lab8.Utils;
using WinFormsApp_OOP_Lab8.View;

namespace WinFormsApp_OOP_Lab8
{
    /// <summary>
    /// Графический Ui-комопнент
    /// Реализует интерфейс IView
    /// </summary>
    public partial class MainForm : Form, IView
    {
        /// <summary> Режим (изменение/добавление) </summary>
        private string _mode;

        /// <summary> Список объектов PersonDTO (только для чтения) </summary>
        private List<PersonDTO> _persons;

        /// <summary> Событий добавления нового объекта </summary>
        public event Action<string, string, string> AddPersonEvent;

        /// <summary> Событие изменения объекта </summary>
        public event Action<int, string, string, string> EditPersonEvent;

        /// <summary> Событие удаления объекта </summary>
        public event Action<int> DeletePersonEvent;

        /// <summary>
        /// Свойство для списка объектов
        /// </summary>
        public List<PersonDTO> Persons
        {
            get => _persons;
            set => _persons = value;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _mode = "Add";
            _persons = new();
            AddPersonEvent = delegate { };
            EditPersonEvent = delegate { };
            DeletePersonEvent = delegate { };
        }
         
        /// <summary>
        /// Обработчик событий для загрузки формы
        /// </summary>
        /// <param name="sender"> Объект-отправитель (форма) </param>
        /// <param name="e"> Событие </param>
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

        /// <summary>
        /// Метод для отображения всех объектов
        /// </summary>
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

        /// <summary>
        /// Метод для очистки полей панели
        /// </summary>
        private void FieldClear()
        {
            NameTextBox.Text = string.Empty;
            CountryTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Обработчик событий для нажати на кнопки таблицы
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void PersonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int personIndex = (int)PersonDataGridView.Rows[e.RowIndex].Cells[0].Value;
                if (e.RowIndex >= 0 && e.ColumnIndex == 4)
                {
                    PersonDTO? editPerson = _persons.FirstOrDefault(p => p.Id == personIndex);
                    
                    if (editPerson == null)
                        throw new ArgumentException("Объект не найден!");

                    _mode = "Edit";
                    IdLabel.Show();

                    ActivityLabel.Text = "Форма изменения данных человека";
                    IdLabel.Text = $"Id: {personIndex}";
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

        /// <summary>
        /// Обработчик событий для кнопки "Добавить"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _mode = "Add";

            ActivityLabel.Text = "Форма добавления нового человека";
            IdLabel.Hide();

            ActivityPanel.Visible = true;
            AddButton.Enabled = false;
        }

        /// <summary>
        /// Обработчик событий для кнопки "Сохранить"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mode == "Add")
                {
                    var name = NameTextBox.Text;
                    var country = CountryTextBox.Text;
                    var city = CityTextBox.Text;

                    AddPersonEvent?.Invoke(name, country, city);

                    MessageBox.Show("Человек успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    int id = Convert.ToInt32(IdLabel.Text);
                    var name = NameTextBox.Text;
                    var country = CountryTextBox.Text;
                    var city = CityTextBox.Text;

                    EditPersonEvent?.Invoke(id, name, country, city);

                    MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                FieldClear();

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

        /// <summary>
        /// Обработчик событий для кнопки "Отмена"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void CancellButton_Click(object sender, EventArgs e)
        {
            FieldClear();

            ActivityPanel.Visible = false;
            AddButton.Enabled = true;
        }

        /// <summary>
        /// Обработчик событий для кнопки "Выход"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
