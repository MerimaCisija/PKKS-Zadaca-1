using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace AviokompanijaL
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public partial class Form1 : Form
    {
        Aviokompanija karte = new Aviokompanija();
        public Form1()
        {
            InitializeComponent();
        }

        public bool JeLiCijeliBroj(string tekst)
        {
            int broj;
            bool rezultat = Int32.TryParse(tekst, out broj);
            return rezultat;
        }

        public bool JeLiBroj(string tekst)
        {
            double broj;
            bool rezultat = Double.TryParse(tekst, out broj);
            return rezultat;
        }
        private void cijenaBtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //nedostaje taksa -OK
            if (takseTxt.Text==string.Empty && cijenaTxt.Text!=string.Empty && klasaBar.Value!=0 && distancaTxt.Text!=string.Empty && prtljagTxt.Text!=string.Empty)
            {
                Let l=new Let();
                l.polaziste = polazisteCB.SelectedItem.ToString();
                l.odrediste = odredisteCB.SelectedItem.ToString();
                l.distanca=System.Convert.ToDouble(distancaTxt.Text);
                l.klasaSjedista=klasaBar.Value;
                l.prtljag = System.Convert.ToInt32(prtljagTxt.Text);
                l.cijenaLeta = System.Convert.ToDouble(cijenaTxt.Text);
                takseTxt.Text = System.Convert.ToString(l.DajTaksu());
            }
            //nedostaje klasa
            else if (takseTxt.Text!=string.Empty && cijenaTxt.Text!=string.Empty && klasaBar.Value==0 && distancaTxt.Text!=string.Empty && prtljagTxt.Text!=string.Empty)
            {
                Let l = new Let();
                l.polaziste = polazisteCB.SelectedItem.ToString();
                l.odrediste = odredisteCB.SelectedItem.ToString();
                l.takse = System.Convert.ToDouble(takseTxt.Text);
                l.distanca = System.Convert.ToDouble(distancaTxt.Text);
                l.cijenaLeta = System.Convert.ToDouble(cijenaTxt.Text);
                l.klasaSjedista = l.DajKlasuSjedista();
                this.klasaBar.Value = l.klasaSjedista;
            }
            else if (cijenaTxt.Text==string.Empty)
            {
                Let l = new Let();
                l.polaziste = polazisteCB.SelectedItem.ToString();
                l.odrediste = odredisteCB.SelectedItem.ToString();
                l.distanca = System.Convert.ToDouble(distancaTxt.Text);
                l.prtljag = System.Convert.ToInt32(prtljagTxt.Text);
                l.takse = System.Convert.ToDouble(takseTxt.Text);
                l.klasaSjedista=klasaBar.Value;
                l.cijenaLeta = l.DajKonacnuCijenuLeta();
                cijenaTxt.Text = System.Convert.ToString(l.cijenaLeta);
            }
            distancaTxt_Validated(distancaTxt, e);
            polazisteCB_SelectedIndexChanged(polazisteCB, e);
            odredisteCB_SelectedIndexChanged(odredisteCB, e);
            prtljagTxt_Validated(prtljagTxt, e);
            takseTxt_Validated(takseTxt, e);

        }

        private void rezervacijaBtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            distancaTxt_Validated(distancaTxt, e);
            polazisteCB_SelectedIndexChanged(polazisteCB, e);
            odredisteCB_SelectedIndexChanged(odredisteCB, e);
            prtljagTxt_Validated(prtljagTxt, e);
            takseTxt_Validated(takseTxt, e);
            imeTxt_Validated(imeTxt, e);
            prezimeTxt_Validated(prezimeTxt, e);
            telefonTxt_Validated(telefonTxt, e);
            jmbgTxt_Validated(jmbgTxt, e);

            if (takseTxt.Text == string.Empty && cijenaTxt.Text == string.Empty && klasaBar.Value == 0 && distancaTxt.Text != string.Empty && prtljagTxt.Text != string.Empty)
            {
                MessageBox.Show("Provjerite podatke leta!");
            }
            try
            {
                if (string.IsNullOrEmpty(errorProvider1.GetError(cijenaBtn) + errorProvider1.GetError(distancaTxt) + errorProvider1.GetError(polazisteCB) + errorProvider1.GetError(odredisteCB) + errorProvider1.GetError(prtljagTxt) + errorProvider1.GetError(takseTxt) + errorProvider1.GetError(imeTxt) + errorProvider1.GetError(prezimeTxt) + errorProvider1.GetError(jmbgTxt) + errorProvider1.GetError(telefonTxt)))
                {
                    Let _let = new Let(polazisteCB.SelectedItem.ToString(), odredisteCB.SelectedItem.ToString(), System.Convert.ToDouble(distancaTxt.Text), System.Convert.ToInt32(prtljagTxt.Text), System.Convert.ToDouble(takseTxt.Text), klasaBar.Value, System.Convert.ToDouble(cijenaTxt.Text));
                    Putnik _putnik = new Putnik(imeTxt.Text, prezimeTxt.Text, jmbgTxt.Text, telefonTxt.Text, komentarTxt.Text);
                    
                    Karta _novaKarta = new Karta();
                    _novaKarta.putnik = _putnik;
                    _novaKarta.let = _let;
                    karte.avio.Add(_novaKarta);
                    this.dataGridView1.Rows.Add(System.Convert.ToString(_novaKarta.id), _let.distanca.ToString(), _let.prtljag.ToString(), _let.takse.ToString(), _let.klasaSjedista.ToString(), _putnik.ime + " " + _putnik.prezime, _putnik.jmbg, _putnik.telefon, _putnik.komentar);
                   
                   karte.Serijalizacija();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Provjerite unesene podatke za let i putnika! \n"+ex.ToString());
            }

            

        }

        private void distancaTxt_TextChanged(object sender, EventArgs e) { }

        private void distancaTxt_Validated(object sender, EventArgs e) {
            if (!JeLiBroj(distancaTxt.Text) && distancaTxt.Text != string.Empty) errorProvider1.SetError(distancaTxt, "Distanca mora biti broj!");
        }

        private void polazisteCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (odredisteCB.SelectedItem != null&& polazisteCB.SelectedItem!=null)
            {
                Let let = new Let();
                let.polaziste = polazisteCB.SelectedItem.ToString();
                let.odrediste = odredisteCB.SelectedItem.ToString();
                distancaTxt.Text = System.Convert.ToString(let.DajDistancu());
            }
            else distancaTxt.Text = System.Convert.ToString(0);
        }

        private void odredisteCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (polazisteCB.SelectedItem != null && odredisteCB.SelectedItem!=null)
            {
                Let let = new Let();
                let.polaziste = polazisteCB.SelectedItem.ToString();
                let.odrediste = odredisteCB.SelectedItem.ToString();
                distancaTxt.Text = System.Convert.ToString(let.DajDistancu());
            }
            else distancaTxt.Text = System.Convert.ToString(0);
        }

        private void prtljagTxt_Validated(object sender, EventArgs e)
        {
            if (!JeLiCijeliBroj(prtljagTxt.Text) && prtljagTxt.Text != string.Empty) errorProvider1.SetError(prtljagTxt, "Broj komada prtljaga mora biti cijeli broj!");
        }

        private void takseTxt_Validated(object sender, EventArgs e) {
            if (!JeLiBroj(takseTxt.Text) && takseTxt.Text != string.Empty) errorProvider1.SetError(prtljagTxt, "Nije broj!");
            else if (takseTxt.Text != string.Empty && !(System.Convert.ToDouble(takseTxt.Text) >= 0 && System.Convert.ToDouble(takseTxt.Text) <= 100)) errorProvider1.SetError(takseTxt, "Taksa mora biti broj između 0 i 100!");
        }

        private void imeTxt_Validated(object sender, EventArgs e)
        {
            if (imeTxt.Text == string.Empty) errorProvider1.SetError(imeTxt, "Prazno polje!");
        }

        private void prezimeTxt_Validated(object sender, EventArgs e)
        {
            if (prezimeTxt.Text == string.Empty) errorProvider1.SetError(prezimeTxt, "Prazno polje!");
        }

        private void jmbgTxt_Validated(object sender, EventArgs e)
        {
            if (jmbgTxt.Text == string.Empty) errorProvider1.SetError(jmbgTxt, "Prazno polje!");
            else
            {
                Putnik putnik = new Putnik();
                putnik.jmbg = jmbgTxt.Text;
                if (!putnik.DaLiJeJmbg()) errorProvider1.SetError(jmbgTxt, "Format JMBG nije validan!");
            }
        }

        private void telefonTxt_Validated(object sender, EventArgs e)
        {
            if (telefonTxt.Text == string.Empty) errorProvider1.SetError(telefonTxt, "Prazno polje!");
            else
            {
                Putnik putnik = new Putnik();
                putnik.telefon = telefonTxt.Text;
                if (!putnik.DaLiJeBrojTelefona()) errorProvider1.SetError(telefonTxt, "Format telefona nije validan!");
            }
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("AviokompanijaL.xml"))
            {
                karte.Deserijalizacija(karte);
                for (int i = 0; i < karte.avio.Count; i++)
                {
                    this.dataGridView1.Rows.Add(karte.avio[i].id, karte.avio[i].let.distanca.ToString(), karte.avio[i].let.prtljag.ToString(), karte.avio[i].let.takse.ToString(), karte.avio[i].let.klasaSjedista.ToString(), karte.avio[i].putnik.ime + " " + karte.avio[i].putnik.prezime, karte.avio[i].putnik.jmbg, karte.avio[i].putnik.telefon, karte.avio[i].putnik.komentar);
                }
            }

          
        }

        private void brisanjeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                karte.avio.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                this.dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

                karte.Serijalizacija();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Brisanje nije uspjelo: \n" + ex.Message);
            }

        }


        
    }
}
