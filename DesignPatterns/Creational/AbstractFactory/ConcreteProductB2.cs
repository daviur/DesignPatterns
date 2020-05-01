using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteProductB2 : AbstractProductB
    {
        public override void DoSomething()
        {
            Console.WriteLine("ConcreteProductB2 does something");
        }
    }
}