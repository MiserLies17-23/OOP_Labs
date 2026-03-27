using WinFormsApp_OOP_Lab7.Controller;
using WinFormsApp_OOP_Lab7.DTO;
using WinFormsApp_OOP_Lab7.Forms;
using WinFormsApp_OOP_Lab7.Utils;

namespace WinFormsApp_OOP_Lab7
{
    /// <summary>
    /// Главный UI компонент приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary> Контроллер для взаимодействия с моделью (реализация паттерна MVC) </summary>
        private readonly PersonController _personController;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm(PersonController personController)
        {
            InitializeComponent();
            _personController = personController;
        }

        /// <summary>
        /// Обработчик событий для загрузки формы
        /// </summary>
        /// <param name="sender"> Объект-отпарвитель (форма) </param>
        /// <param name="e"> Событие </param>
        private void MainForm_Load(object sender, EventArgs e)
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
        /// Метод для отображения всех пользователей
        /// </summary>
        private void ShowAllPersons()
        {
            List<PersonDTO> persons = _personController.GetAllPersons() ?? [];
            PersonDataGridView.Rows.Clear();
            foreach (PersonDTO person in persons)
            {
                int rowIndex = PersonDataGridView.Rows.Add();
                PersonDataGridView.Rows[rowIndex].Cells[0].Value = person.Id;
                PersonDataGridView.Rows[rowIndex].Cells[1].Value = person.GetGenderToString();
                PersonDataGridView.Rows[rowIndex].Cells[2].Value = person.Name;
                PersonDataGridView.Rows[rowIndex].Cells[3].Value = person.Age;
                PersonDataGridView.Rows[rowIndex].Cells[4].Value = "Изменить";
                PersonDataGridView.Rows[rowIndex].Cells[5].Value = "Удалить";
            }
        }
        
        /// <summary>
        /// Обработчик событий для кнопок таблицы
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void PersonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int personId = (int)PersonDataGridView.Rows[e.RowIndex].Cells[0].Value;
                
                if (e.RowIndex >= 0 && e.ColumnIndex == 4)
                {
                    PersonDTO editPerson = _personController.GetPersonById(personId);
                    EditForm editForm = new(editPerson, _personController);
                    editForm.ShowDialog();
                    ShowAllPersons();
                }
                if (e.RowIndex >= 0 && e.ColumnIndex == 5)
                {
                    DialogResult result = MessageBox.Show("Вы действительно хотите удалить объект?",
                        "Согласие на удаление",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information, 
                        MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                        _personController.DeletePerson(personId);

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
        /// Обработчик событий для кнопки добавить
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
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
        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
