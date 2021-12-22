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
    class Yetkili_Islemleri
    {

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
        public int id { get; set; }

        Sql bgl = new Sql();
        public void VerileriGetir()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Yetkililer", bgl.baglanti());
            da.Fill(dt1);
            
        }
        public void Yetkili_Ekle()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Yetkili (Kullanici_Adi,Sifre,Yetki) Values ('" + KullaniciAdi + "','" + Sifre + "','" + Yetki + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Veriler Eklenmiştir");
        }
        public void Yetkili_Guncelle()
        {
            SqlCommand Com2 = new SqlCommand("update Tbl_Yetkili set Kullanici_Adi=@Kullanici_Adi,Sifre=@Sifre,Yetki=@Yetki where ID=@ID", bgl.baglanti());
            Com2.Parameters.AddWithValue("@Kullanici_Adi", KullaniciAdi);
            Com2.Parameters.AddWithValue("@Sifre", Sifre);
            Com2.Parameters.AddWithValue("@Yetki",Yetki);
            Com2.Parameters.AddWithValue("@ID", id);
            Com2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Veriler Guncellenmiştir");

        }
        public void Yetkili_Sil()
        {
            SqlCommand Com = new SqlCommand("delete from Tbl_Yetkili where ID=@ID", bgl.baglanti());
            Com.Parameters.AddWithValue("@ID", id);
            Com.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yetkili  Listeden Silinmiştir.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void giris()
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select * From Tbl_Yetkili where Kullanici_Adi=@adi AND Sifre=@sifresi and Yetki=@Yetki", bgl.baglanti());
                SqlParameter prm1 = new SqlParameter("adi", KullaniciAdi.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", Sifre.Trim());
                SqlParameter prm3 = new SqlParameter("Yetki", Yetki.Trim());
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                komut.Parameters.Add(prm3);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frmYetkili fry = new frmYetkili();
                    fry.kadi = Yetki;
                    fry.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmYetkiliLogin fyl = new frmYetkiliLogin();
                    fyl.Show();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Boş Geçmeyin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmYetkiliLogin fyl = new frmYetkiliLogin();
                fyl.Show();
            }
        }
    }
}
