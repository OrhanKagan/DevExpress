using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstakip.PersonelGorevFormlari
{
    public partial class FrmPersonelFormu : Form
    {
        public FrmPersonelFormu()
        {
            InitializeComponent();
        }

        public string mail;

        private void FrmPersonelFormu_Load(object sender, EventArgs e)
        {

        }

        private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FrmAktifGorevler frm = new PersonelGorevFormlari.FrmAktifGorevler();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FrmPasifGorevler frm1 = new PersonelGorevFormlari.FrmPasifGorevler();
            frm1.MdiParent = this;
            frm1.mail2 = mail;
            frm1.Show();
        }

        private void BtnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FrmCagriListesi frm2 = new PersonelGorevFormlari.FrmCagriListesi();
            frm2.MdiParent = this;
            frm2.mail2 = mail;
            frm2.Show();
        }
    }
}
