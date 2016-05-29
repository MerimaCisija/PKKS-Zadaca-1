using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AviokompanijaL
{
    [Serializable]
    public class Putnik
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string jmbg { get; set; }
        public string telefon { get; set; }
        public string komentar { get; set; }


        public Putnik() { }
        public Putnik(string ime, string prezime, string jmbg, string telefon, string komentar) {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.telefon = telefon;
            this.komentar = komentar;
        }

        public bool DaLiJeBrojTelefona()
        {
            string pattern = @"\d{11}";
            Match result = Regex.Match(telefon, pattern);
            return result.Success;
        }

        public bool DaLiJeJmbg()
        {
            string pattern = @"([0-9]+[0-9]+[0-9]+[0-9]+[0-9]+[0-9]+[0-9]+[0-9]+[0-9]+[0-9]+[0-9]+[0-9]+[0-9])";
            if (jmbg.Length == 13)
            {
                Match result = Regex.Match(jmbg, pattern);
                if (result.Success) return true;
            }
            return false;
        }

    }
}
