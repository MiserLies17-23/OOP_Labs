namespace WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression
{
    public class AgeRange
    {
        public int Down { get; set; }
        public int Top { get; set; }

        public AgeRange()
        {
            Down = 0;
            Top = 0;
        }

        public AgeRange(int down, int top)
        {
            Down = down;
            Top = top;
        }
    }
}
