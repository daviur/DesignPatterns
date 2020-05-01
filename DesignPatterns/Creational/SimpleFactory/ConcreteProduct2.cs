using System;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class ConcreteProduct2 : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("ConcreteProduct2 does something");
        }
    }
}