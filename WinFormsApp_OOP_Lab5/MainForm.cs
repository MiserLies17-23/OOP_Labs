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
    /// Главный UI-компонент приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary> Компонент для корректного отображения ComboBox </summary>
        private readonly ComboBoxComponent _comboBoxComponent;

        /// <summary> Список людей </summary>
        private readonly List<Person> _persons;

        /// <summary> Класс для преобразования выражений </summary>
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
        /// <param name="sender"> Объект-отправитель (форма) </param>
        /// <param name="e"> Событие </param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try 
            {
                MessageBox.Show("Бригада 13: Пономарев П., Толстоухов В.\nВариант 13: Человек. Interpreter",
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
                int i = 0;
                AllPersonsDataGridView.Rows[rowIndex].Cells[i++].Value = _persons.IndexOf(person);
                AllPersonsDataGridView.Rows[rowIndex].Cells[i++].Value = person.GetGenderToString();
                AllPersonsDataGridView.Rows[rowIndex].Cells[i++].Value = person.ToString();
                AllPersonsDataGridView.Rows[rowIndex].Cells[i++].Value = person.Age;
                AllPersonsDataGridView.Rows[rowIndex].Cells[i++].Value = person.GetProfessionToString();
                AllPersonsDataGridView.Rows[rowIndex].Cells[i].Value = "Посмотреть";
            }
        }

        /// <summary>
        /// Обработчик события для кнопки "Показать" таблицы
        /// </summary>
        /// <param name="sender"> Объект-отправитель (форма) </param>
        /// <param name="e"> Событие </param>
        private void DataGridWiew_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        /// <exception cref="ArgumentNullException"> Ошибка нулевого аргумента для полей класса </exception>
        /// <exception cref="ArgumentException"> Ошибка некорректного аргумента для нессылочных полей класса </exception>
        private void FindButton_Click(object sender, EventArgs e)
        {
            try
            {
                SearchQuery sq = new();
                sq.Gender = GenderComboBox.SelectedValue is Gender gender 
                    ? gender : throw new ArgumentNullException("Пол не задан!");
                sq.FirstOperation = NonTermComboBox1.SelectedValue is Operation op1 
                    ? op1 : throw new ArgumentNullException("Первый оператор не задан!");
                sq.Age = (int)AgeDownNumericUpDown.Value <= (int)AgeTopNumericUpDown.Value
                    ? new AgeRange((int)AgeDownNumericUpDown.Value, (int)AgeTopNumericUpDown.Value)
                    : throw new ArgumentException("Нижняя граница возраста не может быть ниже верхней!");
                sq.SecondOperation = NonTermComboBox2.SelectedValue is Operation op2 
                    ? op2 : throw new ArgumentNullException("Второй оператор не задан!");
                sq.Profession = ProfessionComboBox.SelectedValue is Profession prof 
                    ? prof : throw new ArgumentNullException("Профессия не задана!");

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
        /// Метод для отображения результатов поиска
        /// </summary>
        /// <param name="expression"> Выражение </param>
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
                MessageBox.Show("Людей, удовлетворяющих выражению, не найдено!");
        }
        
        /// <summary>
        /// Обработчик событий для кнопки "Выйти"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
