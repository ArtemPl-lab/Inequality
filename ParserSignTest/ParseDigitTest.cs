using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inequality;

namespace ParserSignTest
{
    [TestClass]
    public class ParseDigitTest
    {
        [TestMethod]
        public unsafe void TestMethod1()
        {
            string str = "123";
            int i = 0;
            int expected = 123;
            int actual = Parser.ParseDigit(str, &i);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public unsafe void TestMethod2()
        {
            string str = "15+12";
            int i = 0;
            int expected = 15;
            int actual = Parser.ParseDigit(str, &i);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public unsafe void TestMethod3()
        {
            string str = "+12";
            int i = 0;
            int expected = -1;
            int actual = Parser.ParseDigit(str, &i);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public unsafe void TestMethod4()
        {
            string str = "123";
            int i = 0;
            int expected = 3;
            Parser.ParseDigit(str, &i);
            Assert.AreEqual(expected, i);
        }
        [TestMethod]
        public unsafe void TestMethod5()
        {
            string str = "123+15-12";
            int i = 4;
            int expected = 6;
            Parser.ParseDigit(str, &i);
            Assert.AreEqual(expected, i);
        }
        [TestMethod]
        public unsafe void TestMethod6()
        {
            string str = "123+15-12";
            int i = 4;
            int expected = 15;
            int actual = Parser.ParseDigit(str, &i);
            Assert.AreEqual(expected, actual);
        }

    }
}
