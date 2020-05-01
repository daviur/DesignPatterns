using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteProductA2 : AbstractProductA
    {
        public override void DoSomething()
        {
            Console.WriteLine("ConcreteProductA2 does something");
        }
    }
}