using MemoryToolLibrary.Converters;
using MemoryToolLibrary.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Media.Imaging;

namespace MemoryToolTests.Converters
{
    [TestClass]
    public class TrackToStringConverterTester
    {
        [TestMethod]
        public void TestConversion1()
        {
            var obj = new TrackToStringConverter(_ => true).Convert(true, null, new ImageTracker(null), null);
            Assert.IsNotNull(obj);
            Assert.IsTrue(obj as string == "неверно");
        }

        [TestMethod]
        public void TestConversion2()
        {
            var obj = new TrackToStringConverter(_ => false).Convert(true, null, new ImageTracker(null), null);
            Assert.IsNotNull(obj);
            Assert.IsTrue(obj as string == "верно");
        }

        [TestMethod]
        public void TestConversion3()
        {
            var obj = new TrackToStringConverter(_ => true).Convert(true, null, new ImageTracker(null) { Checked = true }, null);
            Assert.IsNotNull(obj);
            Assert.IsTrue(obj as string == "верно");
        }

        [TestMethod]
        public void TestConversion4()
        {
            var obj = new TrackToStringConverter(_ => false).Convert(true, null, new ImageTracker(null) { Checked = true }, null);
            Assert.IsNotNull(obj);
            Assert.IsTrue(obj as string == "неверно");
        }

        [TestMethod]
        public void TestConversion5()
        {
            var obj = new TrackToStringConverter(image => true).Convert(false, null, new ImageTracker(null), null);
            Assert.IsNotNull(obj);
            Assert.IsTrue(obj as string == string.Empty);
        }

        [TestMethod]
        public void TestConversion6()
        {
            Assert.ThrowsException<Exception>(() => new TrackToStringConverter(image => true).Convert(null, null, new ImageTracker(null), null));
        }
    }
}
