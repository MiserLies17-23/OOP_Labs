namespace WinFormsApp_OOP_Lab6
{
    /// <summary>
    /// Класс для обработки асинхронных событий
    /// </summary>
    public class EventProcessing
    {
        /// <summary> Лейбл для отображения событий </summary>
        private Label _label;

        /// <summary>
        /// Экземпляр VectorAsync для асинхронной работы с вектором
        /// </summary>
        private AsyncVector _vecAsync;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="label"> лейбл </param>
        /// <param name="vecAsync"> экземпляр VectorAsync</param>
        public EventProcessing (Label label, AsyncVector vecAsync)
        {
            _label = label;
            _vecAsync = vecAsync;

            _vecAsync.SomeAction += OnAction;
        }

        /// <summary>
        /// Метод для обработки событий
        /// </summary>
        /// <param name="sender"> объект отправитель (класс) </param>
        /// <param name="message"> сообщение </param>
        public void OnAction(object? sender, string message)
        {
            if (_label.InvokeRequired)
            {
                _label.Invoke(new Action(() =>
                {
                    _label.Text = message;
                }));
            }
            else
            {
                _label.Text = message;
            }
        }
    }
}
