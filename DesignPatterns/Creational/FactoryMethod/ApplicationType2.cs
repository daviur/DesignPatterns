namespace DesignPatterns.Creational.FactoryMethod
{
    public class ApplicationType2 : Application
    {
        public SimpleFactory.ConcreteProduct2 ConcreteProduct2
        {
            get => default;
            set { }
        }

        private protected override IProduct MakeProduct()
        {
            return new ConcreteProduct2();
        }
    }
}