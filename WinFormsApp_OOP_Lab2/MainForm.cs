using WinFormsApp_OOP_Lab1.Exceptions;
using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab2
{
    /// <summary>
    /// Главный UI-компонент
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary> Стэк для объектов Person </summary>
        private PersonStack _personStack;

        /// <summary> Компонент для отображения событий </summary>
        private EventProcessing _eventProcessing;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _personStack = new PersonStack();
            _eventProcessing = new(ActivityLabel, _personStack);
            ShowStackContent();
        }

        /// <summary>
        /// Обработчик события для загрузки формы
        /// </summary>
        /// <param name="sender"> объект-отправитель (форма) </param>
        /// <param name="e"> событие </param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Бригада 13: Пономарев П., Толстоухов В.\n Вариант 13: Человек. Stack",
                "Лабораторная работа №2");
            MeasureListView_Load();
        }

        /// <summary>
        /// Метод для загрузки таблицы сравнения
        /// </summary>
        private void MeasureListView_Load()
        {
            MeasureListView.Columns.Clear();

            MeasureListView.Columns.Add("Структура", 100);
            MeasureListView.Columns.Add("Время вставки (мс)", 150);
            MeasureListView.Columns.Add("Последовательная выборка (мс)", 250);
            MeasureListView.Columns.Add("Случайная выборка (мс)", 190);
        }

        /// <summary>
        /// Обработчик события для кнопки "Удалить"
        /// Метод для удаления объекта из стэка
        /// </summary>
        /// <param name="sender"> объект-отправитель (кнопка) </param>
        /// <param name="e"> событие </param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_personStack.Stack.Count > 0)
                    _personStack.RemoveItem();
                else
                    MessageBox.Show("Нельзя удалить элемент: стэк пуст!", "Ошибка удаления");
                ShowStackContent();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка удаления",
                    16);
            }
        }

        /// <summary>
        /// Обработчик события для кнопки "Добавить"
        /// Метод для добавления объекта в стэк
        /// </summary>
        /// <param name="sender"> объект-отправитель (кнопка) </param>
        /// <param name="e"> событие </param>
        private void AddButton_Click(Object sender, EventArgs e)
        {
            try
            {
                Person p = RandomValuesGenerator.CreateRandomPerson();
                _personStack.AddItem(p);
                ShowStackContent();
            }
            catch (Exception ex)
            {
                ExceptionHandler.MessageBox(
                    IntPtr.Zero,
                    ex.ToString(),
                    "Ошибка добавления",
                    16);
            }
        }

        /// <summary>
        /// Обработчик события для кнопки "Сравнить"
        /// Метод для сравнения производительности стэка и списка
        /// </summary>
        /// <param name="sender"> объект-отправитель </param>
        /// <param name="e"> событие </param>
        private void CompareButton_Click (object sender, EventArgs e)
        {
            MeasureListView.Items.Clear();
            ListViewItem stackItem = new("Cтэк");
            stackItem.SubItems.Add(MeasureComponent.InsertInStack().ToString());
            stackItem.SubItems.Add(MeasureComponent.ConsistentStackSelection().ToString());
            stackItem.SubItems.Add(MeasureComponent.RandomStackSelection().ToString());
            MeasureListView.Items.Add(stackItem);

            ListViewItem arrayItem = new("Массив");
            arrayItem.SubItems.Add(MeasureComponent.InsertInArray().ToString());
            arrayItem.SubItems.Add(MeasureComponent.ConsistentArraySelection().ToString());
            arrayItem.SubItems.Add(MeasureComponent.RandomArraySelection().ToString());
            MeasureListView.Items.Add(arrayItem);
        }

        /// <summary>
        /// Метод для отображения содержимого стэка
        /// </summary>
        private void ShowStackContent()
        {
            if (_personStack.Stack.Count == 0)
            {
                ContentLabel.Text = "Содержимое стэка: стэк пуст!";
                return;
            }
            string text = "Содержимое стэка: ";
            foreach (Person p in _personStack.Stack)
            {
                text += p.ToString() + ", ";
            }
            ContentLabel.Text = text.Trim().Substring(0, text.Length-2);
        }
    }
}
