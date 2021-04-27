namespace RulesEngine
{
    /// <summary>
    ///     Rules should be as simple as possible.
    ///     Rules should be stateless.
    ///     Rules should be read-only.
    /// </summary>
    public interface IRule
    {
        public decimal Evaluate(Context context);

        /// <summary>
        ///     This is optional if rules engine needs to check if the rule matches or not.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public bool IsMatch(Context context);
    }
}