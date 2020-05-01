namespace DesignPatterns.Creational.AbstractFactory
{
    public class Application
    {
        private readonly AbstractFactory _factory;

        public Application(AbstractFactory factory)
        {
            _factory = factory;
        }

        public AbstractProductA AbstractProductA
        {
            get => default;
            set { }
        }

        public AbstractFactory AbstractFactory
        {
            get => default;
            set { }
        }

        public AbstractProductB AbstractProductB
        {
            get => default;
            set { }
        }

        public IProduct IProduct
        {
            get => default;
            set { }
        }

        public void Run()
        {
            #region Using simple implementation

            var productA = _factory.MakeProductA();
            productA.DoSomething();
            var productB = _factory.MakeProductB();
            productB.DoSomething();

            #endregion

            #region Using more flexible but not type safe implementation

            var productTypes = _factory.GetAllProducts();

            foreach (var productType in productTypes)
            {
                var product = _factory.Make(productType);
                product.DoSomething();
            }

            #endregion
        }
    }
}