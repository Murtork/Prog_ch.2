using MemoryToolLibrary.MVVM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryToolTests.MVVM
{
    [TestClass]
    public class BaseViewModelTester
    {
        class TestViewModel : BaseViewModel
        {
            public bool Flag
            {
                get => true;
                set
                {
                    OnPropertyChanged(nameof(Flag));
                }
            }
        }

        [TestMethod]
        public void TestPropertyChanged()
        {
            bool called = false;
            var viewModel = new TestViewModel();
            viewModel.PropertyChanged += (sender, args) =>
            {
                Assert.IsTrue(sender == viewModel);
                Assert.IsTrue(args.PropertyName == "Flag");
                called = true;
            };
            viewModel.Flag = false;
            Assert.IsTrue(called);
        }
    }
}
