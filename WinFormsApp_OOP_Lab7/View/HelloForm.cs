using WinFormsApp_OOP_Lab7.View.Consoles;

namespace WinFormsApp_OOP_Lab7.View
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
            console.Run();

            ConsoleButton.Enabled = true;
            FormButton.Enabled = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormButton_Click(object sender, EventArgs e)
        {
            ConsoleButton.Enabled = false;
            FormButton.Enabled = false;
            
            MainForm form = new();
            form.ShowDialog();

            ConsoleButton.Enabled = true;
            FormButton.Enabled = true;
        }
    }
}
