using System;

namespace AbstractFactory
{
    public class ConcreteProductA2 : AbstractProductA
    {
        public override void DoSomething()
        {
            Console.WriteLine("ConcreteProductA2 does something");
        }

        public override string ToString()
        {
            return $"{nameof(ConcreteProductA2)}";
        }
    }
}