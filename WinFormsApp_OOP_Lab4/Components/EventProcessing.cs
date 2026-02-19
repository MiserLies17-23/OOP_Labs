using WinFormsApp_OOP_Lab4.Models.PersonProxy;

namespace WinFormsApp_OOP_Lab4.Components
{
    /// <summary>
    /// Компонент для отображения соббытий в PersonProxy
    /// </summary>
    public class EventProcessing
    {
        /// <summary>
        /// Лейбл для отображения событий
        /// </summary>
        private Label _label;

        /// <summary>
        /// Объект PersonProxy для подписки на события
        /// </summary>
        private PersonProxy _personProxy;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="label"> лейбл </param>
        /// <param name="personProxy"> объект PersonProxy </param>
        public EventProcessing(Label label, PersonProxy personProxy)
        {
            _label = label;
            _personProxy = personProxy;

            _personProxy.SomeAction += OnSomeAction;
        }

        /// <summary>
        /// Подписка на событие
        /// </summary>
        /// <param name="sender"> объект-отправитель </param>
        /// <param name="message"> сообщение </param>
        private void OnSomeAction(object? sender, string message)
        {
            UpdateLabel(message);
        }

        /// <summary>
        /// Метод для обновления лейбла
        /// </summary>
        /// <param name="message"> сообщение </param>
        private void UpdateLabel(string message)
        {
            if (_label.InvokeRequired)
            {
                _label.Invoke(() => UpdateLabel(message));
                return;
            }
            _label.Text = "Событие PersonProxy: " + message;
        }

        /// <summary>
        /// Метод для отображения первого события
        /// Необходим для загрузки формы
        /// </summary>
        public void ShowFirstEvent()
        {
            if (_personProxy.GetEvents().Any())
                UpdateLabel(_personProxy.GetEvents().Last()); // возвращает последнее случившееся!
        }
    }
}
