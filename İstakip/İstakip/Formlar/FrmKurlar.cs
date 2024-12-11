using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace İstakip.Formlar
{
    public partial class FrmKurlar : Form
    {
        public FrmKurlar()
        {
            InitializeComponent();
        }

        private void FrmKurlar_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldosya.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            string USD = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDollar.Text = string.Format("Tarih {0} USD; {1}", tarih.ToShortDateString(), USD);

            string EURO = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuro.Text = string.Format("Tarih {0} EURO; {1}", tarih.ToShortDateString(), EURO);
        }

        private void lblDollar_Click(object sender, EventArgs e)
        {

        }
    }
}
