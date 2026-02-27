namespace WinFormsApp_OOP_Lab6
{
    public partial class MainForm : Form
    {

        private Timer _timer;

        private VectorAsync _vectorAsync;

        private AsyncEventProcessing _event;

        private List<int> _list;

        public MainForm()
        {
            InitializeComponent();
            _timer = new(TimeLabel);
            _vectorAsync = new VectorAsync();
            _event = new AsyncEventProcessing(EventLabel, _vectorAsync);
            _list = [];
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Бригада 13: Пономарёв П., Толстоухов В.\nВариант 13: Поиск минимального значения на векторе",
                    "Лабораторная работа №6");
                await _timer.TimeAsync();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка загрузки",
                    16);
            }
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SortingPanel.Enabled = false;
                MinVectorPanel.Enabled = false;
                _list = await _vectorAsync.CreateVector((int)LengthNumericUpDown.Value,
                    (int)MinNumericUpDown.Value, (int)MaxNumericUpDown.Value);
                StatusValueLabel.Text = await _vectorAsync.SortingCheck(_list) ? "Да" : "Нет";
                MinVectorPanel.Enabled = true;
                SortingPanel.Enabled = true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка создания вектора",
                    16);
            }
        }

        private async void FoundButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreateButton.Enabled = false;
                SortingPanel.Enabled = false;
                int min = await _vectorAsync.FoundMinimum(_list);
                MinValueLabel.Text = min.ToString();
                SortingPanel.Enabled = true;
                CreateButton.Enabled = true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка поиска минимального",
                    16);
            }
        }

        private async void SortButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreateButton.Enabled = false;
                MinVectorPanel.Enabled = false;
                await _vectorAsync.InclusiveSorting(_list);
                StatusValueLabel.Text = await _vectorAsync.SortingCheck(_list) ? "Да" : "Нет";
                MinVectorPanel.Enabled = true;
                CreateButton.Enabled = true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка сортировки",
                    16);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
