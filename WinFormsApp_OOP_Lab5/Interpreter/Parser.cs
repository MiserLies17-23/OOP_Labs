using WinFormsApp_OOP_Lab5.Interpreter.SearchExpression;
using WinFormsApp_OOP_Lab5.Interpreter.TerminalExpression;
using WinFormsApp_OOP_Lab5.Interpreter.NonTerminalExpression;

namespace WinFormsApp_OOP_Lab5.Interpreter
{
    public class Parser
    {
        public IExpression Parse(SearchQuery query)
        {
            var expressions = new List<IExpression>
            {
                new GenderExpression(query.Gender),
                new AgeExpression(query.Age ?? throw new NullReferenceException()),
                new ProfessionExpression(query.Profession)
            };

            if (query.FirstOperation == Operation.AND)
            {
                return new LogicalExpression(
                    new LogicalExpression(expressions[0],
                    expressions[1],
                    query.FirstOperation),
                    expressions[2],
                    query.SecondOperation);
            }
            else
            {
                return new LogicalExpression(
                    new LogicalExpression(expressions[1],
                    expressions[2],
                    query.SecondOperation),
                    expressions[0],
                    query.FirstOperation);
            }
        }
    }
}
