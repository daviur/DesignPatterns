using System;
using System.Collections.Generic;

namespace RulesEngine
{
    /// <summary>
    ///     The Rules Engine contains the algorithm to combine the rules.
    ///     It can be as complex as necessary.
    ///     There could be dependency between the rules.
    /// </summary>
    public class RulesEngine
    {
        private readonly List<IRule> _rules = new();

        /// <summary>
        ///     The list of rules to evaluate.
        /// </summary>
        /// <param name="rules"></param>
        public RulesEngine(IEnumerable<IRule> rules)
        {
            _rules.AddRange(rules);
        }

        public decimal ApplyRules(Context context)
        {
            decimal result = 0;
            foreach (var rule in _rules) result = Math.Max(result, rule.Evaluate(context));
            return result;
        }
    }
}