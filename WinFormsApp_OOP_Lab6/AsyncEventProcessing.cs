namespace WinFormsApp_OOP_Lab6
{
    public class AsyncEventProcessing
    {
        private Label _label;

        private VectorAsync _vecAsync;

        public AsyncEventProcessing (Label label, VectorAsync vecAsync)
        {
            _label = label;
            _vecAsync = vecAsync;

            _vecAsync.SomeAction += OnAction;
        }

        public void OnAction(object? sender, string message)
        {
            _label.Text = message;
        }
    }
}
