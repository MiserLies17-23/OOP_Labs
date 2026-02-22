using WinFormsApp_OOP_Lab3.Exceptions;
using WinFormsApp_OOP_Lab3.Model;
using WinFormsApp_OOP_Lab3.Utils;

namespace WinFormsApp_OOP_Lab3
{
    /// <summary>
    /// Главный UI-компонент приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary> Главный объект Person </summary>
        private Person _person;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _person = PersonValuesGenerator.CreateRandomPerson();
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
                MessageBox.Show("Бригада 13: Пономарев П., Толстоухов В.\n Вариант 13: Человек. Prototype",
                    "Лабораторная работа №3");
                ShowPersonData();
                ShowAllClonePersons();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.ToString(),
                    "Ошибка загрузки",
                    16);
            }
        }

        /// <summary>
        /// Метод для отображения данных человека
        /// </summary>
        private void ShowPersonData()
        {
            GenTextBox.Text = _person.GetGenderToString(); // Вывод поля через специальный метод
            NameTextBox.Text = _person.ToString(); // Вывод поля через переопределённый метод ToString()
            HeightTextBox.Text = _person.Height.ToString();
            WidthTextBox.Text = _person.Width.ToString(); // Вывод поля через метод ToString()
            CountryTextBox.Text = _person.Address.Country; // Непосредственнный вывод поля
            CityTextBox.Text = _person.Address.City;
            AgeTextBox.Text = _person.Age.ToString();
        }

        /// <summary>
        /// Метод для отображения всех клонированных объектов для класса Person
        /// </summary>
        private void ShowAllClonePersons()
        {
            ClonesDataGridView.Rows.Clear();
            foreach (Person p in Person.Persons)
            {
                int rowIndex = ClonesDataGridView.Rows.Add();
                ClonesDataGridView.Rows[rowIndex].Cells[0].Value = Person.Persons.IndexOf(p);
                ClonesDataGridView.Rows[rowIndex].Cells[1].Value = p.ToString();
                if (p.Address == _person.Address)
                    ClonesDataGridView.Rows[rowIndex].Cells[2].Value = "Неглубокое";
                else
                    ClonesDataGridView.Rows[rowIndex].Cells[2].Value = "Глубокое";
                ClonesDataGridView.Rows[rowIndex].Cells[3].Value = "Показать";
            }
        }

        /// <summary>
        /// Обработчик событий для кнопки "Изменить"
        /// </summary>
        /// <param name="sender"> объект-отправитель (кнопка) </param>
        /// <param name="e"> событие </param>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new(_person);
                editForm.ShowDialog();
                ShowPersonData();
                ShowAllClonePersons();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.ToString(),
                    "Ошибка изменения",
                    16);
            }
        }

        /// <summary>
        /// Обработчки событий для кнопки "Глуб. клонирование"
        /// </summary>
        /// <param name="sender"> объект-отправитель (кнопка) </param>
        /// <param name="e"> событие </param>
        private void CloneButton_Click(object sender, EventArgs e)
        {
            try
            {
                Person clonePerson = (Person)_person.DeepClone();
                ShowAllClonePersons();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.ToString(),
                    "Ошибка глубокого клонирования",
                    16);
            }
        }

        /// <summary>
        /// Обработчик событий для кнопки "Поверхн. копирование"
        /// </summary>
        /// <param name="sender"> объект-отправитель (кнопка) </param>
        /// <param name="e"> событие </param>
        private void ShallowCloneButton_Click(object sender, EventArgs e)
        {
            try
            {
                Person clonePerson = (Person)_person.ShallowClone();
                ShowPersonData();
                ShowAllClonePersons();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.ToString(),
                    "Ошибка поверхностного клонирования",
                    16);
            }
        }

        /// <summary>
        /// Обработчик событий для кнопки "Показать" в таблице клонированных объектов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClonesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 3)
                {
                    Person p = Person.Persons.ElementAt(e.RowIndex);
                    CloneForm cloneForm = new(p);
                    cloneForm.ShowDialog();
                    ShowPersonData();
                    ShowAllClonePersons();
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
