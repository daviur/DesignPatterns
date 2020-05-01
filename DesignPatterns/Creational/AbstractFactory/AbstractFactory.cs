namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class AbstractFactory
    {
        #region Simple implementation, but cannot add more product types

        public abstract AbstractProductA MakeProductA();
        public abstract AbstractProductB MakeProductB();

        #endregion

        #region Completely decouple and extensible implementation, but needs Unit Testing

        public abstract IProduct Make(string productType);
        public abstract string[] GetAllProducts();

        #endregion
    }
}