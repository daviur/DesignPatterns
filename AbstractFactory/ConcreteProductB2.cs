using System;

namespace AbstractFactory
{
    public class ConcreteProductB2 : AbstractProductB
    {
        public override void DoSomething()
        {
            Console.WriteLine("ConcreteProductB2 does something");
        }

        public override string ToString()
        {
            return $"{nameof(ConcreteProductB2)}";
        }
    }
}