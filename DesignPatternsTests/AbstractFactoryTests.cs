using System.Linq;
using DesignPatterns.Creational.AbstractFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTests
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        public void SimpleAbstractFactoryTest()
        {
            Assert.AreEqual("ConcreteProductA1:ConcreteProductB1", TestApplication1(new ConcreteFactory1()));
            Assert.AreEqual("ConcreteProductA2:ConcreteProductB2", TestApplication1(new ConcreteFactory2()));
        }

        private string TestApplication1(AbstractFactory factory)
        {
            #region Using simple implementation

            var productA = factory.MakeProductA();
            var productB = factory.MakeProductB();
            return $"{productA}:{productB}";

            #endregion
        }

        [TestMethod]
        public void ExtensibleAbstractFactoryTest()
        {
            Assert.AreEqual("ConcreteProductA1:ConcreteProductB1", TestApplication2(new ConcreteFactory1()));
            Assert.AreEqual("ConcreteProductA2:ConcreteProductB2", TestApplication2(new ConcreteFactory2()));
        }

        private string TestApplication2(AbstractFactory factory)
        {
            #region Using more flexible but not type safe implementation

            var productTypes = factory.GetAllProducts();
            var products = productTypes.Select(factory.Make).ToList();
            return string.Join(':', products);

            #endregion
        }
    }
}