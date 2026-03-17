using WinFormsApp_OOP_Lab8.Presenter;
using WinFormsApp_OOP_Lab8.View.Consoles;

namespace WinFormsApp_OOP_Lab8.View
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
