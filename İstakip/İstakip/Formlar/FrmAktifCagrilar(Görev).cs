using DevExpress.XtraEditors;
using İstakip.Entity;
using İstakip.PersonelGorevFormlari;
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
    public partial class FrmAktifCagrilar : Form
    {
        public FrmAktifCagrilar()
        {
            InitializeComponent();
        }

        DbisTakipEntitiess db = new DbisTakipEntitiess();

        private void FrmAktifCagrilar_Load(object sender, EventArgs e)
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
                                       }).Where(x => x.Durum == true).ToList();
            int a = gridView1.RowCount;
            if (a == 0)
            {
                XtraMessageBox.Show("Aktif ağrı bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagriAtama fr = new FrmCagriAtama();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
