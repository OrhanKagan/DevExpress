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
    public partial class FrmCagriAtama : Form
    {
        public FrmCagriAtama()
        {
            InitializeComponent();
        }

        public int id;

        DbisTakipEntitiess db = new DbisTakipEntitiess();

        private void FrmCagriAtama_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblPersonel
                            select new
                            {
                                x.ID,
                                personel = x.Ad + " " + x.Soyad
                            }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "personel";
            lookUpEdit1.Properties.DataSource = degerler;

            txtcagriid.Text = id.ToString();
            var gelenveri = db.TblCagrilar.Find(id);
            txtaciklama.Text = gelenveri.Aciklama;
            txttarih.Text = gelenveri.Tarih.ToString();
            txtkonu.Text = gelenveri.Konu;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            var gelenveri = db.TblCagrilar.Find(id);
            gelenveri.Konu = txtkonu.Text;
            gelenveri.Tarih = Convert.ToDateTime(txttarih.Text);
            gelenveri.Aciklama = txtaciklama.Text;
            gelenveri.CagriPersonel = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Başarılı Bir Şekilde Güncellerndi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
