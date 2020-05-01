namespace DesignPatterns.Creational.Builder
{
    public class Director
    {
        private readonly IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
        }
    }
}