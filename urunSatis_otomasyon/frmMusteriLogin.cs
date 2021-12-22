using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urunSatis_otomasyon
{
    public partial class frmMusteriLogin : Form
    {
        public frmMusteriLogin()
        {
            InitializeComponent();
        }
        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pcr_Back_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pcr_Gizli.Visible = false;
                pcr_Gorunur.Visible = true;
                txt_Sifre.UseSystemPasswordChar = false;
            }
            if (checkBox1.Checked == false)
            {
                pcr_Gizli.Visible = true;
                pcr_Gorunur.Visible = false;
                txt_Sifre.UseSystemPasswordChar = true;
            }
        }
        private void pcr_Back_Click_1(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Musteri_Islemleri Mi = new Musteri_Islemleri();
            Mi.KullaniciAd = txt_Kadi.Text;
            Mi.KullaniciSifre = txt_Sifre.Text;
            Mi.giris();
            this.Hide();
        }
        private void pcr_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMusteriKayıt frmk = new frmMusteriKayıt();
            frmk.Show();
            this.Hide();
        }
    }
}
