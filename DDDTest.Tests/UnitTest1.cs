using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DDD.Common;

namespace DDDTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int val = Class1.Add(1, 2);
            Assert.AreEqual(3, val);
        }

        [TestMethod]
        public void TestCommonFunc()
        {
            string st = CommonFunc.RoundString((float)32.124, 2);
            Assert.AreEqual("32.12", st);

        }
    }
}
