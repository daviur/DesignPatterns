using System;

namespace FactoryMethod
{
    public class ConcreteProduct2 : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("ConcreteProduct2 does something");
        }
    }
}