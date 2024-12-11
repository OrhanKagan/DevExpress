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
    public partial class FrmPersonelİstatistik : Form
    {
        public FrmPersonelİstatistik()
        {
            InitializeComponent();
        }

        private void labelControl27_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }








        DbisTakipEntities db = new DbisTakipEntities();

        private void FrmPersonelİstatistik_Load(object sender, EventArgs e)
        {
            lbltoplamdepartman.Text = db.TblDepartman.Count().ToString();
            lbltoplamfirma.Text = db.TblFirmalar.Count().ToString();
            lbltoplampersonel.Text = db.TblPersonel.Count().ToString();
            lblaktifis.Text = db.TblGorevler.Count(x => x.Durum == true).ToString();
            lblpasifis.Text = db.TblGorevler.Count(x => x.Durum == false).ToString();
            lblsongorev.Text = db.TblGorevler.OrderByDescending(x=>x.ID).Select(x => x.Acıklama).FirstOrDefault();
            lblsehir.Text = db.TblFirmalar.Select(x => x.il).Distinct().Count().ToString();
            lblsektor.Text = db.TblFirmalar.Select(x => x.Sektör).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            lblbugunkugorevler.Text = db.TblGorevler.Count(x => x.Tarih == bugun).ToString();
            var d1 = db.TblGorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblayinpersoneli.Text = db.TblPersonel.Where(x => x.ID == d1).Select(y => y.Ad+y.Soyad).FirstOrDefault().ToString();
            lblayindepartmani.Text = db.TblDepartman.Where(x => x.ID == db.TblPersonel.Where(t=>t.ID==d1).Select
                (z=>z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();
            lblsongorevdetay.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
        }
    }
}
