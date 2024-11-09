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
    public partial class FrmHesapMakinası : Form
    {
        public FrmHesapMakinası()
        {
            InitializeComponent();
        }

        private void FrmHesapMakinası_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            { textBox1.Text = "1"; }
            else
            { textBox1.Text = textBox1.Text + "1"; }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            { textBox1.Text = "2"; }
            else
            { textBox1.Text = textBox1.Text + "2"; }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            { textBox1.Text = "3"; }
            else
            { textBox1.Text = textBox1.Text + "3"; }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            { textBox1.Text = "4"; }
            else
            { textBox1.Text = textBox1.Text + "4"; }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            { textBox1.Text = "5"; }
            else
            { textBox1.Text = textBox1.Text + "5"; }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            { textBox1.Text = "6"; }
            else
            { textBox1.Text = textBox1.Text + "6"; }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            { textBox1.Text = "7"; }
            else
            { textBox1.Text = textBox1.Text + "7"; }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            { textBox1.Text = "8"; }
            else
            { textBox1.Text = textBox1.Text + "8"; }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            { textBox1.Text = "9"; }
            else
            { textBox1.Text = textBox1.Text + "9"; }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == null)
            { textBox1.Text = "0"; }
            else
            { textBox1.Text = textBox1.Text + "0"; }
        }

        private void BtnVirgul_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            secimDeger = 0;
        }

        string secim;
        double sonuc, secimDeger;
        void Sonuc()
        {
            sonuc = 0;
        }

        private void BtnToplama_Click(object sender, EventArgs e)
        {
            secim = "+";
            secimDeger = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void BtnCıkarma_Click(object sender, EventArgs e)
        {
            secim = "-";
            secimDeger = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void BtnCarpma_Click(object sender, EventArgs e)
        {
            secim = "*";
            secimDeger = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void BtnBolme_Click(object sender, EventArgs e)
        {
            secim = "/";
            secimDeger = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void BtnModAlma_Click(object sender, EventArgs e)
        {
            secim = "%";
            secimDeger = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void BtnEksiArti_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                if (textBox1.Text.StartsWith("-"))
                {
                    textBox1.Text = textBox1.Text.Replace("-","");
                }
                else if (textBox1.Text.StartsWith(""))
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        private void BtnEsittir_Click(object sender, EventArgs e)
        {
            double deger2 = Convert.ToDouble(textBox1.Text);
            if (secim == "+")
            {
                sonuc = secimDeger + deger2;
                textBox1.Text = sonuc.ToString();
                secimDeger = sonuc;
            }
            else if (secim == "-")
            {
                sonuc = secimDeger - deger2;
                textBox1.Text = sonuc.ToString();
                secimDeger = sonuc;
            }
            else if (secim == "*")
            {
                sonuc = secimDeger * deger2;
                textBox1.Text = sonuc.ToString();
                secimDeger = sonuc;
            }
            else if (secim == "/")
            {
                sonuc = secimDeger / deger2;
                textBox1.Text = sonuc.ToString();
                secimDeger = sonuc;
            }
            else if (secim == "%")
            {
                sonuc = secimDeger % deger2;
                textBox1.Text = sonuc.ToString();
                secimDeger = sonuc;
            }
        }   
    }
}
