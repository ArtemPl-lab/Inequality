using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inequality;
namespace ParserSignTest
{
    [TestClass]
    public class ParseDegreeTest
    {
        [TestMethod]
        public unsafe void TestMethod1()
        {
            string str = "^45";
            int i = 0;
            int actual = 45;
            int expected = Parser.ParseDegree(str,&i);
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public unsafe void TestMethod2()
        {
            string str = "^-45";
            int i = 0;
            int actual = -45;
            int expected = Parser.ParseDegree(str, &i);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public unsafe void TestMethod3()
        {
            string str = "^-45";
            int i = 0;
            Parser.ParseDegree(str, &i);
            Assert.AreEqual(i, 4);
        }
        [TestMethod]
        public unsafe void TestMethod4()
        {
            string str = "^13";
            int i = 0;
            Parser.ParseDegree(str, &i);
            Assert.AreEqual(3, i);
        }
    }
}
