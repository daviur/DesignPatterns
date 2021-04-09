using System;

namespace DesignPatterns.Behavioral.Bridge
{
    public class Application
    {
        public void Run()
        {
            var bridge11 = new Bridge(new ConcreteClassA1(), new ConcreteClassB1());

            Console.WriteLine(bridge11.Operation());

            var bridge12 = new Bridge(new ConcreteClassA1(), new ConcreteClassB2());
            Console.WriteLine(bridge12.Operation());

            var bridge21 = new Bridge(new ConcreteClassA2(), new ConcreteClassB1());
            Console.WriteLine(bridge21.Operation());

            var bridge22 = new Bridge(new ConcreteClassA2(), new ConcreteClassB2());
            Console.WriteLine(bridge22.Operation());
        }
    }
}