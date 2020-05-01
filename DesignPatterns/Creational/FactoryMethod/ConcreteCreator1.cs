using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class ConcreteCreator1 : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }

        public void DoSomething()
        {
            Console.WriteLine("ConcreteCreator1 does something");
        }
    }
}