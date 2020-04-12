using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inequality;
namespace ParserSignTest
{
    [TestClass]
    public class ParserSignTest
    {
        [TestMethod]
        public unsafe void TestMethod1()
        {
            string str = "-455";
            int i = 0;
            Sign expected = Sign.MINUS;
            Sign actual = Parser.ParseSign(str, &i);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public unsafe void TestMethod2()
        {
            string str = "255";
            int i = 0;
            Sign expected = Sign.PLUS;
            Sign actual = Parser.ParseSign(str, &i);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public unsafe void TestMethod3()
        {
            string str = "+13";
            int i = 0;
            Sign expected = Sign.PLUS;
            Sign actual = Parser.ParseSign(str, &i);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public unsafe void TestMethod4()
        {
            string str = "(";
            int i = 0;
            Sign expected = Sign.NONE;
            Sign actual = Parser.ParseSign(str, &i);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public unsafe void TestMethod5()
        {
            string str = "321";
            int i = 0;
            int actual = 0;
            Parser.ParseSign(str, &i);
            Assert.AreEqual(i, actual);
        }
        [TestMethod]
        public unsafe void TestMethod6()
        {
            string str = "-10";
            int i = 0;
            int actual = 1;
            Parser.ParseSign(str, &i);
            Assert.AreEqual(i, actual);
        }
        [TestMethod]
        public unsafe void TestMethod7()
        {
            string str = "+15";
            int i = 0;
            int actual = 1;
            Parser.ParseSign(str, &i);
            Assert.AreEqual(i, actual);
        }
        [TestMethod]
        public unsafe void TestMethod8()
        {
            string str = "(";
            int i = 0;
            int actual = 0;
            Parser.ParseSign(str, &i);
            Assert.AreEqual(i, actual);
        }
    }
}
