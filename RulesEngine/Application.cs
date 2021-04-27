using System;
using System.Linq;

namespace RulesEngine
{
    public class Application
    {
        public void Run()
        {
            // Using reflection to load all rules in the assembly.
            var ruleType = typeof(IRule);
            var rules = GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as IRule);

            var re = new RulesEngine(rules);

            Console.WriteLine($"21: {re.ApplyRules(new Context { state = 21 })}");
            Console.WriteLine($"19: {re.ApplyRules(new Context { state = 19 })}");
            Console.WriteLine($"9: {re.ApplyRules(new Context { state = 9 })}");
            Console.WriteLine($"4: {re.ApplyRules(new Context { state = 4 })}");
            Console.WriteLine($"7: {re.ApplyRules(new Context { state = 7 })}");
            Console.WriteLine($"6: {re.ApplyRules(new Context { state = 6 })}");
        }
    }
}