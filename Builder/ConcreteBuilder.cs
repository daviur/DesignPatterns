namespace Builder
{
    public class ConcreteBuilder : IBuilder
    {
        public ComplexProduct Result { get; } = new();

        public void BuildPartA()
        {
            Result.PartA = new PartA();
        }

        public void BuildPartB()
        {
            Result.PartB = new PartB();
        }
    }
}