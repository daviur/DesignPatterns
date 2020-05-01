using System.Threading.Tasks;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.SimpleFactory;
using DesignPatterns.Creational.Singleton;

namespace DesignPatterns
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Singleton
            Parallel.Invoke(
                CreateLazyNonThreadSafeSingleton,
                CreateLazyNonThreadSafeSingleton,
                CreateEagerThreadSafeSingleton,
                CreateEagerThreadSafeSingleton,
                CreateLazyThreadSafeSingleton,
                CreateLazyThreadSafeSingleton
            );

            // Simple Factory
            var classType = SimpleFactory.GetClassType("Class1");
            classType.DoSomething();
            classType = SimpleFactory.GetClassType("Class2");
            classType.DoSomething();
            classType = SimpleFactory.GetClassType("Class3");
            classType.DoSomething();

            // Factory Method
            new ApplicationType1().Run();
            new ApplicationType2().Run();

            // Abstract Factory
            new Creational.AbstractFactory.Application(new ConcreteFactory1()).Run();
            new Creational.AbstractFactory.Application(new ConcreteFactory2()).Run();

            // Builder
            new Creational.Builder.Application().Run();

            //Prototype
            new Creational.Prototype.Application().Run();
        }


        private static void CreateLazyNonThreadSafeSingleton()
        {
            var instance = LazyNonThreadSafeSingleton.GetInstance;
        }

        private static void CreateEagerThreadSafeSingleton()
        {
            var instance = EagerThreadSafeSingleton.GetInstance;
        }

        private static void CreateLazyThreadSafeSingleton()
        {
            var instance = LazyThreadSafeSingleton.Instance;
        }
    }
}