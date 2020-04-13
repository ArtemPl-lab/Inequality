using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inequality;
using System.Collections.Generic;
namespace ParserSignTest
{
    [TestClass]
    public class ParseVarTest
    {
        [TestMethod]
        public unsafe void TestMethod1()
        {
            string str = "x";
            int i = 0;
            List<char> expected = new List<char>() {'x'};
            List<char> actual = Parser.ParseVar(str, &i);
            Assert.AreEqual(expected[0], actual[0]);
        }
        [TestMethod]
        public unsafe void TestMethod2()
        {
            string str = "5x";
            int i = 1;
            List<char> expected = new List<char>() { 'x' };
            List<char> actual = Parser.ParseVar(str, &i);
            Assert.AreEqual(expected[0], actual[0]);
        }
        public unsafe void TestMethod3()
        {
            string str = "x";
            int i = 0;
            Parser.ParseVar(str, &i);
            Assert.AreEqual(1, i);
        }
    }
}
