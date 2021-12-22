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
    public partial class frmSiparisler : Form
    {
        public frmSiparisler()
        {
            InitializeComponent();
        }
        Sql bgl = new Sql();
        private void Listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select M.Adi_Soyadi as 'Adı Soyadı',S.Adi,S.Adet,m.Adres,s.Mid from Tbl_Sepet S inner join Tbl_Musteri M on S.Mid = M.ID", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[4].Visible = false;
        }

        private void Stokİslem()
        {
            SqlCommand komut = new SqlCommand("select BirimFiyat,Stok from Tbl_Urunler where Adi = '"+txt_SecilenSiparis.Text+"'", bgl.baglanti());
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_Urun_Fiyat.Text = dr[0].ToString();
                lbl_Eski_Stok.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btn_Siparis_Onay_MouseHover(object sender, EventArgs e)
        {
            btn_Siparis_Onay.ForeColor = Color.Green;
        }
        private void btn_Siparis_Onay_MouseLeave(object sender, EventArgs e)
        {
            btn_Siparis_Onay.ForeColor = Color.Black;
        }
        private void frmSiparisler_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void btn_Siparis_Onay_Click(object sender, EventArgs e)
        {
            int Yeni = 0;
            SiparisOnayla Spo = new SiparisOnayla();
            Spo.UrunAdi = txt_SecilenSiparis.Text;
            Spo.Mid = int.Parse(lbl_MusteriID.Text);
            Spo.YetkiliSiparisOnayla();
            Yeni = int.Parse(lbl_Eski_Stok.Text) - int.Parse(lbl_Siparis_Adet.Text);
            Spo.Stok = Yeni;
            Spo.StokAzalt();
            MessageBox.Show("Sipariş Onaylandı.");
            Listele();
            txt_SecilenSiparis.Clear();
            txt_Adres.Clear();
            lbl_MusteriID.Text = "";
            lbl_Alinacak_Ucret.Text = "00.00 TL";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_SecilenSiparis.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            lbl_Siparis_Adet.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Adres.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            lbl_MusteriID.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Stokİslem();
            double Alinacak;
            Alinacak = double.Parse(lbl_Siparis_Adet.Text) * double.Parse(lbl_Urun_Fiyat.Text);
            lbl_Alinacak_Ucret.Text = double.Parse(Alinacak.ToString()) + " TL";
        }
    }
}
