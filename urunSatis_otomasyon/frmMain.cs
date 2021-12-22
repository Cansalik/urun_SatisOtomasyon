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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Yetkili_Click(object sender, EventArgs e)
        {
            frmYetkiliLogin fYTL = new frmYetkiliLogin();
            fYTL.Show();
            this.Hide();
        }

        private void btn_Musteri_Click(object sender, EventArgs e)
        {
            frmMusteriLogin fml = new frmMusteriLogin();
            fml.Show();
            this.Hide();
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
