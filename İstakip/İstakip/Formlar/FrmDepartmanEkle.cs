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
    public partial class FrmDepartmanEkle : Form
    {
        public FrmDepartmanEkle()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblDepartman t = new TblDepartman();
            t.Ad = TxtAdi.Text;
            db.TblDepartman.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
