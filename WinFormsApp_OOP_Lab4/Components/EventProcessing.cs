using WinFormsApp_OOP_Lab4.Models.PersonProxy;

namespace WinFormsApp_OOP_Lab4.Components
{
    public class EventProcessing
    {
        private Label _label;

        private PersonProxy _personProxy;

        public EventProcessing(Label label, PersonProxy personProxy)
        {
            _label = label;
            _personProxy = personProxy;

            _personProxy.SomeAction += OnSomeAction;
        }

        private void OnSomeAction(object? sender, string message)
        {
            UpdateLabel(message);
        }

        private void UpdateLabel(string message)
        {
            if (_label.InvokeRequired)
            {
                _label.Invoke(() => UpdateLabel(message));
                return;
            }
            _label.Text = "Событие PersonProxy: " + message;
        }

        public void ShowFirstEvent()
        {
            if (_personProxy.GetEvents().Any())
            {
                UpdateLabel(_personProxy.GetEvents().Last());
            }
        }
    }
}
