using System;
using Abramyan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace abrTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Begin1_Test_20_res80()
        {
            int x = 20;
            int expected = x*4;
            var c = new Abbr();
            int actual = c.Begin1(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
