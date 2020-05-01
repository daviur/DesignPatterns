using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class ConcreteProduct2 : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("ConcreteProduct2 does something");
        }
    }
}