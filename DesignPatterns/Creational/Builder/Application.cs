namespace DesignPatterns.Creational.Builder
{
    public class Application
    {
        public ConcreteBuilder ConcreteBuilder
        {
            get => default;
            set { }
        }

        public Director Director
        {
            get => default;
            set { }
        }

        public void Run()
        {
            var builder = new ConcreteBuilder();
            var director = new Director(builder);

            director.Construct();
            var product = builder.Result;
        }
    }
}