using System.Runtime.InteropServices;

namespace WinFormsApp_OOP_Lab3
{
    public class ExceptionHandler
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(
            IntPtr hWnd,
            string text,
            string caption,
            uint type);
    }
}
