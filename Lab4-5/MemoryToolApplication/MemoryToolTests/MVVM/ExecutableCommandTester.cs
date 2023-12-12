using MemoryToolLibrary.MVVM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MemoryToolTests.MVVM
{
    [TestClass]
    public class ExecutableCommandTester
    {
        [TestMethod]
        public void TestCommand()
        {
            bool executed = false;
            ICommand command = new ExecutableCommand(obj =>
            {
                Assert.IsNotNull(obj);
                Assert.IsTrue(obj is int);
                Assert.IsTrue((int)obj == 5);
                executed = true;
            });
            command.Execute(5);
            Assert.IsTrue(executed);
        }
    }
}
