using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inequality;
namespace NumberTest
{
    [TestClass]
    public class SignReverse
    {
        [TestMethod]
        public void TestMethod1()
        {
            Number n = new Number("-2");
            n.SignReverse();
            Assert.AreEqual(Sign.PLUS, n.sign);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Number n = new Number("8");
            n.SignReverse();
            Assert.AreEqual(Sign.MINUS, n.sign);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Number n = new Number("+1");
            n.SignReverse();
            Assert.AreEqual(Sign.MINUS, n.sign);
        }
    }
}
