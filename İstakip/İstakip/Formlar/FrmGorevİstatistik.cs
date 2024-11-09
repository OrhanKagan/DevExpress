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
    public partial class FrmGorevİstatistik : Form
    {
        public FrmGorevİstatistik()
        {
            InitializeComponent();
        }

        DbisTakipEntitiess db = new DbisTakipEntitiess();

        private void FrmGorevİstatistik_Load(object sender, EventArgs e)
        {
            lblsongorevdetay.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
            lblsongorev.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Acıklama).FirstOrDefault();
            DateTime bugun = DateTime.Today;
            lblbugunkugorevler.Text = db.TblGorevler.Count(x => x.Tarih == bugun).ToString();
            lbltoplampersonel.Text = db.TblGorevler.Count().ToString();

        }
    }
}
