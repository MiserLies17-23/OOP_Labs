namespace WinFormsApp_OOP_Lab2
{
    /// <summary>
    /// Класс-компонент для отображения событий
    /// </summary>
    public class EventProcessing
    {
        /// <summary> Лейбл для вывода событий </summary>
        private Label _label;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="l"> лейбел для вывода событий </param>
        /// <param name="ps"> стэк для подписки на события </param>
        public EventProcessing(Label l, PersonStack ps) 
        {
            _label = l;
            ps.Add += (message) => { l.Text = "Последнее действие: " + message; };
            ps.Remove += (message) => { l.Text = "Последнее действие: " + message; };
        }
    }
}
