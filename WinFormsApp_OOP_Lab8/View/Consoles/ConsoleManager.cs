using System.Runtime.InteropServices;

namespace WinFormsApp_OOP_Lab8.View.Consoles
{
    public class ConsoleManager
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();

        public static void Show()
        {
            AllocConsole();
        }

        public static void Close()
        {
            FreeConsole();
        }
    }
}
