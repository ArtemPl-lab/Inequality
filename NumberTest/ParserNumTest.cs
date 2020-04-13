using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inequality;
namespace NumberTest
{
    [TestClass]
    public class ParserNumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string num = "123";
            Number n = new Number(num);
            Assert.AreEqual(123U, n.digit);
            Assert.AreEqual(Sign.PLUS, n.sign);
            Assert.AreEqual(1, n.degree_num);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string num = "-123^2";
            Number n = new Number(num);
            Assert.AreEqual(123U, n.digit);
            Assert.AreEqual(Sign.MINUS, n.sign);
            Assert.AreEqual(2, n.degree_num);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string num = "3^-10";
            Number n = new Number(num);
            Assert.AreEqual(3U, n.digit);
            Assert.AreEqual(Sign.PLUS, n.sign);
            Assert.AreEqual(-10, n.degree_num);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string num = "-156";
            Number n = new Number(num);
            Assert.AreEqual(156U, n.digit);
            Assert.AreEqual(Sign.MINUS, n.sign);
            Assert.AreEqual(1, n.degree_num);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string num = "-156^-3456";
            Number n = new Number(num);
            Assert.AreEqual(156U, n.digit);
            Assert.AreEqual(Sign.MINUS, n.sign);
            Assert.AreEqual(-3456, n.degree_num);
        }
    }
}
