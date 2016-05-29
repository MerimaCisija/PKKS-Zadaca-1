using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AviokompanijaL.Zadatak2;

namespace UnitTests.Zadatak2
{
    [TestClass]
    public class DistancaTest
    {
        [TestMethod]
        public void DistancaStubTest()
        {
            Assert.AreEqual(new DistancaServis().DajDistancu("Grad1","Grad2"),1000);
        }
    }
}
