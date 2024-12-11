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
    public partial class FrmDepartmanİstatistik : Form
    {
        public FrmDepartmanİstatistik()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmDepartmanİstatistik_Load(object sender, EventArgs e)
        {
            var d1 = db.TblGorevler.GroupBy(x => x.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lbltoplamdepartman.Text = db.TblDepartman.Count().ToString();
            lblayindepartmani.Text = db.TblDepartman.Where(x => x.ID == db.TblPersonel.Where(t => t.ID == d1).Select
                (z => z.Departman).FirstOrDefault()).Select(y => y.Ad).FirstOrDefault().ToString();
        }
    }
}
