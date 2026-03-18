using WinFormsApp_OOP_Lab8.Presenter;
using WinFormsApp_OOP_Lab8.View.Consoles;

namespace WinFormsApp_OOP_Lab8.View
{
    /// <summary>
    /// Форма приветствия
    /// </summary>
    public partial class HelloForm : Form
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public HelloForm()
        {
            InitializeComponent();
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
            PersonPresenter presenter = new(console);
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
            PersonPresenter presenter = new(form);
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
