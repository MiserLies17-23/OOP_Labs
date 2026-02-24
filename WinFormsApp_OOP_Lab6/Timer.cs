namespace WinFormsApp_OOP_Lab6
{
    public class Timer
    {
        private Label _label;
        private static bool _IS_RUNNING = false;

        public Timer(Label label)
        {
            _label = label;
            _IS_RUNNING = true;
        }

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
