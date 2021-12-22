
namespace urunSatis_otomasyon
{
    partial class frmYetkililer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYetkililer));
            this.dgw_Yetkili = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Yetki = new System.Windows.Forms.ComboBox();
            this.btn_Yetkili_Ekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ekle_Parola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ekle_Adı = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_Yetkili_Kaldir = new System.Windows.Forms.Button();
            this.cmb_GuncelleYetki = new System.Windows.Forms.ComboBox();
            this.btn_Yetkili_Guncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_GuncelParola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GuncelAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Yetkili)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_Yetkili
            // 
            this.dgw_Yetkili.AllowUserToAddRows = false;
            this.dgw_Yetkili.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            this.dgw_Yetkili.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_Yetkili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Yetkili.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgw_Yetkili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Yetkili.GridColor = System.Drawing.Color.DarkSalmon;
            this.dgw_Yetkili.Location = new System.Drawing.Point(8, 4);
            this.dgw_Yetkili.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgw_Yetkili.Name = "dgw_Yetkili";
            this.dgw_Yetkili.ReadOnly = true;
            this.dgw_Yetkili.RowHeadersWidth = 51;
            this.dgw_Yetkili.Size = new System.Drawing.Size(1232, 295);
            this.dgw_Yetkili.TabIndex = 12;
            this.dgw_Yetkili.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Yetkili_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmb_Yetki);
            this.groupBox1.Controls.Add(this.btn_Yetkili_Ekle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Ekle_Parola);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Ekle_Adı);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(47, 306);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(351, 234);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetkili Ekleme";
            // 
            // cmb_Yetki
            // 
            this.cmb_Yetki.FormattingEnabled = true;
            this.cmb_Yetki.Items.AddRange(new object[] {
            "Genel Müdür",
            "Müdür",
            "Personel"});
            this.cmb_Yetki.Location = new System.Drawing.Point(133, 96);
            this.cmb_Yetki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Yetki.Name = "cmb_Yetki";
            this.cmb_Yetki.Size = new System.Drawing.Size(173, 26);
            this.cmb_Yetki.TabIndex = 9;
            // 
            // btn_Yetkili_Ekle
            // 
            this.btn_Yetkili_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yetkili_Ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili_Ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yetkili_Ekle.Location = new System.Drawing.Point(201, 129);
            this.btn_Yetkili_Ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Yetkili_Ekle.Name = "btn_Yetkili_Ekle";
            this.btn_Yetkili_Ekle.Size = new System.Drawing.Size(107, 46);
            this.btn_Yetkili_Ekle.TabIndex = 8;
            this.btn_Yetkili_Ekle.Text = "EKLE";
            this.btn_Yetkili_Ekle.UseVisualStyleBackColor = true;
            this.btn_Yetkili_Ekle.Click += new System.EventHandler(this.btn_Yetkili_Ekle_Click);
            this.btn_Yetkili_Ekle.MouseLeave += new System.EventHandler(this.btn_Yetkili_Ekle_MouseLeave);
            this.btn_Yetkili_Ekle.MouseHover += new System.EventHandler(this.btn_Yetkili_Ekle_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yetki:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yetkili Parola:";
            // 
            // txt_Ekle_Parola
            // 
            this.txt_Ekle_Parola.Location = new System.Drawing.Point(133, 64);
            this.txt_Ekle_Parola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Ekle_Parola.Name = "txt_Ekle_Parola";
            this.txt_Ekle_Parola.Size = new System.Drawing.Size(173, 26);
            this.txt_Ekle_Parola.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yetkili Adı:";
            // 
            // txt_Ekle_Adı
            // 
            this.txt_Ekle_Adı.Location = new System.Drawing.Point(133, 32);
            this.txt_Ekle_Adı.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Ekle_Adı.Name = "txt_Ekle_Adı";
            this.txt_Ekle_Adı.Size = new System.Drawing.Size(173, 26);
            this.txt_Ekle_Adı.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbl_id);
            this.groupBox2.Controls.Add(this.btn_Yetkili_Kaldir);
            this.groupBox2.Controls.Add(this.cmb_GuncelleYetki);
            this.groupBox2.Controls.Add(this.btn_Yetkili_Guncelle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_GuncelParola);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_GuncelAdi);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(459, 306);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(351, 234);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yetkili Güncelleme ve Sİlme";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_id.Location = new System.Drawing.Point(25, 202);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(37, 18);
            this.lbl_id.TabIndex = 10;
            this.lbl_id.Text = "lblID";
            this.lbl_id.Visible = false;
            // 
            // btn_Yetkili_Kaldir
            // 
            this.btn_Yetkili_Kaldir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yetkili_Kaldir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili_Kaldir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili_Kaldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yetkili_Kaldir.Location = new System.Drawing.Point(199, 130);
            this.btn_Yetkili_Kaldir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Yetkili_Kaldir.Name = "btn_Yetkili_Kaldir";
            this.btn_Yetkili_Kaldir.Size = new System.Drawing.Size(107, 46);
            this.btn_Yetkili_Kaldir.TabIndex = 8;
            this.btn_Yetkili_Kaldir.Text = "SİL";
            this.btn_Yetkili_Kaldir.UseVisualStyleBackColor = true;
            this.btn_Yetkili_Kaldir.Click += new System.EventHandler(this.btn_Yetkili_Kaldir_Click);
            this.btn_Yetkili_Kaldir.MouseLeave += new System.EventHandler(this.btn_Yetkili_Kaldir_MouseLeave);
            this.btn_Yetkili_Kaldir.MouseHover += new System.EventHandler(this.btn_Yetkili_Kaldir_MouseHover);
            // 
            // cmb_GuncelleYetki
            // 
            this.cmb_GuncelleYetki.FormattingEnabled = true;
            this.cmb_GuncelleYetki.Items.AddRange(new object[] {
            "Genel Müdür",
            "Müdür",
            "Personel"});
            this.cmb_GuncelleYetki.Location = new System.Drawing.Point(133, 96);
            this.cmb_GuncelleYetki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_GuncelleYetki.Name = "cmb_GuncelleYetki";
            this.cmb_GuncelleYetki.Size = new System.Drawing.Size(173, 26);
            this.cmb_GuncelleYetki.TabIndex = 9;
            // 
            // btn_Yetkili_Guncelle
            // 
            this.btn_Yetkili_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yetkili_Guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili_Guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yetkili_Guncelle.Location = new System.Drawing.Point(77, 130);
            this.btn_Yetkili_Guncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Yetkili_Guncelle.Name = "btn_Yetkili_Guncelle";
            this.btn_Yetkili_Guncelle.Size = new System.Drawing.Size(107, 46);
            this.btn_Yetkili_Guncelle.TabIndex = 8;
            this.btn_Yetkili_Guncelle.Text = "GÜNCELLE";
            this.btn_Yetkili_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Yetkili_Guncelle.Click += new System.EventHandler(this.btn_Yetkili_Guncelle_Click);
            this.btn_Yetkili_Guncelle.MouseLeave += new System.EventHandler(this.btn_Yetkili_Guncelle_MouseLeave);
            this.btn_Yetkili_Guncelle.MouseHover += new System.EventHandler(this.btn_Yetkili_Guncelle_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yetki:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yetkili Parola:";
            // 
            // txt_GuncelParola
            // 
            this.txt_GuncelParola.Location = new System.Drawing.Point(133, 64);
            this.txt_GuncelParola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_GuncelParola.Name = "txt_GuncelParola";
            this.txt_GuncelParola.Size = new System.Drawing.Size(173, 26);
            this.txt_GuncelParola.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yetkili Adı:";
            // 
            // txt_GuncelAdi
            // 
            this.txt_GuncelAdi.Location = new System.Drawing.Point(133, 32);
            this.txt_GuncelAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_GuncelAdi.Name = "txt_GuncelAdi";
            this.txt_GuncelAdi.Size = new System.Drawing.Size(173, 26);
            this.txt_GuncelAdi.TabIndex = 1;
            // 
            // frmYetkililer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgw_Yetkili);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmYetkililer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili";
            this.Load += new System.EventHandler(this.frmYetkililer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Yetkili)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgw_Yetkili;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Yetkili_Ekle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ekle_Parola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ekle_Adı;
        private System.Windows.Forms.ComboBox cmb_Yetki;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_GuncelleYetki;
        private System.Windows.Forms.Button btn_Yetkili_Guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_GuncelParola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_GuncelAdi;
        private System.Windows.Forms.Button btn_Yetkili_Kaldir;
        private System.Windows.Forms.Label lbl_id;
    }
}