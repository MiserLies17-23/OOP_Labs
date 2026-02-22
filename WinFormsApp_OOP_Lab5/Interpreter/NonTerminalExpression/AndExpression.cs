namespace WinFormsApp_OOP_Lab5.Interpreter.NonTerminalExpression
{
    public class AndExpression : IExpression
    {
        private readonly IExpression _left;

        private readonly IExpression _right;

        public AndExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public bool Interpret(Context context)
        {
            return _left.Interpret(context) && _right.Interpret(context);
        }
    }
}
