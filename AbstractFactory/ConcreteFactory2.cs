using System;
using DesignPatterns.Creational.AbstractFactory;

namespace AbstractFactory
{
    public class ConcreteFactory2 : AbstractFactory
    {
        private ConcreteProductA2 ConcreteProductA2
        {
            get => default;
            set { }
        }

        private ConcreteProductB2 ConcreteProductB2
        {
            get => default;
            set { }
        }

        public override AbstractProductA MakeProductA()
        {
            return new ConcreteProductA2();
        }

        public override AbstractProductB MakeProductB()
        {
            return new ConcreteProductB2();
        }

        public override IProduct Make(string productType)
        {
            return productType switch
            {
                "AbstractProductA" => new ConcreteProductA2(),
                "AbstractProductB" => new ConcreteProductB2(),
                _ => throw new ArgumentException("Wrong product type", productType)
            };
        }

        public override string[] GetAllProducts()
        {
            return new[] {"AbstractProductA", "AbstractProductB"};
        }
    }
}