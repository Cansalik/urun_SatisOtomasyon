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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }
        SiparisOnayla spo = new SiparisOnayla();
        Sql bgl = new Sql();
        public string KullaniciAdi;
        private void Listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select K.Adi as 'Kategori',U.Adi as 'Ürünün Adı',BirimFiyat as 'Birim Fiyatı' from Tbl_Urunler U inner join Tbl_Kategori K on U.Kategori = K.ID", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        private void ListeleSepet()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select U.Adi,S.Adet,u.BirimFiyat from Tbl_Sepet1 S inner join Tbl_Urunler U on S.Adi = U.Adi", bgl.baglanti());
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }


        private void OdemeKontrol()
        {
            if (rdb_Kart.Checked == true & rdb_Nakit.Checked == false && rdb_Kripto.Checked == false)
            {
                MessageBox.Show("Lütfen Kart Bilgilerinizi Sağdaki Alana Doldurunuz.", "BİLGİLENDİRME!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpbx_Kripto.Visible = false;
                grpbx_Kart.Visible = true;
            }
            else if (rdb_Kart.Checked == false & rdb_Nakit.Checked == true && rdb_Kripto.Checked == false)
            {
                grbpxNakit.Visible = true;
                grpbx_Kart.Visible = false;
                grpbx_Kripto.Visible = false;
            }
            else if (rdb_Kart.Checked == false & rdb_Nakit.Checked == false && rdb_Kripto.Checked == true)
            {
                MessageBox.Show("Lütfen Mağazamızın XRP Adresine, XRP Gönderirken, Doğru    Cüzdan Adresini Girdiğinizden ve Destination Tag'in Doğru Olduğundan Emin Olunuz!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grpbx_Kart.Visible = false;
                grpbx_Kripto.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen Bir Seçim Yapınız!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {
            frmMusteriLogin fml = new frmMusteriLogin();
            spo.Odemeyi_Tamamla();
            fml.Show();
            this.Hide();
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            spo.Odemeyi_Tamamla();
        }

        private void btn_KayıtOl_MouseHover(object sender, EventArgs e)
        {
            btn_SepeteEkle.ForeColor = Color.DeepSkyBlue;
        }

        private void btn_KayıtOl_MouseLeave(object sender, EventArgs e)
        {
            btn_SepeteEkle.ForeColor = Color.Black;

        }

        private void btn_Odeme_MouseHover(object sender, EventArgs e)
        {
            btn_Odeme.ForeColor = Color.Green;
        }

        private void btn_Odeme_MouseLeave(object sender, EventArgs e)
        {
            btn_Odeme.ForeColor = Color.Black;
        }

        private void btn_Odeme_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                OdemeKontrol();
                SqlCommand Com1 = new SqlCommand("select Kart_No,SKT,CVC,Adres from Tbl_Musteri where ID ='" + lbl_KullaniciId.Text + "'", bgl.baglanti());
                SqlDataReader Dr1 = Com1.ExecuteReader();
                while (Dr1.Read())
                {
                    mskTxt_KartNo.Text = Dr1[0].ToString();
                    mskTxt_Kart_SKT.Text = Dr1[1].ToString();
                    mskTxt_Kart_CVC.Text = Dr1[2].ToString();
                    txtAdres.Text = Dr1[3].ToString();
                }
                bgl.baglanti().Close();
                rdb_Nakit.Checked = false;
                rdb_Kart.Checked = false;
                rdb_Kripto.Checked = false;
            }
            else
            {
                MessageBox.Show("SEPETİNİZ BOŞ!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void pcr_XRP_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblXRP.Text);
        }

        private void pcr_TAG_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblTAG.Text);
        }

        private void btn_Kripto_Odeme_MouseHover(object sender, EventArgs e)
        {
            btn_Kripto_Odeme.ForeColor = Color.Green;
        }

        private void btn_Kripto_Odeme_MouseLeave(object sender, EventArgs e)
        {
            btn_Kripto_Odeme.ForeColor = Color.Black;

        }

        private void btn_Kart_Odeme_MouseHover(object sender, EventArgs e)
        {
            btn_Kart_Odeme.ForeColor = Color.Green;

        }

        private void btn_Kart_Odeme_MouseLeave(object sender, EventArgs e)
        {
            btn_Kart_Odeme.ForeColor = Color.Black;

        }

        double toplam = 0, a = 0;

        private void btn_SepeteEkle_Click(object sender, EventArgs e)
        {
            try
            {
                a = 1;
                Sepet_Islemleri Se = new Sepet_Islemleri();
                Se.UrunAd = txt_Aranan.Text;
                Se.Adet = int.Parse(txt_Adet.Text);
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                Se.Mid = int.Parse(lbl_KullaniciId.Text);
                Se.UrunEkle();
                Se.UrunEkle1();
                ListeleSepet();

                double deger;
                deger = double.Parse(lblFiyat.Text) * double.Parse(txt_Adet.Text);
                toplam = toplam + deger;
                lblToplamFiyat.Text = toplam + " TL";
                txt_Adet.Text = "";
                txt_Aranan.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Adet Kısmını Boş Geçmeyin!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            lbl_Kulanici.Text = KullaniciAdi;
            SqlCommand Com1 = new SqlCommand("select ID,Adi_Soyadi from Tbl_Musteri where Kullanici_Adi ='" + KullaniciAdi + "'", bgl.baglanti());
            SqlDataReader Dr1 = Com1.ExecuteReader();
            while (Dr1.Read())
            {
                lbl_KullaniciId.Text = Dr1[0].ToString();
                lbl_Musteri_Adi.Text = Dr1[1].ToString();
            }
            Listele();
            ListeleSepet();

        }

        private void txt_Aranan_TextChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select K.Adi as 'Kategori',U.Adi as 'Ürünün Adı',BirimFiyat as 'Birim Fiyatı' from Tbl_Urunler U inner join Tbl_Kategori K on U.Kategori = K.ID WHERE U.Adi LIKE '" + txt_Aranan.Text + "%'", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblFiyat.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Aranan.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
        private void btn_SepetBosalt_Click(object sender, EventArgs e)
        {
            try
            {
                Sepet_Islemleri Se = new Sepet_Islemleri();
                Se.Mid = int.Parse(lbl_KullaniciId.Text);
                Se.UrunAd = lbl_SepetSecilen.Text;
                Se.UrunSil();
                Se.UrunSil1();
                double deger = double.Parse(lbl_Fiyat_Sepet.Text) * double.Parse(lbl_SepetAdet.Text);
                toplam = toplam - deger;
                lblToplamFiyat.Text = toplam + " TL";
                MessageBox.Show("Ürün Listeden Silinmiştir.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ListeleSepet();
            }
            catch (Exception)
            {
                MessageBox.Show("Boş Sepet'ten Ürün Silinemez!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btn_SepetBosalt_MouseHover(object sender, EventArgs e)
        {
            btn_SepetBosalt.ForeColor = Color.Red;
        }

        private void btn_SepetBosalt_MouseLeave(object sender, EventArgs e)
        {
            btn_SepetBosalt.ForeColor = Color.Black;

        }

        private void btn_Kripto_Odeme_Click(object sender, EventArgs e)
        {
            spo.Odemeyi_Tamamla();
            ListeleSepet();
            grpbx_Kripto.Visible = false;
            MessageBox.Show("XRP Yatırma işleminiz onaylandıktan sonra siparişiniz \ngönderilecektir.","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
            lblToplamFiyat.Text = "00.00 TL";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            lbl_SepetSecilen.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            lbl_SepetAdet.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            lbl_Fiyat_Sepet.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
        }

        private void btn_Nakit_Odeme_Click(object sender, EventArgs e)
        {
            spo.Odemeyi_Tamamla();
            MessageBox.Show("Kapıda Ödeme Seçeneği Seçildi.", "BİLGİLENDİRME!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListeleSepet();
            lblToplamFiyat.Text = "00.00 TL";
            txtAdres.Clear();
            grbpxNakit.Visible = false;
        }

        private void btn_Nakit_Odeme_MouseHover(object sender, EventArgs e)
        {
            btn_Nakit_Odeme.ForeColor = Color.Green;
        }

        private void btn_Nakit_Odeme_MouseLeave(object sender, EventArgs e)
        {
            btn_Nakit_Odeme.ForeColor = Color.Black;
        }

        private void btn_Kart_Odeme_Click(object sender, EventArgs e)
        {
            SqlCommand Com2 = new SqlCommand("update Tbl_Musteri set Kart_No=@Kart_No,SKT=@SKT,CVC=@CVC where ID=@ID", bgl.baglanti());
            Com2.Parameters.AddWithValue("@Kart_No", mskTxt_KartNo.Text);
            Com2.Parameters.AddWithValue("@SKT", mskTxt_Kart_SKT.Text);
            Com2.Parameters.AddWithValue("@CVC", mskTxt_Kart_CVC.Text);
            Com2.Parameters.AddWithValue("@ID", lbl_KullaniciId.Text);
            Com2.ExecuteNonQuery();
            bgl.baglanti().Close();
            spo.Odemeyi_Tamamla();
            ListeleSepet();
            mskTxt_KartNo.Clear();
            mskTxt_Kart_CVC.Clear();
            mskTxt_Kart_SKT.Clear();
            MessageBox.Show("Siparişiniz Alınmıştır", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grpbx_Kart.Visible = false;
            lblToplamFiyat.Text = "00.00 TL";
        }
    }
}
