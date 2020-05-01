using System;

namespace DesignPatterns.Creational.Prototype
{
    public class ConcretePrototype1 : IPrototype
    {
        public ConcretePrototype1()
        {
            Data1 = 1;
            Data2 = "bla";
            Data3 = 100000000000;
            Console.WriteLine("Expensive object creation");
        }

        private int Data1 { get; }
        private string Data2 { get; }
        private long Data3 { get; }

        public void DoSomething()
        {
            Console.WriteLine("Doing something");
        }

        public IPrototype Clone()
        {
            Console.WriteLine("Cheaper object cloning");
            // This is a shallow copy. Only value types. References will point ot same objects!!!
            // https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=netcore-3.1
            return (ConcretePrototype1)MemberwiseClone();
        }
    }
}