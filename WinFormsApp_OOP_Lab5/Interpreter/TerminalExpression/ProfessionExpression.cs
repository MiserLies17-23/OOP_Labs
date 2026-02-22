using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression
{
    public class ProfessionExpression : IExpression
    {
        private readonly Profession _profession;

        public ProfessionExpression(Profession profession)
        {
            _profession = profession;
        }

        public bool Interpret(Context context)
        {
            return _profession == context.CurrentPerson.Profession;
        }
    }
}
