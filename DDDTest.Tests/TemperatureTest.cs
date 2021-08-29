using DDD.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DDDTest.Tests
{
    [TestClass]
    public class TemperatureTest
    {
        [TestMethod]
        public void 小数点以下2桁で丸めて表示できる()
        {
            var t = new Temperature(32.1f);
            Assert.AreEqual(32.1f, t.Value);
            Assert.AreEqual("32.10", t.DiaplayValue);
            Assert.AreEqual("32.10℃", t.DiaplayValueWithUnit);
        }

        [TestMethod]
        public void 温度イコール()
        {
            var t1 = new Temperature(32.1f);
            var t2 = new Temperature(32.1f);

            Assert.AreEqual(true, t1.Equals(t2));
        }

        [TestMethod]
        public void 温度Equalイコール()
        {
            var t1 = new Temperature(32.1f);
            var t2 = new Temperature(32.1f);

            Assert.AreEqual(true, t1 == t2);
        }

        [TestMethod]
        public void 温度の値型イコール()
        {
            var t1 = new Temperature(32.1f);
            var t2 = new Temperature(32.1f);

            Assert.AreEqual(true, t1.Value == t2.Value);
        }
    }
}
