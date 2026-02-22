using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Forms
{
    public partial class ShowPersonForm : Form
    {
        private readonly Person _person;

        private readonly int _id;

        public ShowPersonForm(Person person, int id)
        {
            InitializeComponent();
            _person = person;
            _id = id;
        }
        
        private void ShowPersonForm_Load(object sender, EventArgs e)
        {
            ShowPersonData();
        }
        
        private void ShowPersonData()
        {
            IdLabel.Text += _id.ToString();
            GenTextBox.Text = _person.GetGenderToString();
            NameTextBox.Text = _person.ToString();
            HeightTextBox.Text = _person.Height.ToString();
            WidthTextBox.Text = _person.Weight.ToString();
            CountryTextBox.Text = _person.Country;
            ProfessionTextBox.Text = _person.GetProfessionToString();
            AgeTextBox.Text = _person.Age.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
