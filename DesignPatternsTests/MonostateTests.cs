using DesignPatterns.Creational.Monostate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTests
{
    [TestClass]
    public class MonostateTests
    {
        [TestMethod]
        public void MonostateTest()
        {
            var m1 = new Monostate {Data1 = 10};
            var m2 = new Monostate {Data2 = "string"};
            Assert.AreEqual(m1.Data1, m2.Data1);
            Assert.AreEqual(m1.Data2, m2.Data2);
            Assert.AreEqual(m1.Data3, m2.Data3);
        }
    }
}