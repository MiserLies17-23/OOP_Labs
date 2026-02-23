namespace WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression
{
    public class AgeExpression : IExpression
    {
        private readonly AgeRange _age;

        public AgeExpression(AgeRange age)
        {
            _age = age;
        }

        public bool Interpret(Context context)
        {
            return _age.Down <= context.CurrentPerson.Age &&
                context.CurrentPerson.Age <= _age.Top;
        }
    }
}
