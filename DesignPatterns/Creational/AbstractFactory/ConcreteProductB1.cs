using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteProductB1 : AbstractProductB
    {
        public override void DoSomething()
        {
            Console.WriteLine("ConcreteProductB1 does something");
        }

        public override string ToString()
        {
            return $"{nameof(ConcreteProductB1)}";
        }
    }
}