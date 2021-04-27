using System;

namespace FactoryMethod
{
    public abstract class Application
    {
        public IProduct IProduct
        {
            get => default;
            set { }
        }

        public void Run()
        {
            Console.WriteLine("Need product");
            var product = MakeProduct();
            product.DoSomething();
        }

        private protected abstract IProduct MakeProduct();
    }
}