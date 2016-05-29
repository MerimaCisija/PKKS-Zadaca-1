using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AviokompanijaL
{
    [Serializable]
    public class Karta
    {
        private static int brojac = 1;
        public int id { get; set; }
        public Putnik putnik { get; set; }
        public Let let { get; set; }

        public Karta() { this.id = brojac++; }
        public Karta(Putnik putnik, Let let) {
            this.id =brojac++;
            this.putnik = putnik;
            this.let = let;
        }


    }
}
