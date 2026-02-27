using WinFormsApp_OOP_Lab7.Controller;
using WinFormsApp_OOP_Lab7.DTO;
using WinFormsApp_OOP_Lab7.Forms;
using WinFormsApp_OOP_Lab7.Utils;

namespace WinFormsApp_OOP_Lab7
{
    public partial class MainForm : Form
    {
        private PersonController _personController;
        
        public MainForm()
        {
            InitializeComponent();
            _personController = new();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Бригада 13: Пономарёв П., Толстоухов В.\nВариант 13: Человек",
                    "Лабораторная работа №7");
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

        private void ShowAllPersons()
        {
            try
            {
                List<PersonDTO> persons = _personController.GetAllPersons() ?? [];
                PersonDataGridView.Rows.Clear();
                foreach (PersonDTO person in persons)
                {
                    int rowIndex = PersonDataGridView.Rows.Add();
                    PersonDataGridView.Rows[rowIndex].Cells[0].Value = persons.IndexOf(person);
                    PersonDataGridView.Rows[rowIndex].Cells[1].Value = person.Gender;
                    PersonDataGridView.Rows[rowIndex].Cells[2].Value = person.Name;
                    PersonDataGridView.Rows[rowIndex].Cells[3].Value = person.Age;
                    PersonDataGridView.Rows[rowIndex].Cells[4].Value = "Изменить";
                    PersonDataGridView.Rows[rowIndex].Cells[5].Value = "Удалить";
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
        
        private void PersonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 4)
                {
                    int personIndex = e.RowIndex;

                    PersonDTO editPerson = _personController.GetPersonById(personIndex);
                    EditForm editForm = new(editPerson, _personController);
                    editForm.ShowDialog();
                    ShowAllPersons();
                }
                if (e.RowIndex >= 0 && e.ColumnIndex == 5)
                {
                    int personIndex = e.RowIndex;
                    _personController.DeletePerson(personIndex);
                    ShowAllPersons();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddForm addForm = new(_personController);
                addForm.ShowDialog();
                ShowAllPersons();
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

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
