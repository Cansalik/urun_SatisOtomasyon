using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace urunSatis_otomasyon
{
    class Sepet_Islemleri
    {
        public string UrunAd { get; set; }
        public int Adet { get; set; }
        public int Mid { get; set; }

        Sql bgl = new Sql();

        public void UrunEkle()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Sepet (Adi,Adet,Mid) Values ('" + UrunAd + "','" + Adet + "','" + Mid + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void UrunEkle1()
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Sepet1 (Adi,Adet,Mid) Values ('" + UrunAd + "','" + Adet + "','" + Mid + "')", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void UrunSil()
        {
            SqlCommand Com = new SqlCommand("delete from Tbl_Sepet where Adi=@Adi AND Mid=@Mid", bgl.baglanti());
            Com.Parameters.AddWithValue("@Adi", UrunAd);
            Com.Parameters.AddWithValue("@Mid", Mid);
            Com.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void UrunSil1()
        {
            SqlCommand Com = new SqlCommand("delete from Tbl_Sepet1 where Adi=@Adi", bgl.baglanti());
            Com.Parameters.AddWithValue("@Adi", UrunAd);
            Com.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
