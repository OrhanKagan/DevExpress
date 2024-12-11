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
    public partial class FrmFirmaİstatistikleri : Form
    {
        public FrmFirmaİstatistikleri()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void FrmFirmaİstatistikleri_Load(object sender, EventArgs e)
        {
            lbltoplamfirma.Text = db.TblFirmalar.Count().ToString();
            lblsektor.Text = db.TblFirmalar.Select(x => x.Sektör).Distinct().Count().ToString();
            lblsehir.Text = db.TblFirmalar.Select(x => x.il).Distinct().Count().ToString();
        }
    }
}
