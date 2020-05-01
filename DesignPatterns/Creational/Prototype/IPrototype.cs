using System;

namespace DesignPatterns.Creational.Prototype
{
    public interface IPrototype
    {
        public void DoSomething();

        public IPrototype Clone();
    }
}