using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AviokompanijaL;

namespace UnitTests
{
    [TestClass]
    public class PutnikTest
    {
        [TestMethod]
        public void PutnikKonstruktorBezParametaraTest()
        {
            Putnik p = new Putnik();
            Assert.IsNull(p.ime,"Ime putnika je null.");
            Assert.IsNull(p.prezime, "Prezime putnika je null.");
            Assert.IsNull(p.jmbg, "JMBG putnika je null.");
            Assert.IsNull(p.telefon, "Telefon putnika je null.");
            Assert.IsNull(p.komentar, "Komentar za putnika je null.");
        }

        [TestMethod]
        public void PutnikKonstruktorSaParametrimaTest()
        {
            string ime = "Faruk";
            string prezime = "Fazlinovic";
            string jmbg = "0606965123123";
            string telefon = "+38762-123-123";
            string komentar = "LZN";
            Putnik p = new Putnik(ime, prezime, jmbg, telefon, komentar);

            Assert.AreEqual(ime, p.ime, "Ime putnika nema očekivanu vrijednost");
            Assert.AreEqual(prezime, p.prezime, "Prezime putnika nema očekivanu vrijednost");
            Assert.AreEqual(jmbg, p.jmbg, "JMBG putnika nema očekivanu vrijednost");
            Assert.AreEqual(telefon, p.telefon, "Telefon putnika nema očekivanu vrijednost");
            Assert.AreEqual(komentar, p.komentar, "Komentar za putnika nema očekivanu vrijednost");
        }

        [TestMethod]
        public void PutnikKonstruktorPrazniStringoviTest()
        {
            Putnik p = new Putnik("", "", "", "", "");

            Assert.AreEqual("", p.ime, "Ime putnika nema očekivanu vrijednost");
            Assert.AreEqual("", p.prezime, "Prezime putnika nema očekivanu vrijednost");
            Assert.AreEqual("", p.jmbg, "JMBG putnika nema očekivanu vrijednost");
            Assert.AreEqual("", p.telefon, "Telefon putnika nema očekivanu vrijednost");
            Assert.AreEqual("", p.komentar, "Komentar za putnika nema očekivanu vrijednost");
        
        }

        [TestMethod]
        public void PutnikDaLiJeBrojTelefonaTest()
        {
            Putnik p = new Putnik();
            p.telefon = "38761111222";
            Assert.IsTrue(p.DaLiJeBrojTelefona(),"prvi");

            p.telefon = "nijebrojtelefona";
            Assert.IsFalse(p.DaLiJeBrojTelefona(),"drugi");
        }

        [TestMethod]
        public void PutnikDaLiJeJmbgTest()
        {
            Putnik p = new Putnik();
            p.jmbg = "0123456789123";
            Assert.IsTrue(p.DaLiJeJmbg(),"Prvi test");

            p.jmbg = "nijejmbg";
            Assert.IsFalse(p.DaLiJeJmbg(),"Drugi test");

            p.jmbg = "111111111111111111111111111111111";
            Assert.IsFalse(p.DaLiJeJmbg(), "Treci test");
        }


    }
}
