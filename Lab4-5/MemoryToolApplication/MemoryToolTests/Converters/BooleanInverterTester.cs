using MemoryToolLibrary.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MemoryToolTests.Converters
{
    [TestClass]
    public class BooleanInverterTester
    {
        [TestMethod]
        public void TestConvertion()
        {
            var converter = new BooleanInverter();
            object obj = converter.Convert(true, null, null, null);
            Assert.IsNotNull(obj);
            Assert.AreEqual(false, obj);
            obj = converter.ConvertBack(obj, null, null, null);
            Assert.IsNotNull(obj);
            Assert.AreEqual(true, obj);
            Assert.ThrowsException<Exception>(() => converter.Convert(null, null, null, null));
            Assert.ThrowsException<Exception>(() => converter.ConvertBack(null, null, null, null));
        }
    }
}
