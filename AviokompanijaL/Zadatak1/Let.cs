using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace AviokompanijaL
{
    [Serializable]
    public class Let
    {
        public string polaziste { get; set; }
        public string odrediste {get; set;}
        public double distanca { get; set; }
        public int prtljag { get; set; }
        public double takse { get; set; }
        public int klasaSjedista { get; set; }
        public double cijenaLeta { get; set; }

        public Let() { }
        public Let(string polaziste, string odrediste, double distanca, int prtljag, double takse, int klasaSjedista, double cijenaLeta)
        {
            this.polaziste = polaziste;
            this.odrediste = odrediste;
            this.distanca = distanca;
            this.prtljag = prtljag;
            this.takse = takse;
            this.klasaSjedista = klasaSjedista;
            this.cijenaLeta = cijenaLeta;
        }

        public double DajCijenuLetaBezTakse()
        {
            return (distanca / 8.88) + prtljag * 10 * ((klasaSjedista * 0.1) + distanca) * 0.000223;
        }
        public double DajKonacnuCijenuLeta(){
            return Math.Round(DajCijenuLetaBezTakse() + DajCijenuLetaBezTakse()*takse/100,2);
        }
        public double DajDistancu()
        {
            if (polaziste == "Sarajevo")
            {
                if (odrediste == "Istanbul") return System.Convert.ToDouble(923);
                if (odrediste == "Pariz") return System.Convert.ToDouble(1350);
            }
            if (polaziste == "Istanbul")
            {
                if (odrediste == "Sarajevo") return System.Convert.ToDouble(923);
                if (odrediste == "Pariz") return System.Convert.ToDouble(2258);
            }
            if (polaziste == "Pariz")
            {
                if (odrediste == "Sarajevo") return System.Convert.ToDouble(1350);
                if (odrediste == "Istanbul") return System.Convert.ToDouble(2258);
            }
            return System.Convert.ToDouble(0);
        }
        public double DajTaksu ()
        {
            double cijenaBezTakse = DajCijenuLetaBezTakse();
            return 100 * (cijenaLeta - cijenaBezTakse) / cijenaBezTakse;
        }

        public int DajKlasuSjedista()
        {
            double cijenaBezTakse = cijenaLeta / (1 + takse);

            return Convert.ToInt32(((cijenaBezTakse - distanca / 8.88) / (prtljag * 10 * 0.000223) - distanca) / 0.1);
        }



    }
}
