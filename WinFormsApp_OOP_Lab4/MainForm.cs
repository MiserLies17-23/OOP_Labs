using WinFormsApp_OOP_Lab4.Components;
using WinFormsApp_OOP_Lab4.Exceptions;
using WinFormsApp_OOP_Lab4.Models.PersonProxy;

namespace WinFormsApp_OOP_Lab4
{
    public partial class MainForm : Form
    {
        private PersonProxy _personProxy;

        private EventProcessing _eventProcessing;
        public MainForm()
        {
            InitializeComponent();
            _personProxy = new();
            _eventProcessing = new(EventLabel, _personProxy);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Бригада №13: Пономарев П., Толстоухов В." +
                "\n Вариант 13: Человек. Proxy", "Лабораторная работа №4");
            _eventProcessing.ShowFirstEvent();
            ShowPersonData();
        }

        private void ShowPersonData()
        {
            GenTextBox.Text = _personProxy.GetGenderToString(); 
            NameTextBox.Text = _personProxy.ToString();
            HeightTextBox.Text = _personProxy.Height.ToString();
            WidthTextBox.Text = _personProxy.Weight.ToString();
            CountryTextBox.Text = _personProxy.Country;
            CityTextBox.Text = _personProxy.City;
            AgeTextBox.Text = _personProxy.Age.ToString();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                EditForm editForm = new(_personProxy);
                editForm.ShowDialog();
                ShowPersonData();
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
