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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbisTakipEntitiess db = new DbisTakipEntitiess();
        void Listele()
        {
            var degerler = (from x in db.TblDepartman
                            select new
                            {
                                x.ID,
                                x.Ad
                            }).ToList();
            gridControl1.DataSource = degerler;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblDepartman t = new TblDepartman();
            t.Ad = TxtAdi.Text;
            db.TblDepartman.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblDepartman.Find(x);
            db.TblDepartman.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAdi.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblDepartman.Find(x);
            deger.Ad = TxtAdi.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
