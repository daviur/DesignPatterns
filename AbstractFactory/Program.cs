namespace AbstractFactory
{
    public static class Program
    {
        public static void Main()
        {
            new Application(new ConcreteFactory1()).Run();

            new Application(new ConcreteFactory2()).Run();
        }
    }
}