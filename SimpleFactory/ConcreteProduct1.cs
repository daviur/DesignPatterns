using System;

namespace SimpleFactory
{
    public class ConcreteProduct1 : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("ConcreteProduct1 does something");
        }
    }
}