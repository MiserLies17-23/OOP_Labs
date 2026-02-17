namespace WinFormsApp_OOP_Lab1
{
    /// <summary>
    /// Форма приветствия
    /// </summary>
    public partial class HelloForm : Form
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public HelloForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие для кнопки "Ок"
        /// </summary>
        /// <param name="sender"> объект, вызвающий событие </param>
        /// <param name="e"> событие </param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
