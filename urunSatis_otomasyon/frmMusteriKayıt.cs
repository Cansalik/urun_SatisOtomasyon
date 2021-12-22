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
    public partial class frmMusteriKayıt : Form
    {
        public frmMusteriKayıt()
        {
            InitializeComponent();
        }
        frmMusteriLogin frml = new frmMusteriLogin();
        private void pcr_Back_Click(object sender, EventArgs e)
        {
            frml.Show();
            this.Hide();
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_KayıtOl_Click(object sender, EventArgs e)
        {
            Musteri_Islemleri Mi = new Musteri_Islemleri();
            if (Msktxt_Tc.MaskFull == true)
            {
                Mi.Adi_Soyadi = textAdSoyad.Text;
                Mi.Adres = textAdres.Text;
                Mi.KullaniciAd = txt_Kadi.Text;
                Mi.KullaniciSifre = txt_Sifre.Text;
                Mi.Tc = Msktxt_Tc.Text;
                Mi.KayıtOl();
            }
            else
            {
                MessageBox.Show("Lütfen T.C. Kimlik Alanını Tam  Doldurunuz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btn_KayıtOl_MouseHover(object sender, EventArgs e)
        {
            btn_KayıtOl.ForeColor = Color.Green;
        }

        private void btn_KayıtOl_MouseLeave(object sender, EventArgs e)
        {
            btn_KayıtOl.ForeColor = Color.Black;
        }
    }
}
