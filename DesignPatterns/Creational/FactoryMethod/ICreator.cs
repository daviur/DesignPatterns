namespace DesignPatterns.Creational.FactoryMethod
{
    public interface ICreator
    {
        IProduct FactoryMethod();

        void DoSomething();
    }
}