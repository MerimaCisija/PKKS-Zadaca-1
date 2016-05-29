using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AviokompanijaL;


namespace UnitTests
{
    [TestClass]
    public class OstaloTest
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

       [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
       "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential),
       DeploymentItem("data.csv"), TestMethod]
       public void Putnici_CsvDataDrivenTest()
        {
            string ime = Convert.ToString(TestContext.DataRow["ime"]);
            string prezime = Convert.ToString(TestContext.DataRow["prezime"]);
            string jmbg = Convert.ToString(TestContext.DataRow["jmbg"]);
            string telefon = Convert.ToString(TestContext.DataRow["telefon"]);
            string komentar = Convert.ToString(TestContext.DataRow["komentar"]);

            Putnik p = new Putnik(ime, prezime, jmbg, telefon, komentar);

            Assert.AreEqual(ime, p.ime);
            Assert.AreEqual(prezime, p.prezime);
            Assert.AreEqual(jmbg, p.jmbg);
            Assert.AreEqual(telefon, p.telefon);
            Assert.AreEqual(komentar, p.komentar);
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML","|DataDirectory|\\data.xml", "putnik", DataAccessMethod.Sequential),DeploymentItem("data.xml"), TestMethod]
        public void PutnikJmbg_XMLDataDrivenTest()
        {
            Putnik p = new Putnik();
            string jmbg = Convert.ToString(testContextInstance.DataRow["jmbg"]);
            p.jmbg = jmbg;
            Assert.AreEqual(jmbg, p.jmbg);
        }





    }
}
