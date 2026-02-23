using WinFormsApp_OOP_Lab5.Interpreter.NonTerminalExpression;
using WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression;
using WinFormsApp_OOP_Lab5.Model;

namespace WinFormsApp_OOP_Lab5.Interpreter.SearchExpression
{
    public class SearchQuery
    {
        public Gender Gender { get; set; }
        public Operation FirstOperation { get; set; }
        public AgeRange? Age {get; set;}
        public Operation SecondOperation { get; set; }
        public Profession Profession { get; set; }
    }
}
