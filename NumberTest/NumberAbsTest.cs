using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inequality;
namespace NumberTest
{
    [TestClass]
    public class NumberAbsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Number n = new Number("-125^6");
            Assert.AreEqual(125, n.Abs());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Number n = new Number("4");
            Assert.AreEqual(4, n.Abs());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Number n = new Number("-2");
            Assert.AreEqual(2, n.Abs());
        }
    }
}
