namespace RulesEngine
{
    public class LessThan10Rule : IRule
    {
        public decimal Evaluate(Context context)
        {
            return IsMatch(context) ? 200 : 0;
        }

        public bool IsMatch(Context context)
        {
            return context.state < 10;
        }
    }
}