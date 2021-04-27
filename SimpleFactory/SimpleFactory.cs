using System;

namespace SimpleFactory
{
    public static class SimpleFactory
    {
        public static IProduct GetClassType(string classType)
        {
            if (classType.Equals("Class1"))
                return new ConcreteProduct1();
            if (classType.Equals("Class2")) return new ConcreteProduct2();
            throw new ArgumentException("Wrong type");
        }
    }
}