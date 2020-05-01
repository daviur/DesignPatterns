namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        private ConcreteProductA1 ConcreteProductA1
        {
            get => default;
            set
            {
            }
        }

        private ConcreteProductB1 ConcreteProductB1
        {
            get => default;
            set
            {
            }
        }

        public override AbstractProductA GetProductA()
        {
            return new ConcreteProductA1();
        }

        public override AbstractProductB GetProductB()
        {
            return new ConcreteProductB1();

        }
    }
}