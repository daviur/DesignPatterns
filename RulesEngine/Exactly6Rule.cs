namespace RulesEngine
{
    public class Exactly6Rule : IRule
    {
        public decimal Evaluate(Context context)
        {
            return IsMatch(context) ? 500 : 0;
        }

        public bool IsMatch(Context context)
        {
            return context.state == 6;
        }
    }
}