using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy.Simple;

namespace Nancy.SimpleTests1
{
    [TestClass]
    public class SetupCheckTests
    {
        [TestMethod]
        public void TestSayHello()
        {
            Assert.AreEqual("Hello Test", SetupCheck.SayHello("Test"));
        }
    }
}
