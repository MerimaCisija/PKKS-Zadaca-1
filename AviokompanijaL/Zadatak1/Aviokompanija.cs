using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AviokompanijaL
{
    public class Aviokompanija
    {
        public List<Karta> avio { get; set; }

        public Aviokompanija() { avio = new List<Karta>(); }
        public Aviokompanija (List<Karta> avio)
        { 
            this.avio = avio; 
        }

        public void Deserijalizacija(Aviokompanija karte)
        {
            if (File.Exists("AviokompanijaL.xml"))
            {
                FileStream stream = new FileStream("AviokompanijaL.xml", FileMode.Open);
                XmlSerializer x = new XmlSerializer(typeof(List<Karta>));
                karte.avio = (List<Karta>)x.Deserialize(stream);
                stream.Close();
            }
        }

        public void Serijalizacija()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Karta>));
            FileStream stream = new FileStream("AviokompanijaL.xml", FileMode.Create);
            x.Serialize(stream, avio);
            stream.Close();
        }


    }


}
