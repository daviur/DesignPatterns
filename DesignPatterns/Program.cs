using System.Threading.Tasks;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.SimpleFactory;
using DesignPatterns.Creational.Singleton;
using Application = DesignPatterns.Creational.Builder.Application;

namespace DesignPatterns
{
    public static class Program
    {
        public static void Main()
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

            // Factory Method
            new ApplicationType1().Run();
            new ApplicationType2().Run();

            // Builder
            new Application().Run();

            //Prototype
            new Creational.Prototype.Application().Run();

            //Mediator
            new Behavioral.Mediator.Application().Run();

            //Bridge
            new Behavioral.Bridge.Application().Run();

            //Memento
            new Behavioral.Memento.Application().Run();
        }

        private static void CreateLazyNonThreadSafeSingleton()
        {
            var unused = LazyNonThreadSafeSingleton.Instance;
        }

        private static void CreateEagerThreadSafeSingleton()
        {
            var unused = EagerThreadSafeSingleton.Instance;
        }

        private static void CreateLazyThreadSafeSingleton()
        {
            var unused = LazyThreadSafeSingleton.Instance;
        }
    }
}