namespace RulesEngine
{
    public class LessThan20Rule : IRule
    {
        public decimal Evaluate(Context context)
        {
            return IsMatch(context) ? 100 : 0;
        }

        public bool IsMatch(Context context)
        {
            return context.state < 20;
        }
    }
}