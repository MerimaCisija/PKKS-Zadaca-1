using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AviokompanijaL.Zadatak2;

namespace UnitTests.Zadatak2
{
    [TestClass]
    public class MaxIznosTest
    {
        [TestMethod]
        public void MaxIznosTezinaTest()
        {
            MaxTezinaServis mts = new MaxTezinaServis();
            Assert.AreEqual(20, mts.DajMaxIznosTezine("Grad 1","Grad 2"));
        }
    }
}
