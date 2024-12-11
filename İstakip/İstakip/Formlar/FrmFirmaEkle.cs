using DevExpress.XtraEditors;
using İstakip.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstakip.Formlar
{
    public partial class FrmFirmaEkle : Form
    {
        public FrmFirmaEkle()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblFirmalar t = new TblFirmalar();
            t.Ad = TxtAdi.Text;
            t.Yetkili = Txtyetkili.Text;
            t.Telefon = TxtTelefon.Text;
            t.Mail = TxtMail.Text;
            t.Sifre = TxtSifre.Text;
            t.Sektör = Txtsektor.Text;
            t.il = Txtil.Text;
            t.ilce = Txtilce.Text;
            t.Adres = Txtadres.Text;
            t.Gorsel = Txtgorsel.Text;
            db.TblFirmalar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Firma başarılı şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
