using System;
using AbstractFactory;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteProductA1 : AbstractProductA
    {
        public override void DoSomething()
        {
            Console.WriteLine("ConcreteProductA1 does something");
        }

        public override string ToString()
        {
            return $"{nameof(ConcreteProductA1)}";
        }
    }
}