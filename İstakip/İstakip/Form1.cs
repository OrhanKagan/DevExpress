using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İstakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Formlar.FrmDepartman frm;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.FrmDepartman();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        Formlar.FrmPersoneller frm2;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Formlar.FrmPersoneller();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        Formlar.FrmPersonelİstatistik frm3;
        private void BtnPersonelİstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.FrmPersonelİstatistik();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        Formlar.FrmGörevListesi frm4;
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.FrmGörevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            } 
        }

        Formlar.frmGorev frm5;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new Formlar.frmGorev();
                frm5.Show();
            }
        }

        Formlar.FrmGorevDetay frm6;
        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new Formlar.FrmGorevDetay();
                frm6.Show();
            }
        }

        Formlar.FrmAnaFrom frm7;
        private void BtnAnaFrom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new Formlar.FrmAnaFrom();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }

        

        public string MailVeri { get; internal set; }

        Formlar.FrmAktifCagri frm8;

        private void BtnAktifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new Formlar.FrmAktifCagri();
                frm8.MdiParent = this;
                frm8.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        Formlar.FrmHesapMakinası frm9;
        private void BtnHesapMakinasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new Formlar.FrmHesapMakinası();
                frm9.Show();
            }
        }

        Formlar.FrmFirmalar frm10;
        private void FrmFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new Formlar.FrmFirmalar();
                frm10.MdiParent = this;
                frm10.Show();
            }
        }

        Formlar.FrmAktifCagrilar frm11;
        private void BtnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm11 == null || frm11.IsDisposed)
            {
                frm11 = new Formlar.FrmAktifCagrilar();
                frm11.MdiParent = this;
                frm11.Show();
            }
        }

        Formlar.FrmPasifCagrı frm12;
        private void BtnPasifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Formlar.FrmPasifCagrı();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }

        Formlar.FrmDepartmanİstatistik frm13;      private void BtnDepartmanİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm13 == null || frm13.IsDisposed)
            {
                frm13 = new Formlar.FrmDepartmanİstatistik();
                frm13.MdiParent = this;
                frm13.Show();
            }
        }

        Formlar.FrmFirmaİstatistikleri frm14;
        private void BtnFirmaİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm14 == null || frm14.IsDisposed)
            {
                frm14 = new Formlar.FrmFirmaİstatistikleri();
                frm14.MdiParent = this;
                frm14.Show();
            }
        }

        Formlar.FrmGorevİstatistik frm15;

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm15 == null || frm15.IsDisposed)
            {
                frm15 = new Formlar.FrmGorevİstatistik();
                frm15.MdiParent = this;
                frm15.Show();
            }
        }

        Formlar.FrmTamamlananGorevler frm16;
        private void BtnTamamlanangorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm16 == null || frm16.IsDisposed)
            {
                frm16 = new Formlar.FrmTamamlananGorevler();
                frm16.MdiParent = this;
                frm16.Show();
            }
        }

        Formlar.FrmKurlar frm17;
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm17 == null || frm17.IsDisposed)
            {
                frm17 = new Formlar.FrmKurlar();
                frm17.MdiParent = this;
                frm17.Show();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://muratyucedag.com/");
        }
    }
}
