using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using İstakip.Entity;

namespace İstakip.PersonelGorevFormlari
{
    public partial class FrmCagriDetayGirisi : Form
    {
        public FrmCagriDetayGirisi()
        {
            InitializeComponent();
        }

        public int id;

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCagriDetayGirisi_Load(object sender, EventArgs e)
        {
            TxtCagriID.Enabled = false;
            TxtCagriID.Text = id.ToString();
            string tarih = DateTime.Now.ToShortDateString();
            string saat = DateTime.Now.ToShortTimeString();
            txttarih.Text = tarih;
            txtsaat.Text = saat;
        }

        DbisTakipEntitiess db = new DbisTakipEntitiess();

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblCagriDetay t = new TblCagriDetay();
            t.Cagri = int.Parse(TxtCagriID.Text);
            t.Saat = txtsaat.Text;
            t.Tarih = DateTime.Parse(txttarih.Text);
            t.Aciklama = txtaciklama.Text;
            db.TblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayı Sisteme Başarılı Bir Şekilde Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
