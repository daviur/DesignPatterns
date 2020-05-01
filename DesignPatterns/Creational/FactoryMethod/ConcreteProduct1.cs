using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class ConcreteProduct1 : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("ConcreteProduct1 does something");
        }
    }
}