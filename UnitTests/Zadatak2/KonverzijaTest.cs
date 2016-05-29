using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AviokompanijaL.Zadatak2;

namespace UnitTests.Zadatak2
{
    [TestClass]
    public class KonverzijaTest
    {
        [TestMethod]
        public void KonvertujUSDTest()
        {
            Konverzija konverzija = new Konverzija();
            double novac = 100;
            string valuta = "USD";
            Assert.AreEqual(58, konverzija.Konvertuj(novac, valuta), 1);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void KonverzijaIzuzetakNegativnostTest()
        {
            Konverzija k = new Konverzija();
            double novac = -100;
            string valuta = "USD";

            k.Konvertuj(novac, valuta);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void KonverzijaIzuzetakKMTest()
        {
            Konverzija k = new Konverzija();
            double novac = 100;
            string valuta = "KM";

            k.Konvertuj(novac, valuta);
        }
    }
}
