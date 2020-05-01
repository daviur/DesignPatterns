namespace DesignPatterns.Creational.AbstractFactory
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
            set
            {
            }
        }

        public override AbstractProductA GetProductA()
        {
            return new ConcreteProductA2();
        }

        public override AbstractProductB GetProductB()
        {
            return new ConcreteProductB2();
        }
    }
}