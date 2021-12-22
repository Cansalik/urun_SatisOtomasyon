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
    class SiparisOnayla
    {
        public string UrunAdi { get; set; }
        public int Mid { get; set; }
        public int Stok { get; set; }

        Sql bgl = new Sql();
        public void Odemeyi_Tamamla()
        {
            SqlCommand Com = new SqlCommand("Truncate Table Tbl_Sepet1", bgl.baglanti());
            Com.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        public void YetkiliSiparisOnayla()
        {
            SqlCommand Com = new SqlCommand("delete from Tbl_Sepet where Adi='"+UrunAdi+"' AND Mid= '"+Mid+"'", bgl.baglanti());
            Com.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public void StokAzalt()
        {
            SqlCommand Com2 = new SqlCommand("update Tbl_Urunler set Stok=@Stok where Adi=@Adi", bgl.baglanti());
            Com2.Parameters.AddWithValue("@Stok", Stok);
            Com2.Parameters.AddWithValue("@Adi", UrunAdi);
            Com2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

    }
}
