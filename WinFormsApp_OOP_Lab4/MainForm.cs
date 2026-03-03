using WinFormsApp_OOP_Lab4.Components;
using WinFormsApp_OOP_Lab4.Exceptions;
using WinFormsApp_OOP_Lab4.Forms;
using WinFormsApp_OOP_Lab4.Models.PersonProxy;

namespace WinFormsApp_OOP_Lab4
{
    /// <summary>
    /// Главный UI-компонент приложения
    /// Форма для отображения данных человека
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary> Объект PersonProxy для изменения даннных в Person </summary>
        private PersonProxy _personProxy;

        /// <summary> Объект EventProcessing для отображения последних событий </summary>
        private EventProcessing _eventProcessing;

        /// <summary>
        /// Конструктор по усолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _personProxy = new();
            _eventProcessing = new(EventLabel, _personProxy);
        }

        /// <summary>
        /// Обработчик события для загрузки формы
        /// </summary>
        /// <param name="sender"> объект-отправитель (форма) </param>
        /// <param name="e"> событие </param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Бригада №13: Пономарёв П., Толстоухов В." +
                "\n Вариант 13: Человек. Proxy", "Лфбораторная работа №4");
            _eventProcessing.ShowFirstEvent();
            ShowPersonData();
        }

        /// <summary>
        /// Метод для отображения данных человека
        /// </summary>
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

        /// <summary>
        /// Обработчик события для кнопки "Изменить"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
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
                    "������ ���������",
                    16);
            }
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
