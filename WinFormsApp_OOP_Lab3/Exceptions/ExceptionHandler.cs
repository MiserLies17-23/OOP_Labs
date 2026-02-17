using System.Runtime.InteropServices;

namespace WinFormsApp_OOP_Lab3.Exceptions
{
    public class ExceptionHandler
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern nint MessageBox(
            nint hWnd,
            string text,
            string caption,
            uint type);
    }
}
