using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Creational.Prototype
{
    public class Client
    {
        public void Operation()
        {
            IPrototype p = new ConcretePrototype1();
            var p2 = p.Clone();
            p2.DoSomething();
        }
    }
}