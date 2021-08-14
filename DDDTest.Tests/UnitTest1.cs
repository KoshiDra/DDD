using DDD.WinForm.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DDDTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int val = new TestSample().Add(1, 2);
            Assert.AreEqual(3, val);
        }
    }
}
