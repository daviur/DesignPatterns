namespace DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public void Run()
        {
            var director = new Director();
            var builder = new ConcreteBuilder();

            director.Construct(builder);
            var product = builder.Result;
        }
    }
}