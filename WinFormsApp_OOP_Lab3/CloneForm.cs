namespace WinFormsApp_OOP_Lab3
{
    public partial class CloneForm : Form
    {
        private Person clonePerson;

        public CloneForm(Person _clonePerson)
        {
            InitializeComponent();
            clonePerson = _clonePerson;
            ShowClonePersonData();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new(clonePerson);
                editForm.ShowDialog();
                ShowClonePersonData();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка переполнения памяти",
                    16);
            }
        }

        private void ShowClonePersonData()
        {
            GenTextBox.Text = clonePerson.GetGenderToString(); // Вывод поля через специальный метод
            NameTextBox.Text = clonePerson.ToString(); // Вывод поля через переопределённый метод ToString()
            HeightTextBox.Text = clonePerson.Height.ToString();
            WidthTextBox.Text = clonePerson.Width.ToString(); // Вывод поля через метод ToString()
            CountryTextBox.Text = clonePerson.Country; // Непосредственнный вывод поля
            CityTextBox.Text = clonePerson.City;
            AgeTextBox.Text = clonePerson.Age.ToString();
        }

        private void HudeButton_Click(object sender, EventArgs e)
        {
            int index = Person.Persons.IndexOf(clonePerson);
            if (index != -1)
                Person.Persons[index] = clonePerson;
            Hide();
        }
    }
}
