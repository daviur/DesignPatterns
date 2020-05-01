namespace DesignPatterns.Creational.Prototype
{
    public interface IPrototype<out T>
    {
        public T Clone();
    }
}