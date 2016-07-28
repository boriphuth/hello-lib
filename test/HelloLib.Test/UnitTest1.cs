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
            string name = "Tes tMethod1";
            string actual = null;
            //string actual = "Hi, " + name;

            Assert.AreEqual(expected, actual);
        }
    }
}