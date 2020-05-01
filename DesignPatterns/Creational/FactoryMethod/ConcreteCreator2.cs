using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class ConcreteCreator2 : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }

        public void DoSomething()
        {
            Console.WriteLine("ConcreteCreator2 does something");
        }
    }
}