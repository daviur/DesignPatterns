using System;

namespace Prototype
{
    public class ConcreteProduct : IPrototype<ConcreteProduct>
    {
        public ConcreteProduct()
        {
            Data1 = 1;
            Data2 = "bla";
            Data3 = 100000000000;
            Console.WriteLine("Expensive object creation");
            Prototype = this;
        }

        public int Data1 { get; set; }
        public string Data2 { get; set; }
        public long Data3 { get; set; }

        public static ConcreteProduct Prototype { get; set; }

        public ConcreteProduct Clone()
        {
            Console.WriteLine("Cheaper object cloning");
            // This is a shallow copy. Only value types. References will point ot same objects!!!
            // https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=netcore-3.1
            return (ConcreteProduct) MemberwiseClone();
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing something");
        }
    }
}