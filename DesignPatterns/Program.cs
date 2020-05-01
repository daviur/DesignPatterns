using System.Threading.Tasks;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
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
            DesignPatterns.Creational.SimpleFactory.IProduct classType = SimpleFactory.GetClassType("Class1");
            classType.DoSomething();
            classType = SimpleFactory.GetClassType("Class2");
            classType.DoSomething();
            classType = SimpleFactory.GetClassType("Class3");
            classType.DoSomething();

            // Factory Method
            UseFactoryMethod(new ConcreteCreator1());
            UseFactoryMethod(new ConcreteCreator2());

            // Abstract Factory
            UseAbstractFactory(new ConcreteFactory1());
            UseAbstractFactory(new ConcreteFactory2());

            // Builder
            UseBuilder();
        }

        private static void UseBuilder()
        {
            IBuilder builder = new ConcreteBuilder();
            Director director = new Director();

            director.Construct(builder);
            ComplexProduct complexProduct = builder.Result;
        }

        private static void UseAbstractFactory(AbstractFactory factory)
        {
            AbstractProductA productA = factory.GetProductA();
            productA.DoSomething();
            AbstractProductB productB = factory.GetProductB();
            productB.DoSomething();
        }

        private static void UseFactoryMethod(ICreator creator)
        {
            // Decoupled from creator implementation
            creator.DoSomething();
            DesignPatterns.Creational.FactoryMethod.IProduct product = creator.FactoryMethod();
            product.DoSomething();
        }

        private static void CreateLazyNonThreadSafeSingleton()
        {
            LazyNonThreadSafeSingleton instance = LazyNonThreadSafeSingleton.GetInstance;
        }

        private static void CreateEagerThreadSafeSingleton()
        {
            EagerThreadSafeSingleton instance = EagerThreadSafeSingleton.GetInstance;
        }

        private static void CreateLazyThreadSafeSingleton()
        {
            LazyThreadSafeSingleton instance = LazyThreadSafeSingleton.Instance;
        }
    }
}
