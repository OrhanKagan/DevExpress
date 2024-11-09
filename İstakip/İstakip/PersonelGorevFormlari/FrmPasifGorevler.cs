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
    public partial class FrmPasifGorevler : Form
    {
        public FrmPasifGorevler()
        {
            InitializeComponent();
        }

        DbisTakipEntitiess db = new DbisTakipEntitiess();
        public string mail2;

        private void FrmPasifGorevler_Load(object sender, EventArgs e)
        {
            var personelid = db.TblPersonel.Where(x => x.Mail == mail2).Select(y => y.ID).FirstOrDefault();

            var degerler = (from x in db.TblGorevler
                            select new
                            {
                                x.ID,
                                x.Acıklama,
                                x.Tarih,
                                x.GorevAlan,
                                x.Durum
                            }).Where(x => x.GorevAlan == personelid && x.Durum == false).ToList();

            gridControl1.DataSource = degerler;
            gridView1.Columns["GorevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;

            int a = gridView1.RowCount;
            if (a == 0)
            {
                XtraMessageBox.Show("Pasif görev bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
