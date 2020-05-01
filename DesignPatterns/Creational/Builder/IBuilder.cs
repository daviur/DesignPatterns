namespace DesignPatterns.Creational.Builder
{
    public interface IBuilder
    {
        public void BuildPartA();

        public void BuildPartB();

        ComplexProduct Result { get; }
    }
}
