using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace urunSatis_otomasyon
{
    class Urun_Islemleri
    {
        public int KategoriID { get; set; }
        public string UrunAdi { get; set; }
        public double BirimFiyat { get; set; }
        public int Stok { get; set; }
        public int UrunID { get; set; }
        public string KategoriAdi { get; set; }
        public double Kdv { get; set; }

        Sql bgl = new Sql();
        public void Urun_Ekle()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Urunler (Kategori,Adi,BirimFiyat,Stok,KDV) Values ('" + KategoriID + "','" + UrunAdi + "','" + BirimFiyat + "','"+Stok+ "','" + Kdv + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Veriler Eklenmiştir");
        }

        public void Urun_Guncelle()
        {
            SqlCommand Com2 = new SqlCommand("update Tbl_Urunler set Kategori=@Kategori_ID,Adi=@Adi,BirimFiyat=@BirimFiyat,Stok=@Stok,KDV=@KDV where ID=@ID", bgl.baglanti());
            Com2.Parameters.AddWithValue("@Kategori_ID", KategoriID);
            Com2.Parameters.AddWithValue("@Adi", UrunAdi);
            Com2.Parameters.AddWithValue("@BirimFiyat", BirimFiyat);
            Com2.Parameters.AddWithValue("@Stok", Stok);
            Com2.Parameters.AddWithValue("@KDV", Kdv);
            Com2.Parameters.AddWithValue("@ID", UrunID);
            Com2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Veriler Guncellenmiştir");
        }

        public void Urun_Sil()
        {
            SqlCommand Com = new SqlCommand("delete from Tbl_Urunler where ID=@ID", bgl.baglanti());
            Com.Parameters.AddWithValue("@ID", UrunID);
            Com.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün  Depodan Silinmiştir.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Kategori_Ekle()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Kategori (Adi) Values ('" + KategoriAdi + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kategori Eklenmiştir");
        }


    }
}
