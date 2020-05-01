using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        private ConcreteProductA1 ConcreteProductA1
        {
            get => default;
            set { }
        }

        private ConcreteProductB1 ConcreteProductB1
        {
            get => default;
            set { }
        }

        public override AbstractProductA MakeProductA()
        {
            return new ConcreteProductA1();
        }

        public override AbstractProductB MakeProductB()
        {
            return new ConcreteProductB1();
        }

        public override IProduct Make(string productType)
        {
            return productType switch
            {
                "AbstractProductA" => new ConcreteProductA1(),
                "AbstractProductB" => new ConcreteProductB1(),
                _ => throw new ArgumentException("Wrong product type", productType)
            };
        }

        public override string[] GetAllProducts()
        {
            return new[] {"AbstractProductA", "AbstractProductB"};
        }
    }
}