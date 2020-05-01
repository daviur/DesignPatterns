namespace DesignPatterns.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private readonly ComplexProduct _result = new ComplexProduct();
        private PartA PartA => default;
        private PartB PartB => default;

        public ComplexProduct Result => _result;

        public void BuildPartA()
        {
            _result.PartA = new PartA();
        }

        public void BuildPartB()
        {
            _result.PartB = new PartB();
        }
    }
}