using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression
{
    public class GenderExpression : IExpression
    {
        private readonly Gender _gender;

        public GenderExpression(Gender gender)
        {
            _gender = gender;
        }

        public bool Interpret(Context context)
        {
            return _gender == context.CurrentPerson.Gen;
        }

        public override string ToString()
        {
            return _gender == Gender.MALE ? "Муж" : "Жен";
        }
    }
}
