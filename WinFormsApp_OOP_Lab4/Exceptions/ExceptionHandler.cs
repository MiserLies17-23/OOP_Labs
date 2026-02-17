using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_OOP_Lab4.Exceptions
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
