
namespace urunSatis_otomasyon
{
    partial class frmSiparisler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Siparis_Onay = new System.Windows.Forms.Button();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.txt_SecilenSiparis = new System.Windows.Forms.TextBox();
            this.lbl_MusteriID = new System.Windows.Forms.Label();
            this.lbl_Siparis_Adet = new System.Windows.Forms.Label();
            this.lbl_Eski_Stok = new System.Windows.Forms.Label();
            this.lbl_Urun_Fiyat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Alinacak_Ucret = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.Location = new System.Drawing.Point(6, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(924, 240);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(3, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seçilen Sipariş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(266, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sipariş Adresi:";
            // 
            // btn_Siparis_Onay
            // 
            this.btn_Siparis_Onay.BackColor = System.Drawing.Color.Transparent;
            this.btn_Siparis_Onay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Siparis_Onay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Siparis_Onay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Siparis_Onay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Siparis_Onay.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Siparis_Onay.Location = new System.Drawing.Point(519, 340);
            this.btn_Siparis_Onay.Name = "btn_Siparis_Onay";
            this.btn_Siparis_Onay.Size = new System.Drawing.Size(99, 48);
            this.btn_Siparis_Onay.TabIndex = 10;
            this.btn_Siparis_Onay.Text = "SİPARİŞİ ONAYLA";
            this.btn_Siparis_Onay.UseVisualStyleBackColor = false;
            this.btn_Siparis_Onay.Click += new System.EventHandler(this.btn_Siparis_Onay_Click);
            this.btn_Siparis_Onay.MouseLeave += new System.EventHandler(this.btn_Siparis_Onay_MouseLeave);
            this.btn_Siparis_Onay.MouseHover += new System.EventHandler(this.btn_Siparis_Onay_MouseHover);
            // 
            // txt_Adres
            // 
            this.txt_Adres.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_Adres.Location = new System.Drawing.Point(349, 260);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(164, 128);
            this.txt_Adres.TabIndex = 4;
            // 
            // txt_SecilenSiparis
            // 
            this.txt_SecilenSiparis.Enabled = false;
            this.txt_SecilenSiparis.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txt_SecilenSiparis.Location = new System.Drawing.Point(89, 263);
            this.txt_SecilenSiparis.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SecilenSiparis.Name = "txt_SecilenSiparis";
            this.txt_SecilenSiparis.Size = new System.Drawing.Size(98, 22);
            this.txt_SecilenSiparis.TabIndex = 11;
            // 
            // lbl_MusteriID
            // 
            this.lbl_MusteriID.AutoSize = true;
            this.lbl_MusteriID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MusteriID.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_MusteriID.Location = new System.Drawing.Point(255, 420);
            this.lbl_MusteriID.Name = "lbl_MusteriID";
            this.lbl_MusteriID.Size = new System.Drawing.Size(25, 14);
            this.lbl_MusteriID.TabIndex = 12;
            this.lbl_MusteriID.Text = "......";
            this.lbl_MusteriID.Visible = false;
            // 
            // lbl_Siparis_Adet
            // 
            this.lbl_Siparis_Adet.AutoSize = true;
            this.lbl_Siparis_Adet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Siparis_Adet.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Siparis_Adet.Location = new System.Drawing.Point(3, 420);
            this.lbl_Siparis_Adet.Name = "lbl_Siparis_Adet";
            this.lbl_Siparis_Adet.Size = new System.Drawing.Size(87, 14);
            this.lbl_Siparis_Adet.TabIndex = 13;
            this.lbl_Siparis_Adet.Text = "lbl_Siparis_Adet";
            this.lbl_Siparis_Adet.Visible = false;
            // 
            // lbl_Eski_Stok
            // 
            this.lbl_Eski_Stok.AutoSize = true;
            this.lbl_Eski_Stok.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Eski_Stok.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Eski_Stok.Location = new System.Drawing.Point(96, 420);
            this.lbl_Eski_Stok.Name = "lbl_Eski_Stok";
            this.lbl_Eski_Stok.Size = new System.Drawing.Size(73, 14);
            this.lbl_Eski_Stok.TabIndex = 14;
            this.lbl_Eski_Stok.Text = "lbl_Eski_Stok";
            this.lbl_Eski_Stok.Visible = false;
            // 
            // lbl_Urun_Fiyat
            // 
            this.lbl_Urun_Fiyat.AutoSize = true;
            this.lbl_Urun_Fiyat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Urun_Fiyat.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Urun_Fiyat.Location = new System.Drawing.Point(175, 420);
            this.lbl_Urun_Fiyat.Name = "lbl_Urun_Fiyat";
            this.lbl_Urun_Fiyat.Size = new System.Drawing.Size(74, 14);
            this.lbl_Urun_Fiyat.TabIndex = 15;
            this.lbl_Urun_Fiyat.Text = "lbl_UrunFiyat";
            this.lbl_Urun_Fiyat.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(519, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Alınacak Ücret:";
            // 
            // lbl_Alinacak_Ucret
            // 
            this.lbl_Alinacak_Ucret.AutoSize = true;
            this.lbl_Alinacak_Ucret.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Alinacak_Ucret.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Alinacak_Ucret.Location = new System.Drawing.Point(598, 266);
            this.lbl_Alinacak_Ucret.Name = "lbl_Alinacak_Ucret";
            this.lbl_Alinacak_Ucret.Size = new System.Drawing.Size(48, 14);
            this.lbl_Alinacak_Ucret.TabIndex = 17;
            this.lbl_Alinacak_Ucret.Text = "00.00 TL";
            // 
            // frmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 443);
            this.Controls.Add(this.lbl_Alinacak_Ucret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Urun_Fiyat);
            this.Controls.Add(this.lbl_Eski_Stok);
            this.Controls.Add(this.lbl_Siparis_Adet);
            this.Controls.Add(this.lbl_MusteriID);
            this.Controls.Add(this.txt_SecilenSiparis);
            this.Controls.Add(this.btn_Siparis_Onay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSiparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.frmSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Siparis_Onay;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_SecilenSiparis;
        private System.Windows.Forms.Label lbl_MusteriID;
        private System.Windows.Forms.Label lbl_Siparis_Adet;
        private System.Windows.Forms.Label lbl_Eski_Stok;
        private System.Windows.Forms.Label lbl_Urun_Fiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Alinacak_Ucret;
    }
}