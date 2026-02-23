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
    public partial class MainForm : Form
    {
        private readonly ComboBoxComponent _comboBoxComponent;

        private readonly List<Person> _persons;

        private readonly Parser _parser;
        public MainForm()
        {
            InitializeComponent();
            _comboBoxComponent = new(GenderComboBox, NonTermComboBox1, NonTermComboBox2, ProfessionComboBox);
            _persons = PersonRandomGenerator.GetPersons();
            _parser = new();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Бригада 13: Пономарёв П., Толстоухов В.\nВариант 13: Человек. Interpreter",
                "Лабораторная работа №5");
            ShowAllPersons();
        }

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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
