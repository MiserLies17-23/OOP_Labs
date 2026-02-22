namespace WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression
{
    public class AgeExpression : IExpression
    {
        private readonly int _age;

        public AgeExpression(int age)
        {
            _age = age;
        }

        public bool Interpret(Context context)
        {
            return _age == context.CurrentPerson.Age;
        }
    }
}
