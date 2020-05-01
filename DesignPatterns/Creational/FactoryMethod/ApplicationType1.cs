namespace DesignPatterns.Creational.FactoryMethod
{
    public class ApplicationType1 : Application
    {
        public ConcreteProduct1 ConcreteProduct1
        {
            get => default;
            set { }
        }

        private protected override IProduct MakeProduct()
        {
            return new ConcreteProduct1();
        }
    }
}