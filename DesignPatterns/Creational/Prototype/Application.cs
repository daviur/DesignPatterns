namespace DesignPatterns.Creational.Prototype
{
    public class Application
    {
        public ConcreteProduct ConcreteProduct
        {
            get => default;
            set { }
        }

        public void Run()
        {
            var _ = new ConcreteProduct();

            var p = ConcreteProduct.Prototype.Clone();
            p.Data1 = 1;
            p.Data2 = "string";
            p.Data3 = 3;
            p.DoSomething();
        }
    }
}