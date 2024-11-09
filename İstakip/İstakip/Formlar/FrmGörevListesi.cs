using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using İstakip.Entity;

namespace İstakip.Formlar
{
    public partial class FrmGörevListesi : Form
    {
        public FrmGörevListesi()
        {
            InitializeComponent();
        }
        DbisTakipEntitiess db = new DbisTakipEntitiess();

        private void FrmGörevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.ID,
                                           x.Acıklama
                                       }).ToList();

            lblaktifgörevsayisi.Text = db.TblGorevler.Where(x => x.Durum == true).Count().ToString();
            lblpasifgörevsayisi.Text = db.TblGorevler.Where(x => x.Durum == false).Count().ToString();
            lbltoplamdepartman.Text = db.TblDepartman.Count().ToString();



            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler",int.Parse(lblaktifgörevsayisi.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblpasifgörevsayisi.Text));
            
        }
    }
}
