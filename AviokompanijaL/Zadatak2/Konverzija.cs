using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviokompanijaL.Zadatak2
{
    public class Konverzija
    {
        IKonverzija konv;
        public Konverzija()
        {
            konv = new KonverzijaServis();
        }

        public double Konvertuj(double iznos, string valuta) //Iz KM u valutu
        {
            if (iznos < 0) throw new ArgumentException("Iznos mora biti pozitivan broj!");
            if (valuta == "KM") throw new ArgumentException("Valuta ne može biti KM.");
            double rezultat =iznos* konv.DajKurs(valuta);
            return rezultat;
        }
    }
}
