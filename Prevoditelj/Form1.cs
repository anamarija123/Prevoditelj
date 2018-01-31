using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prevoditelj
{
    public partial class Prevoditelj_form : Form
    {
        public Prevoditelj_form()
        {
            InitializeComponent();
        }

        private void Prevoditeljforma_load(object sender, EventArgs e)
        {
            List<LangInfo> jezici = DohvatiDostupneJezike();
            foreach (LangInfo jezik in jezici)
            {
                comboIzvorni.Items.Add(jezik);
                comboOdredisni.Items.Add(jezik);
            }
        }

        private void Prevedi_button_Click(object sender, EventArgs e)
        {
            LangInfo odabraniOdredisniJezik = (LangInfo)comboOdredisni.SelectedItem;

            var odgovor = ServisOdgovora(string.Format(AppCache.UrlPrevediJezik, AppCache.API, Izvorni_textBox.Text, odabraniOdredisniJezik.Id));
            var rijecnik = JsonConvert.DeserializeObject<IDictionary>(odgovor.Content);

            var statusCode = rijecnik["code"].ToString();
            if (statusCode.Equals("200"))
            {
                Odredisni_textBox.Text = string.Join(",", rijecnik["text"]);
            }
        }

        private IRestResponse ServisOdgovora(string strUrl)
        {
            var klijent = new RestClient()
            {
                BaseUrl = new Uri(strUrl)
            };
            var zahtjev = new RestRequest()
            {
                Method = Method.GET
            };
            return klijent.Execute(zahtjev);

        }

        private void comboIzvorni_SelectedIndexChanged(object sender, EventArgs e)
        {
            AzurirajStanjeGumbaPrevedi();
        }

        private List<LangInfo> DohvatiDostupneJezike()
        {
            List<LangInfo> jezici = new List<LangInfo>();
            var odgovor = ServisOdgovora(string.Format(AppCache.URLDohvatiDostupneJezike, AppCache.API, "hr"));
            var rijecnik = JsonConvert.DeserializeObject<IDictionary>(odgovor.Content);
            foreach (DictionaryEntry Entry in rijecnik)
            {
                if (Entry.Key.Equals("langs"))
                {
                    var dostupanPrijevod = (JObject)Entry.Value;

                    foreach (var Lang in dostupanPrijevod)
                    {
                        if (!Lang.Equals(lblOdredisni.Text))
                        {
                            jezici.Add(new LangInfo(Lang.Key, Lang.Value.ToString()));
                        }
                    }
                }
            }
            return jezici;
        }
        private void AzurirajStanjeGumbaPrevedi()
        {
            if (Izvorni_textBox.Text.Equals(String.Empty))
            {
                Prevedi_button.Enabled = false;
            }
            else
            {
                if (comboIzvorni.SelectedIndex != -1 && comboOdredisni.SelectedIndex != -1)
                {
                    Prevedi_button.Enabled = true;
                }
                else
                {
                    Prevedi_button.Enabled = false;
                }
            }
        }

        private void Izvorni_textBox_TextChanged(object sender, EventArgs e)
        {
            AzurirajStanjeGumbaPrevedi();
        }
    }
}
