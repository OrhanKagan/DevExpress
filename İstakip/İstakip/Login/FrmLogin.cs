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

namespace İstakip.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textEdit3_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DbisTakipEntities db = new DbisTakipEntities();

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            var adminvalue = db.TblAdmin.Where(x => x.Kullanici == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if(adminvalue!= null)
            {
                Form1 fr = new Form1();
                XtraMessageBox.Show("Hoşgeldiniz","Bilgi",MessageBoxButtons.OK);
                fr.Show();
            }
            else
            {
                XtraMessageBox.Show("Hata Giriş", "Bilgi", MessageBoxButtons.OK);
            }
        }

        private void BtnPersonel_Click(object sender, EventArgs e)
        {
            var personelvalue = db.TblPersonel.Where(x => x.Mail == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (personelvalue != null)
            {
                XtraMessageBox.Show("Hoşgeldiniz", "Bilgi", MessageBoxButtons.OK);
                PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
                fr.mail = TxtKullanici.Text;
                fr.Show();
            }
            else
            {
                XtraMessageBox.Show("Hata Giriş", "Bilgi", MessageBoxButtons.OK);
            }
        }

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
