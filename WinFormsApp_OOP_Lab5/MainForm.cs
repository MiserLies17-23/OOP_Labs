using WinFormsApp_OOP_Lab5.Exceptions;
using WinFormsApp_OOP_Lab5.Forms;
using WinFormsApp_OOP_Lab5.Interpreter;
using WinFormsApp_OOP_Lab5.Interpreter.NonTerminalExpression;
using WinFormsApp_OOP_Lab5.Interpreter.SearchExpression;
using WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression;
using WinFormsApp_OOP_Lab5.Model;
using WinFormsApp_OOP_Lab5.Utils;

namespace WinFormsApp_OOP_Lab5
{
    /// <summary>
    /// Главный UI-компнонент приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary> Компнонент для инициализации значений ComboBox </summary>
        private readonly ComboBoxComponent _comboBoxComponent;

        /// <summary> Список людей </summary>
        private readonly List<Person> _persons;

        /// <summary> Парсер для преобразования логических выражений </summary>
        private readonly Parser _parser;
        
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _comboBoxComponent = new(GenderComboBox, NonTermComboBox1, NonTermComboBox2, ProfessionComboBox);
            _persons = PersonRandomGenerator.GetPersons();
            _parser = new();
        }

        /// <summary>
        /// Обработчик событий для загрузки формы
        /// </summary>
        /// <param name="sender"> объект-отправитель (форма) </param>
        /// <param name="e"> событие </param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try 
            {
                MessageBox.Show("Бригада 13: Пономарёв П., Толстоухов В.\nВариант 13: Человек. Interpreter",
                    "Лабораторная работа №5");
                ShowAllPersons(); 
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.ToString(),
                    "Ошибка загрузки формы",
                    16);
            }
        }

        /// <summary>
        /// Метод для отображения всех объектов Person
        /// </summary>
        private void ShowAllPersons()
        {
            AllPersonsDataGridView.Rows.Clear();
            foreach (Person person in _persons)
            {
                int rowIndex = AllPersonsDataGridView.Rows.Add();
                AllPersonsDataGridView.Rows[rowIndex].Cells[0].Value = _persons.IndexOf(person);
                AllPersonsDataGridView.Rows[rowIndex].Cells[1].Value = person.GetGenderToString();
                AllPersonsDataGridView.Rows[rowIndex].Cells[2].Value = person.ToString();
                AllPersonsDataGridView.Rows[rowIndex].Cells[3].Value = person.Age;
                AllPersonsDataGridView.Rows[rowIndex].Cells[4].Value = person.GetProfessionToString();
                AllPersonsDataGridView.Rows[rowIndex].Cells[5].Value = "Показать";
            }
        }

        /// <summary>
        /// Обработчки событий для кнопки "Показать"
        /// </summary>
        /// <param name="sender"> объект-отправитель (форма) </param>
        /// <param name="e"> событие </param>
        private void DataSridWiew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 5)
                {
                    int personIndex = (int)((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value;

                    Person selectedPerson = _persons[personIndex];
                    ShowPersonForm showForm = new(selectedPerson, personIndex);
                    showForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.ToString(),
                    "Ошибка",
                    16);
            }
        }

        /// <summary>
        /// Обработчик событий для кнопки "Найти"
        /// </summary>
        /// <param name="sender"> объект-отправитель (форма) </param>
        /// <param name="e"> событие </param>
        /// <exception cref="ArgumentNullException"> ошибка не заданного значения </exception>
        /// <exception cref="ArgumentException"> ошибка задания диапазона возрастов </exception>
        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                SearchQuery sq = new();
                sq.Gender = GenderComboBox.SelectedValue is Gender gender 
                    ? gender : throw new ArgumentNullException("Пол не выбран!");
                sq.FirstOperation = NonTermComboBox1.SelectedValue is Operation op1 
                    ? op1 : throw new ArgumentNullException("Первый оператор не выбран!");
                sq.Age = (int)AgeDownNumericUpDown.Value <= (int)AgeTopNumericUpDown.Value
                    ? new AgeRange((int)AgeDownNumericUpDown.Value, (int)AgeTopNumericUpDown.Value)
                    : throw new ArgumentException("Верхняя граница возраста не может быть меньше нижней!");
                sq.SecondOperation = NonTermComboBox2.SelectedValue is Operation op2 
                    ? op2 : throw new ArgumentNullException("Второй оператор не выбран!");
                sq.Profession = ProfessionComboBox.SelectedValue is Profession prof 
                    ? prof : throw new ArgumentNullException("Профессия не выбрана!");

                IExpression expression = _parser.Parse(sq);
                DisplayResults(expression);
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.ToString(),
                    "Ошибка поиска",
                    16);
            }
        }

        /// <summary>
        /// Метод отображения результатов поиска
        /// </summary>
        /// <param name="expression"> выражение </param>
        private void DisplayResults(IExpression expression)
        {
            SuitPersonsDataGridView.Rows.Clear();
            foreach (Person person in _persons)
            {
                var context = new Context(person);
                if (expression.Interpret(context))
                {
                    int rowIndex = SuitPersonsDataGridView.Rows.Add();
                    SuitPersonsDataGridView.Rows[rowIndex].Cells[0].Value = _persons.IndexOf(person);
                    SuitPersonsDataGridView.Rows[rowIndex].Cells[1].Value = person.GetGenderToString();
                    SuitPersonsDataGridView.Rows[rowIndex].Cells[2].Value = person.ToString();
                    SuitPersonsDataGridView.Rows[rowIndex].Cells[3].Value = person.Age;
                    SuitPersonsDataGridView.Rows[rowIndex].Cells[4].Value = person.GetProfessionToString();
                    SuitPersonsDataGridView.Rows[rowIndex].Cells[5].Value = "Показать";
                }
            }
            if (SuitPersonsDataGridView.Rows.Count == 0)
                MessageBox.Show("Людей, удовлетворяющих требованию, не найдено!");
        }
        
        /// <summary>
        /// Обработчик событий для кнопки "Выйти"
        /// </summary>
        /// <param name="sender"> объект-отправитель (кнопка) </param>
        /// <param name="e"> событие </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
