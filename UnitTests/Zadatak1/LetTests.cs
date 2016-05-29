using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AviokompanijaL;


namespace UnitTests
{
    [TestClass]
    public class LetTests
    {
        [TestMethod]
        public void DajCijenuLetaBezTakseTestNula()
        {
            Let l = new Let();

            Assert.AreEqual(l.DajCijenuLetaBezTakse(), 0,"Ocekivana konacna cijena leta je 0.");

            l.distanca = 0;
            l.klasaSjedista = 5;
            l.prtljag = 0;
            l.takse = 0;
            Assert.AreEqual(l.DajCijenuLetaBezTakse(), 0, "Ocekivana konacna cijena leta je 0.");

            l.distanca = 0;
            l.klasaSjedista = 0;
            l.prtljag = 5;
            l.takse = 0;
            Assert.AreEqual(l.DajCijenuLetaBezTakse(), 0, "Ocekivana konacna cijena leta je 0.");

            l.distanca = 0;
            l.klasaSjedista = 0;
            l.prtljag = 0;
            l.takse = 5;
            Assert.AreEqual(0, l.DajCijenuLetaBezTakse(), "Ocekivana konacna cijena leta je 0.");
        }

        [TestMethod]
        public void DajCijenuLetaBezTakseTestPozitivniBrojevi()
        {
            Let l = new Let();
            l.distanca = 888;
            l.klasaSjedista = 10;
            l.prtljag = 10;
            Assert.AreEqual(Math.Round(119.8247,2), Math.Round(l.DajCijenuLetaBezTakse(),2), "Cijena leta nije ispravna.");
        }

        [TestMethod]
        public void DajKonacnuCijenuLetaTest()
        {
            Let l = new Let();
            l.distanca = 888;
            l.klasaSjedista = 10;
            l.prtljag = 10;
            l.takse = 5;
            Assert.AreEqual(Math.Round(125.8159, 2), Math.Round(l.DajKonacnuCijenuLeta(), 2), "Cijena leta nije ispravna.");
        }

        [TestMethod]
        public void DajDistancuTestIstoPolazisteIOdrediste()
        {
            Let l=new Let();
            l.polaziste="Sarajevo";
            l.odrediste="Sarajevo";
            Assert.IsTrue(l.DajDistancu() == 0);

            l.polaziste = "Pariz";
            l.odrediste = "Pariz";
            Assert.IsTrue(l.DajDistancu() == 0);

            l.polaziste = "Istanbul";
            l.odrediste = "Istanbul";
            Assert.IsTrue(l.DajDistancu() == 0);
        }

        [TestMethod]
        public void DajDistancuTest()
        {
            Let l = new Let();
            l.polaziste = "Pariz";
            l.odrediste = "Istanbul";
            Assert.IsTrue(l.DajDistancu() == 2258);

            l.polaziste = "Istanbul";
            l.odrediste = "Pariz";
            Assert.IsTrue(l.DajDistancu() == 2258);

            l.polaziste = "Sarajevo";
            l.odrediste = "Istanbul";
            Assert.IsTrue(l.DajDistancu() == 923);

            l.polaziste = "Istanbul";
            l.odrediste = "Sarajevo";
            Assert.IsTrue(l.DajDistancu() == 923);

            l.polaziste = "Sarajevo";
            l.odrediste = "Pariz";
            Assert.IsTrue(l.DajDistancu() == 1350);

            l.polaziste = "Pariz";
            l.odrediste = "Sarajevo";
            Assert.IsTrue(l.DajDistancu() == 1350);
        }

        [TestMethod]
        public void DajDistancuTestDrugo()
        {
            Let l = new Let();
            l.polaziste = "Grad 1";
            l.odrediste = "Grad 2";
            Assert.IsTrue(l.DajDistancu() == 0);
        }

        [TestMethod]
        public void DajTaksuTest()
        {
            Let l = new Let();
            l.distanca = 888;
            l.klasaSjedista = 10;
            l.prtljag = 10;
            l.cijenaLeta=125.8159;
            Assert.AreEqual(Math.Round(l.DajTaksu(),0), 5, "Ocekivana taksa iznosi 5.");
        }

        [TestMethod]
        public void LetKonstruktorTest()
        {
            string polaziste = "Sarajevo";
            string odrediste = "Pariz";
            double distanca = 1350;
            int prtljag = 5;
            double takse = 10;
            double cijenaLeta = 200;
            int klasaSjedista = 5;
            Let l = new Let(polaziste,odrediste,distanca,prtljag,takse,klasaSjedista,cijenaLeta);

            Assert.AreEqual(polaziste, l.polaziste);
            Assert.AreEqual(odrediste, l.odrediste);
            Assert.AreEqual(distanca, l.distanca);
            Assert.AreEqual(prtljag, l.prtljag);
            Assert.AreEqual(takse, l.takse);
            Assert.AreEqual(cijenaLeta, l.cijenaLeta);
            Assert.AreEqual(klasaSjedista, l.klasaSjedista);
        }

        [TestMethod]
        public void DajKlasuSjedistaTest()
        {
            //Let l = new Let();
            //l.distanca = 1350;
            //l.cijenaLeta = 175.43936;
            //l.takse = 5;
            //l.prtljag = 5;
            //Assert.AreEqual(5,l.DajKlasuSjedista(),0.2);
        }


    }
}
