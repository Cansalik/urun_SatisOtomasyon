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
    class Musteri_Islemleri
    {
        public string Tc { get; set; }
        public string Adi_Soyadi { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSifre { get; set; }
        public string Adres { get; set; }

        Sql bgl = new Sql();
        frmMusteriKayıt frmk = new frmMusteriKayıt();
        frmMusteriLogin frml = new frmMusteriLogin();
        public void KayıtOl()
        {
            if (KullaniciAd == "" || KullaniciSifre == "" || Tc == "" || Adi_Soyadi == "" || Adres == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Insert into Tbl_Musteri (TC,Adi_Soyadi,Kullanici_Adi,Sifre,Adres) Values ('" + Tc + "','" + Adi_Soyadi + "','" + KullaniciAd + "','" + KullaniciSifre + "','" + Adres + "')", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı\nKullanıcı Adınız: "+KullaniciAd.ToUpper()+"\nŞifreniz: "+KullaniciSifre.ToUpper(),"KAYIT TAMAMLANDI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frml.Show();
                frmk.Hide();
            }
        }
        public void giris()
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Musteri where Kullanici_Adi=@adi AND Sifre=@sifresi", bgl.baglanti());
            SqlParameter prm1 = new SqlParameter("adi", KullaniciAd.Trim());
            SqlParameter prm2 = new SqlParameter("sifresi", KullaniciSifre.Trim());
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                frmMusteri fm = new frmMusteri();
                fm.KullaniciAdi = KullaniciAd;
                fm.Show();
            }
            else if (KullaniciAd == "" && KullaniciSifre == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adını ve Şifre Alanını Boş Bırakmayınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmMusteriLogin frml = new frmMusteriLogin();
                frml.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmMusteriLogin frml = new frmMusteriLogin();
                frml.Show();
            }
        }
    }
}
