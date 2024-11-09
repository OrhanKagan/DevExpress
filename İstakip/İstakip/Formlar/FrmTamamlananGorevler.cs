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
    public partial class FrmTamamlananGorevler : Form
    {
        public FrmTamamlananGorevler()
        {
            InitializeComponent();
        }

        DbisTakipEntitiess db = new DbisTakipEntitiess();

        private void FrmPasifCagri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.ID,
                                           x.GorevVeren,
                                           x.GorevAlan,
                                           x.Acıklama,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x => x.Durum == false).ToList();

            int a = gridView1.RowCount;
            if (a == 0)
            {
                XtraMessageBox.Show("Tamamlanan görev bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
