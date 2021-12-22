using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace urunSatis_otomasyon
{
    public partial class frmYetkililer : Form
    {
        Sql bgl = new Sql();
        private void Listele()
        {
            Yetkili_Islemleri yt = new Yetkili_Islemleri();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Yetkili", bgl.baglanti());
            da.Fill(dt1);
            dgw_Yetkili.DataSource = dt1;
        }
        private void temizle()
        {
            txt_Ekle_Adı.Text = "";
            txt_Ekle_Parola.Text = "";
            txt_GuncelAdi.Text = "";
            txt_GuncelParola.Text = "";
            cmb_GuncelleYetki.Text = "";
            cmb_Yetki.Text = "";
        }
        public frmYetkililer()
        {
            InitializeComponent();
        }

        private void btn_Yetkili_Ekle_MouseHover(object sender, EventArgs e)
        {
            btn_Yetkili_Ekle.ForeColor = Color.Green;
        }

        private void btn_Yetkili_Ekle_MouseLeave(object sender, EventArgs e)
        {
            btn_Yetkili_Ekle.ForeColor = Color.Black;

        }

        private void btn_Yetkili_Guncelle_MouseHover(object sender, EventArgs e)
        {
            btn_Yetkili_Guncelle.ForeColor = Color.Yellow;

        }

        private void btn_Yetkili_Guncelle_MouseLeave(object sender, EventArgs e)
        {
            btn_Yetkili_Guncelle.ForeColor = Color.Black;
        }

        private void btn_Yetkili_Kaldir_MouseHover(object sender, EventArgs e)
        {
            btn_Yetkili_Kaldir.ForeColor = Color.Red;

        }

        private void btn_Yetkili_Kaldir_MouseLeave(object sender, EventArgs e)
        {
            btn_Yetkili_Kaldir.ForeColor = Color.Black;
        }

        private void btn_Yetkili_Ekle_Click(object sender, EventArgs e)
        {
            Yetkili_Islemleri YKI = new Yetkili_Islemleri();
            YKI.KullaniciAdi = txt_Ekle_Adı.Text;
            YKI.Sifre = txt_Ekle_Parola.Text;
            YKI.Yetki = cmb_Yetki.Text;
            YKI.Yetkili_Ekle();
            Listele();
            temizle();
        }

        private void frmYetkililer_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_Yetkili_Guncelle_Click(object sender, EventArgs e)
        {
            Yetkili_Islemleri YKI = new Yetkili_Islemleri();
            YKI.KullaniciAdi = txt_GuncelAdi.Text;
            YKI.Sifre = txt_GuncelParola.Text;
            YKI.Yetki = cmb_GuncelleYetki.Text;
            YKI.id = int.Parse(lbl_id.Text);
            YKI.Yetkili_Guncelle();
            Listele();
            temizle();
        }

        private void dgw_Yetkili_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgw_Yetkili.SelectedCells[0].RowIndex;
            lbl_id.Text = dgw_Yetkili.Rows[secilen].Cells[0].Value.ToString();
            txt_GuncelAdi.Text= dgw_Yetkili.Rows[secilen].Cells[1].Value.ToString();
            txt_GuncelParola.Text = dgw_Yetkili.Rows[secilen].Cells[2].Value.ToString();
            cmb_GuncelleYetki.Text = dgw_Yetkili.Rows[secilen].Cells[3].Value.ToString();
            cmb_GuncelleYetki.Text = dgw_Yetkili.Rows[secilen].Cells[3].Value.ToString();

        }

        private void btn_Yetkili_Kaldir_Click(object sender, EventArgs e)
        {

            Yetkili_Islemleri YKI = new Yetkili_Islemleri();
            YKI.id = int.Parse(lbl_id.Text);
            YKI.Yetkili_Sil();
            Listele();
            temizle();
        }
    }
}
