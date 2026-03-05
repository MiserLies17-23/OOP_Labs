namespace WinFormsApp_OOP_Lab6
{
    /// <summary>
    /// Класс Таймер 
    /// </summary>
    public class Timer
    {
        /// <summary> Лейбл для отображения времени </summary>
        private Label _label;

        /// <summary>
        /// Флаг работы таймеры
        /// </summary>
        private static bool _IS_RUNNING = false;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="label"> лейбл </param>
        public Timer(Label label)
        {
            _label = label;
            _IS_RUNNING = true;
        }

        /// <summary>
        /// Асинхронный метод для работы таймера
        /// </summary>
        /// <returns></returns>
        public async Task TimeAsync()
        {
            while (_IS_RUNNING)
            {
                await Task.Run(() =>
                {
                    _label.Text = "Время: " + DateTime.Now.ToString("HH:mm:ss");
                });
            }
        }
    }
}
