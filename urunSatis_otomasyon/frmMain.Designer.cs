
namespace urunSatis_otomasyon
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btn_Yetkili = new System.Windows.Forms.Button();
            this.btn_Musteri = new System.Windows.Forms.Button();
            this.lbl_Yetkili = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Yetkili
            // 
            this.btn_Yetkili.BackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Yetkili.BackgroundImage")));
            this.btn_Yetkili.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Yetkili.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yetkili.FlatAppearance.BorderSize = 0;
            this.btn_Yetkili.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Yetkili.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yetkili.Location = new System.Drawing.Point(320, 161);
            this.btn_Yetkili.Name = "btn_Yetkili";
            this.btn_Yetkili.Size = new System.Drawing.Size(123, 92);
            this.btn_Yetkili.TabIndex = 0;
            this.btn_Yetkili.UseVisualStyleBackColor = false;
            this.btn_Yetkili.Click += new System.EventHandler(this.btn_Yetkili_Click);
            // 
            // btn_Musteri
            // 
            this.btn_Musteri.BackColor = System.Drawing.Color.Transparent;
            this.btn_Musteri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Musteri.BackgroundImage")));
            this.btn_Musteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Musteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Musteri.FlatAppearance.BorderSize = 0;
            this.btn_Musteri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Musteri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Musteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Musteri.Location = new System.Drawing.Point(542, 161);
            this.btn_Musteri.Name = "btn_Musteri";
            this.btn_Musteri.Size = new System.Drawing.Size(123, 92);
            this.btn_Musteri.TabIndex = 1;
            this.btn_Musteri.UseVisualStyleBackColor = false;
            this.btn_Musteri.Click += new System.EventHandler(this.btn_Musteri_Click);
            // 
            // lbl_Yetkili
            // 
            this.lbl_Yetkili.AutoSize = true;
            this.lbl_Yetkili.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Yetkili.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Yetkili.Location = new System.Drawing.Point(315, 266);
            this.lbl_Yetkili.Name = "lbl_Yetkili";
            this.lbl_Yetkili.Size = new System.Drawing.Size(122, 42);
            this.lbl_Yetkili.TabIndex = 2;
            this.lbl_Yetkili.Text = "YETKİLİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "MÜŞTERİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pcr_Exit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 50);
            this.panel1.TabIndex = 11;
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.Image")));
            this.pcr_Exit.Location = new System.Drawing.Point(900, 9);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(31, 31);
            this.pcr_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Exit.TabIndex = 8;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "SEEN MARKET GİRİŞ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Yetkili);
            this.Controls.Add(this.btn_Musteri);
            this.Controls.Add(this.btn_Yetkili);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Girişler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Yetkili;
        private System.Windows.Forms.Button btn_Musteri;
        private System.Windows.Forms.Label lbl_Yetkili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcr_Exit;
        private System.Windows.Forms.Label label3;
    }
}