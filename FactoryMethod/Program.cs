using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory Method
            new ApplicationType1().Run();
            new ApplicationType2().Run();
        }
    }
}
