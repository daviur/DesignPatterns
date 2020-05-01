namespace DesignPatterns.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        public ComplexProduct Result { get; } = new ComplexProduct();

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