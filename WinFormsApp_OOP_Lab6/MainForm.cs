namespace WinFormsApp_OOP_Lab6
{
    /// <summary>
    /// UI-компонент приложения
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary> Таймер </summary>
        private readonly Timer _timer;

        /// <summary> Объект AsyncVector для асинхронной работы с вектором </summary>
        private AsyncVector _vectorAsync;

        /// <summary> Объект EventProcessing для отображения событий </summary>
        private EventProcessing _event;

        /// <summary> Вектор целочисленных элементов </summary>
        private List<int> _list;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _timer = new(TimeLabel);
            _vectorAsync = new AsyncVector();
            _event = new EventProcessing(EventLabel, _vectorAsync);
            _list = [];
        }

        /// <summary>
        /// Обработчик событий для загрузки формы
        /// </summary>
        /// <param name="sender"> Объект-отправитель (форма) </param>
        /// <param name="e"> Событие </param>
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
                    Handle,
                    ex.Message,
                    "Ошибка загрузки",
                    16);
            }
        }

        /// <summary>
        /// Обработчик событий для кнопки "Создать"
        /// Асинхронное создание вектора 
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
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
                    Handle,
                    ex.Message,
                    "Ошибка создания вектора",
                    16);
            }
        }

        /// <summary>
        /// Обработчик событий для кнопки "Найти"
        /// Асинхронный поиск минимального значения
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
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
                    Handle,
                    ex.Message,
                    "Ошибка поиска минимального",
                    16);
            }
        }

        /// <summary>
        /// Обработчик событий для кнопки "Сортировать"
        /// Асинхронная сортировка вектора
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
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
                    Handle,
                    ex.Message,
                    "Ошибка сортировки",
                    16);
            }
        }

        /// <summary>
        /// Обработчик событий для кнопки "Сгенерировать"
        /// Асинхронная генерация случайного числа
        /// </summary>
        /// <param name="sender"> Объект-отправитель (кнопка) </param>
        /// <param name="e"> Событие </param>
        /// <exception cref="ArgumentException"> Исключение неверного аргумента для нижней границы диапазона </exception>
        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int down = (int)DownNumericUpDown.Value;
                int top = (int)TopNumericUpDown.Value;
                if (down >= top)
                    throw new ArgumentException("Нижняя границе не может быть выше верхней!");
                int value = await AsyncRandomValueGenerator.Generate(down, top);
                RandomValueLabel.Text = value.ToString();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    Handle,
                    ex.Message,
                    "Ошибка генерации случайного значения",
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
