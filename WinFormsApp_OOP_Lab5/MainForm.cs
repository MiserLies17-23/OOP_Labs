using WinFormsApp_OOP_Lab5.Exceptions;
using WinFormsApp_OOP_Lab5.Forms;
using WinFormsApp_OOP_Lab5.Model;
using WinFormsApp_OOP_Lab5.Utils;

namespace WinFormsApp_OOP_Lab5
{
    public partial class MainForm : Form
    {
        private List<Person> _persons;

        public MainForm()
        {
            InitializeComponent();
            _persons = PersonRandomGenerator.GetPersons();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Бригада 13: Пономарёв П., Толстоухов В.\nВариант 13: Человек. Interpreter",
                "Лабораторная работа №5");
            ShowAllPersons();
        }

        private void ShowAllPersons()
        {
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

        private void AllPersonsDataSridWiew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 5)
                {
                    ShowPersonForm showForm = new(_persons[e.RowIndex], e.RowIndex);
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
