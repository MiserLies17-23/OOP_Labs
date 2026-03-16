using System.Runtime.InteropServices;

namespace WinFormsApp_OOP_Lab7.View.Consoles
{
    /// <summary>
    /// Консольный менеджер
    /// </summary>
    public class ConsoleManager
    {
        /// <summary>
        /// Метод выделяет новую консоль для вызывающего процесса
        /// Внешний импортируемый метод из динамической библиотеки DLL
        /// </summary>
        /// <returns> Логический результат запуска </returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        /// <summary>
        /// Метод отсоединяет вызывающий процесс от консоли
        /// Внешний импортируемый метод из динамической библиотеки DLL
        /// </summary>
        /// <returns> Логический результат запуска </returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();

        /// <summary>
        /// Метод для показа консоли
        /// </summary>
        public static void Show()
        {
            AllocConsole();
        }

        /// <summary>
        /// Метод для закрытия консоли
        /// </summary>
        public static void Close()
        {
            FreeConsole();
        }
    }
}
