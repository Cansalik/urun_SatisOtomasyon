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
    public partial class frmYetkili : Form
    {
        public frmYetkili()
        {

            InitializeComponent();
            this.IsMdiContainer = true;
        }

        public string kadi;
        Sql bgl = new Sql();
        frmSiparisler frs = new frmSiparisler();//açılacak form
        frmYetkililer fry = new frmYetkililer();

        public void Listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select U.ID,K.Adi as 'Kategori',U.Adi as 'Ürünün Adı',BirimFiyat as 'Birim Fiyatı',Stok as 'Stoğu',U.KDV as 'KDV'from Tbl_Urunler U inner join Tbl_Kategori K on U.Kategori = K.ID", bgl.baglanti());
            da.Fill(dt1);
            dgw_Urun.DataSource = dt1;
            dgw_Urun.Columns[0].Visible = false;
        }
        public void Temizle_Ekle()
        {
            txt_Ekle_Adı.Clear();
            txt_Ekle_Fiyat.Clear();
            txt_Ekle_Miktar.Clear();
            cmb_Ekle_Kategori.Text = "";
            cmb_KDV_Urun_Ekle.Text = "";
        }
        public void Temizle_Guncelle()
        {
            txt_Guncelle_Ad.Clear();
            txt_Guncelle_Fiyat.Clear();
            txt_Guncelle_Miktar.Clear();
            cmb_Guncelle_Kategori.Text = "";
            cmb_KDV_Urun_Guncelle.Text = "";
        }
        private void Kategori()
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Kategori", bgl.baglanti());
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_Ekle_Kategori.Items.Add(dr["Adi"]);
                cmb_Guncelle_Kategori.Items.Add(dr["Adi"]);
            }
            bgl.baglanti().Close();
        }

        public void Kategori_Temizle()
        {
            cmb_Ekle_Kategori.Items.Clear();
            cmb_Guncelle_Kategori.Items.Clear();
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Urun.Hide();
            fry.Hide();
            frs.MdiParent = this;//bu formu parent olarak veriyoruz.
            frs.Show(); //form 2 açılıyor.
            Listele();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele();
            pnl_Urun.Show();
        }

        private void frmYetkili_Load(object sender, EventArgs e)
        {
            lbl_YetkiliKadi.Text = kadi;

            if (lbl_YetkiliKadi.Text == "Müdür")
            {
                yetkiliİşlemleriToolStripMenuItem.Enabled = false;
            }
            else if (lbl_YetkiliKadi.Text == "Personel")
            {
                yetkiliİşlemleriToolStripMenuItem.Enabled = false;
                ürünlerToolStripMenuItem.Enabled = false;
                frmSiparisler frs = new frmSiparisler();
                frs.Show();

            }
            Listele();
            Kategori();
        }

        private void yetkiliİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_Urun.Hide();
            frs.Hide();
            fry.MdiParent = this;//bu formu parent olarak veriyoruz.
            fry.Show(); //form 2 açılıyor.
        }

        private void geriGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYetkiliLogin frmyl = new frmYetkiliLogin();
            frmyl.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ururn_Ekle_MouseHover(object sender, EventArgs e)
        {
            btn_Ururn_Ekle.ForeColor = Color.Green;
        }

        private void btn_Ururn_Ekle_MouseLeave(object sender, EventArgs e)
        {
            btn_Ururn_Ekle.ForeColor = Color.Black;
        }

        private void btn_Urun_Guncelle_MouseHover(object sender, EventArgs e)
        {
            btn_Urun_Guncelle.ForeColor = Color.Yellow;
        }

        private void btn_Urun_Guncelle_MouseLeave(object sender, EventArgs e)
        {
            btn_Urun_Guncelle.ForeColor = Color.Black;
        }

        private void btn_Urun_Kaldır_MouseHover(object sender, EventArgs e)
        {
            btn_Urun_Kaldır.ForeColor = Color.Red;
        }

        private void btn_Urun_Kaldır_MouseLeave(object sender, EventArgs e)
        {
            btn_Urun_Kaldır.ForeColor = Color.Black;
        }
        private void dgw_Urun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dgw_Urun.SelectedCells[0].RowIndex;
            cmb_Guncelle_Kategori.Text = dgw_Urun.Rows[secilen].Cells[1].Value.ToString();
            txt_Guncelle_Ad.Text = dgw_Urun.Rows[secilen].Cells[2].Value.ToString();
            txt_Guncelle_Fiyat.Text = dgw_Urun.Rows[secilen].Cells[3].Value.ToString();
            txt_Guncelle_Miktar.Text = dgw_Urun.Rows[secilen].Cells[4].Value.ToString();
            lbl_UrunID.Text = dgw_Urun.Rows[secilen].Cells[0].Value.ToString();
            cmb_KDV_Urun_Guncelle.Text = dgw_Urun.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_Ururn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
            Urun_Islemleri _Urun = new Urun_Islemleri();
            _Urun.UrunAdi = txt_Ekle_Adı.Text;
            _Urun.Stok = int.Parse(txt_Ekle_Miktar.Text);
            _Urun.KategoriID = int.Parse(lbl_Ekle_KategoriID.Text);
            double Fiyat = double.Parse(txt_Ekle_Fiyat.Text);
            double _Kdv = double.Parse(cmb_KDV_Urun_Ekle.Text);
            Fiyat += (_Kdv * Fiyat) / 100;
            _Urun.BirimFiyat = Fiyat;
            _Urun.Kdv = _Kdv;
            _Urun.Urun_Ekle();
            Listele();
            Temizle_Ekle();
            }
            catch (Exception)
            {
               MessageBox.Show("Lütfen Eklenecek Ürünün Bilglerini Gerekli Alanlara Giriniz.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmb_Ekle_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand Com1 = new SqlCommand("select ID from Tbl_Kategori where Adi ='" + cmb_Ekle_Kategori.Text + "'", bgl.baglanti());
            SqlDataReader Dr1 = Com1.ExecuteReader();
            while (Dr1.Read())
            {
                lbl_Ekle_KategoriID.Text = Dr1[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void cmb_Guncelle_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand Com1 = new SqlCommand("select ID from Tbl_Kategori where Adi ='" + cmb_Guncelle_Kategori.Text + "'", bgl.baglanti());
            SqlDataReader Dr1 = Com1.ExecuteReader();
            while (Dr1.Read())
            {
                lbl_Guncelle_KategoriID.Text = Dr1[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btn_Urun_Guncelle_Click(object sender, EventArgs e)
        {
            double Guncellenecek_Fiyat, Kdv, Yeni_Fiyat;
            Guncellenecek_Fiyat = double.Parse(txt_Guncelle_Fiyat.Text);
            Kdv = double.Parse(cmb_KDV_Urun_Guncelle.Text);
            Guncellenecek_Fiyat += Guncellenecek_Fiyat * Kdv / 100;

            try
            {
                Urun_Islemleri _Urun = new Urun_Islemleri();
                _Urun.UrunAdi = txt_Guncelle_Ad.Text;
                _Urun.BirimFiyat = Guncellenecek_Fiyat;
                _Urun.Stok = int.Parse(txt_Guncelle_Miktar.Text);
                _Urun.KategoriID = int.Parse(lbl_Guncelle_KategoriID.Text);
                _Urun.Kdv = int.Parse(cmb_KDV_Urun_Guncelle.Text);
                _Urun.UrunID = int.Parse(lbl_UrunID.Text);
                _Urun.Urun_Guncelle();
                Listele();
                Temizle_Guncelle();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Güncellenecek Ürünün Bilglerini Gerekli Alanlara Giriniz.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Urun_Kaldır_Click(object sender, EventArgs e)
        {
           try
           {
                Urun_Islemleri _Urun = new Urun_Islemleri();
                _Urun.UrunAdi = txt_Guncelle_Ad.Text;
                _Urun.BirimFiyat = double.Parse(txt_Guncelle_Fiyat.Text);
                _Urun.Stok = int.Parse(txt_Guncelle_Miktar.Text);
                _Urun.KategoriID = int.Parse(lbl_Guncelle_KategoriID.Text);
                _Urun.UrunID = int.Parse(lbl_UrunID.Text);
                _Urun.Urun_Sil();
                Listele();
                Temizle_Guncelle();
           }
           catch (Exception)
           {
                MessageBox.Show("Lütfen Silinecek Ürünün Bilglerini Yukarıdaki Alana Giriniz.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
        }

        private void btn_Kategori_Ekle_MouseHover(object sender, EventArgs e)
        {
            btn_Kategori_Ekle.ForeColor = Color.Green;

        }

        private void btn_Kategori_Ekle_MouseLeave(object sender, EventArgs e)
        {
            btn_Kategori_Ekle.ForeColor = Color.Black;

        }

        private void btn_Kategori_Ekle_Click(object sender, EventArgs e)
        {
            Urun_Islemleri _Urun = new Urun_Islemleri();
            _Urun.KategoriAdi = txt_KategoriAdi.Text;
            _Urun.Kategori_Ekle();
            Kategori_Temizle();
            Kategori();
            txt_KategoriAdi.Clear();
        }
    }
}