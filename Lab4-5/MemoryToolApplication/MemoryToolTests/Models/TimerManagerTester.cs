using MemoryToolLibrary.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryToolTests.Managers
{
    [TestClass]
    public class TimerManagerTester
    {
        [TestMethod]
        public void TestCall()
        {
            bool called = false;
            var timer = new TimerManager(() => called = true);
            timer.Start(1);
            Assert.IsFalse(called);
            Thread.Sleep(2000);
            Assert.IsTrue(called);
        }
    }
}
