
namespace urunSatis_otomasyon
{
    partial class frmMusteriKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriKayıt));
            this.txt_Kadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAdSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_KayıtOl = new System.Windows.Forms.Button();
            this.Msktxt_Tc = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Kadi
            // 
            this.txt_Kadi.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Kadi.Location = new System.Drawing.Point(532, 158);
            this.txt_Kadi.Name = "txt_Kadi";
            this.txt_Kadi.Size = new System.Drawing.Size(110, 23);
            this.txt_Kadi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pcr_Back);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pcr_Exit);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 50);
            this.panel1.TabIndex = 27;
            // 
            // pcr_Back
            // 
            this.pcr_Back.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Back.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Back.Image")));
            this.pcr_Back.Location = new System.Drawing.Point(12, 9);
            this.pcr_Back.Name = "pcr_Back";
            this.pcr_Back.Size = new System.Drawing.Size(31, 31);
            this.pcr_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Back.TabIndex = 11;
            this.pcr_Back.TabStop = false;
            this.pcr_Back.Click += new System.EventHandler(this.pcr_Back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "SEEN MARKETE HOŞ GELDİNİZ";
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.Image")));
            this.pcr_Exit.Location = new System.Drawing.Point(893, 9);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(31, 31);
            this.pcr_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Exit.TabIndex = 8;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sifre.Location = new System.Drawing.Point(532, 187);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(110, 23);
            this.txt_Sifre.TabIndex = 3;
            this.txt_Sifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Şifre:";
            // 
            // textAdres
            // 
            this.textAdres.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdres.Location = new System.Drawing.Point(532, 216);
            this.textAdres.Multiline = true;
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(190, 96);
            this.textAdres.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "T.C.:";
            // 
            // textAdSoyad
            // 
            this.textAdSoyad.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdSoyad.Location = new System.Drawing.Point(532, 129);
            this.textAdSoyad.Name = "textAdSoyad";
            this.textAdSoyad.Size = new System.Drawing.Size(110, 23);
            this.textAdSoyad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Adı  Soyadı:";
            // 
            // btn_KayıtOl
            // 
            this.btn_KayıtOl.BackColor = System.Drawing.Color.Transparent;
            this.btn_KayıtOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KayıtOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_KayıtOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_KayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KayıtOl.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KayıtOl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_KayıtOl.Location = new System.Drawing.Point(532, 318);
            this.btn_KayıtOl.Name = "btn_KayıtOl";
            this.btn_KayıtOl.Size = new System.Drawing.Size(105, 37);
            this.btn_KayıtOl.TabIndex = 5;
            this.btn_KayıtOl.Text = "KAYIT OL";
            this.btn_KayıtOl.UseVisualStyleBackColor = false;
            this.btn_KayıtOl.Click += new System.EventHandler(this.btn_KayıtOl_Click);
            this.btn_KayıtOl.MouseLeave += new System.EventHandler(this.btn_KayıtOl_MouseLeave);
            this.btn_KayıtOl.MouseHover += new System.EventHandler(this.btn_KayıtOl_MouseHover);
            // 
            // Msktxt_Tc
            // 
            this.Msktxt_Tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Msktxt_Tc.Location = new System.Drawing.Point(532, 102);
            this.Msktxt_Tc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Msktxt_Tc.Mask = "00000000000";
            this.Msktxt_Tc.Name = "Msktxt_Tc";
            this.Msktxt_Tc.Size = new System.Drawing.Size(110, 22);
            this.Msktxt_Tc.TabIndex = 0;
            // 
            // frmMusteriKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(936, 443);
            this.Controls.Add(this.Msktxt_Tc);
            this.Controls.Add(this.btn_KayıtOl);
            this.Controls.Add(this.textAdSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Kadi);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMusteriKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Kayıt";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Kadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcr_Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcr_Exit;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAdSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_KayıtOl;
        private System.Windows.Forms.MaskedTextBox Msktxt_Tc;
    }
}