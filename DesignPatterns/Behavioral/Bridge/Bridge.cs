namespace DesignPatterns.Behavioral.Bridge
{
    public class Bridge
    {
        private readonly StrategyClassA _strategyA;
        private readonly StrategyClassB _strategyB;

        public Bridge(StrategyClassA a, StrategyClassB b)
        {
            _strategyA = a;
            _strategyB = b;
        }

        public string CalculateA()
        {
            return _strategyA.Calculate();
        }

        public string CalculateB()
        {
            return _strategyB.Calculate();
        }

        public DegreeOfFreedom GetStrategyAAndBridgeTo(DegreeOfFreedom next)
        {
            _strategyA.Next = next;
            return _strategyA;
        }

        public DegreeOfFreedom GetStrategyBAndBridgeTo(DegreeOfFreedom next = null)
        {
            _strategyB.Next = next;
            return _strategyB;
        }

        public string Operation()
        {
            var start =
                this.GetStrategyAAndBridgeTo(
                    this.GetStrategyBAndBridgeTo());

            return start.handle();
        }
    }
}