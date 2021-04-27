using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Factory
            var classType = SimpleFactory.GetClassType("Class1");
            classType.DoSomething();
            classType = SimpleFactory.GetClassType("Class2");
            classType.DoSomething();
        }
    }
}
