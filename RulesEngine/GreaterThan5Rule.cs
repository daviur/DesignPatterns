namespace RulesEngine
{
    public class GreaterThan5Rule : IRule
    {
        public decimal Evaluate(Context context)
        {
            return IsMatch(context) ? 50 : 0;
        }

        public bool IsMatch(Context context)
        {
            return context.state > 5;
        }
    }
}