namespace WinFormsApp_OOP_Lab5.Interpreter.NonTerminalExpression
{
    public class LogicalExpression : IExpression
    {
        private readonly IExpression _left;

        private readonly IExpression _right;

        private readonly Operation _operator;

        public LogicalExpression(IExpression left, IExpression right, Operation @operator)
        {
            _left = left;
            _right = right;
            _operator = @operator;
        }

        public bool Interpret(Context context)
        {
            return _operator switch
            {
                Operation.AND => _left.Interpret(context) && _right.Interpret(context),
                Operation.OR => _left.Interpret(context) || _right.Interpret(context),
                _ => throw new NotImplementedException("Оператор не распознан!")
            };
        }
    }
}
