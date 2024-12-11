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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
        void Listele()
        {
            var degerler = (from x in db.TblFirmalar
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Yetkili,
                                x.Telefon,
                                x.Mail,
                                x.Sifre,
                                x.Sektör,
                                x.il,
                                x.ilce,
                                x.Adres,
                                x.Gorsel
                            }).ToList();
            gridControl1.DataSource = degerler;
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            Listele();
        }

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
            Listele();
        }



        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblFirmalar.Find(x);
            db.TblFirmalar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Firma silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblFirmalar.Find(x);
            deger.Ad = TxtAdi.Text;
            deger.Yetkili = Txtyetkili.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Mail = TxtMail.Text;
            deger.Sifre = TxtSifre.Text;
            deger.Sektör = Txtsektor.Text;
            deger.il = Txtil.Text;
            deger.ilce = Txtilce.Text;
            deger.Adres = Txtadres.Text;
            deger.Gorsel = Txtgorsel.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Firma güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAdi.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            Txtyetkili.Text = gridView1.GetFocusedRowCellValue("Yetkili").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            TxtSifre.Text = gridView1.GetFocusedRowCellValue("Sifre").ToString();
            Txtsektor.Text = gridView1.GetFocusedRowCellValue("Sektör").ToString();
            Txtil.Text = gridView1.GetFocusedRowCellValue("il").ToString();
            Txtilce.Text = gridView1.GetFocusedRowCellValue("ilce").ToString();
            Txtadres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            Txtgorsel.Text = gridView1.GetFocusedRowCellValue("Gorsel").ToString();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
