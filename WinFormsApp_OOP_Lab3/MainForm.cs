using System.Windows.Forms;

namespace WinFormsApp_OOP_Lab3
{
    public partial class MainForm : Form
    {

        private Person person;

        public MainForm()
        {
            InitializeComponent();
            person = PersonValuesGenerator.CreateRandomPerson();
            ShowPersonData();
            ShowAllClonePersons();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Бригада 13: Пономарев П., Толстоухов В.\n Вариант 13: Человек. Prototype",
                "Лабораторная работа №3");
        }

        private void ShowPersonData()
        {
            GenTextBox.Text = person.GetGenderToString(); // Вывод поля через специальный метод
            NameTextBox.Text = person.ToString(); // Вывод поля через переопределённый метод ToString()
            HeightTextBox.Text = person.Height.ToString();
            WidthTextBox.Text = person.Width.ToString(); // Вывод поля через метод ToString()
            CountryTextBox.Text = person.Country; // Непосредственнный вывод поля
            CityTextBox.Text = person.City;
            AgeTextBox.Text = person.Age.ToString();
        }

        private void ShowAllClonePersons()
        {
            ClonesDataGridView.Rows.Clear();
            foreach (Person p in Person.Persons)
            {
                int rowIndex = ClonesDataGridView.Rows.Add();
                ClonesDataGridView.Rows[rowIndex].Cells[0].Value = p.ToString();
                if (p == person)
                    ClonesDataGridView.Rows[rowIndex].Cells[1].Value = "Неглубокое";
                else
                    ClonesDataGridView.Rows[rowIndex].Cells[1].Value = "Глубокое";
                ClonesDataGridView.Rows[rowIndex].Cells[2].Value = "Показать";
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new(person);
                editForm.ShowDialog();
                ShowPersonData();
                ShowAllClonePersons();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка изменения",
                    16);
            }
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            try
            {
                Person clonePerson = (Person)person.DeepClone();
                Person.Persons.Add(clonePerson);
                ShowAllClonePersons();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка глубокого клонирования",
                    16);
            }
        }

        private void ShallowCloneButton_Click(object sender, EventArgs e)
        {
            try
            {
                Person clonePerson = (Person)person.ShallowCopy();
                Person.Persons.Add(clonePerson);
                ShowAllClonePersons();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка поверхностного клонирования",
                    16);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClonesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 2)
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
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка",
                    16);
            }
        }
    }
}
