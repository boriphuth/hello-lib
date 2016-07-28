using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloLib.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "Hi, TestMethod1";
            string name = "TestMethod1";
            string actual = "Hi, " + name;
            //string actual = null;

            Assert.AreEqual(expected, actual);
        }
    }
}