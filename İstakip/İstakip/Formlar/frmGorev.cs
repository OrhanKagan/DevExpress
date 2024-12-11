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

namespace İstakip.Formlar
{
    public partial class frmGorev : Form
    {
        public frmGorev()
        {
            InitializeComponent();
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblGorevler t = new TblGorevler();
            t.Acıklama = txtaciklama.Text;
            t.Durum = true;
            t.GorevAlan = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Tarih = DateTime.Parse(txttarih.Text);
            t.GorevVeren = 1;
            db.TblGorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başarılı bir şekilde tanımlandı", "bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void frmGorev_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblPersonel
                                select new
                                {
                                    x.ID,
                                    personel=x.Ad+" "+x.Soyad
                                }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "personel";
            lookUpEdit1.Properties.DataSource = degerler;
        }
    }
}
