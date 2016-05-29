using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AviokompanijaL;

namespace UnitTests
{
    [TestClass]
    public class KartaTest
    {
        [TestMethod]
        public void KartaKonstruktorTest()
        {
            Putnik putnik = new Putnik("","","0123456789123","","");
            Let let = new Let("","",123,0,0,0,0);
            Karta k = new Karta(putnik, let);

            Assert.AreEqual("0123456789123", k.putnik.jmbg);
            Assert.AreEqual(123, k.let.distanca);
        }
    }
}
