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
        public void Proc18_Test_10_res314()
        {
            double x = 10;
            double expected = x*x*3.14;
            var c = new Abbr();
            double actual = c.Proc18(x);
            Assert.AreEqual(expected, actual);
        }
        
        public void Proc21_Test_10_15_res75()
        {
            int x = 10;
            int y = 15;
            double expected = 75;
            var c = new Abbr();
            int actual = c.Proc21(x,y);
            Assert.AreEqual(expected, actual);
        }
    }
}
