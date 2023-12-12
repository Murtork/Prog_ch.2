using MemoryToolLibrary.Managers;
using MemoryToolLibrary.MVVM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace MemoryToolTests.Managers
{
    [TestClass]
    public class ImageTrackerTester
    {
        [TestMethod]
        public void TestConstructor()
        {
            var image = new BitmapImage();
            var tracker = new ImageTracker(image);
            Assert.AreEqual(image, tracker.Image);
        }

        [TestMethod]
        public void TestDependencyProperty()
        {
            var tracker = new ImageTracker(null);
            Assert.IsFalse(tracker.Checked);
            var sample = new SampleClass();
            BindingOperations.SetBinding(tracker, ImageTracker.CheckedProperty, new Binding("Flag") { Source = sample });
            sample.Flag = true;
            Assert.IsTrue(tracker.Checked);
        }

        class SampleClass : BaseViewModel
        {
            bool _flag = false;

            public bool Flag
            {
                get => _flag;
                set
                {
                    _flag = value;
                    OnPropertyChanged(nameof(Flag));
                }
            }
        }
    }
}
