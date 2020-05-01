namespace DesignPatterns.Creational.Builder
{
    public interface IBuilder
    {
        ComplexProduct Result { get; }

        public void BuildPartA();

        public void BuildPartB();
    }
}