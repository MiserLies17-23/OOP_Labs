using WinFormsApp_OOP_Lab8.Presenter;
using WinFormsApp_OOP_Lab8.View.Consoles;

namespace WinFormsApp_OOP_Lab8.View
{
    /// <summary>
    /// Форма приветствия
    /// </summary>
    public partial class HelloForm : Form
    {
        /// <summary> Презентер для управления поведением View-компонентов </summary>
        private PersonPresenter _personPresenter;
        
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public HelloForm()
        {
            InitializeComponent();
            _personPresenter = new();
        }

        /// <summary>
        /// Обработчик событий для кнопки "Консоль"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Сообытие </param>
        private void ConsoleButton_Click(object sender, EventArgs e)
        {
            ConsoleButton.Enabled = false;
            FormButton.Enabled = false;

            ConsoleView console = new();
            _personPresenter.SetView(console);
            console.Run();

            ConsoleButton.Enabled = true;
            FormButton.Enabled = true;
        }

        /// <summary>
        /// Обработчик событий для кнопки "Форма"
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        private void FormButton_Click(object sender, EventArgs e)
        {
            ConsoleButton.Enabled = false;
            FormButton.Enabled = false;

            MainForm form = new();
            _personPresenter.SetView(form);
            form.ShowDialog();

            ConsoleButton.Enabled = true;
            FormButton.Enabled = true;
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
