namespace Kutuphane_kitap_arama_motoru
{
    partial class Yonetici_Girisi
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
            this.btn_Giris_yap_Yon = new System.Windows.Forms.Button();
            this.txt_Kullanici_Sifresi_Yon = new System.Windows.Forms.TextBox();
            this.txt_Kullanici_Idsi_Yon = new System.Windows.Forms.TextBox();
            this.lbl_sifre_giriniz_Ynt = new System.Windows.Forms.Label();
            this.lbl_Yonetici_Idsi = new System.Windows.Forms.Label();
            this.btn_Geri_cik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Giris_yap_Yon
            // 
            this.btn_Giris_yap_Yon.Location = new System.Drawing.Point(319, 368);
            this.btn_Giris_yap_Yon.Name = "btn_Giris_yap_Yon";
            this.btn_Giris_yap_Yon.Size = new System.Drawing.Size(93, 23);
            this.btn_Giris_yap_Yon.TabIndex = 10;
            this.btn_Giris_yap_Yon.Text = "Giris yap ";
            this.btn_Giris_yap_Yon.UseVisualStyleBackColor = true;
            this.btn_Giris_yap_Yon.Click += new System.EventHandler(this.btn_Giris_yap_Click);
            // 
            // txt_Kullanici_Sifresi_Yon
            // 
            this.txt_Kullanici_Sifresi_Yon.Location = new System.Drawing.Point(160, 264);
            this.txt_Kullanici_Sifresi_Yon.Name = "txt_Kullanici_Sifresi_Yon";
            this.txt_Kullanici_Sifresi_Yon.Size = new System.Drawing.Size(169, 20);
            this.txt_Kullanici_Sifresi_Yon.TabIndex = 9;
            // 
            // txt_Kullanici_Idsi_Yon
            // 
            this.txt_Kullanici_Idsi_Yon.Location = new System.Drawing.Point(160, 191);
            this.txt_Kullanici_Idsi_Yon.Name = "txt_Kullanici_Idsi_Yon";
            this.txt_Kullanici_Idsi_Yon.Size = new System.Drawing.Size(169, 20);
            this.txt_Kullanici_Idsi_Yon.TabIndex = 8;
            // 
            // lbl_sifre_giriniz_Ynt
            // 
            this.lbl_sifre_giriniz_Ynt.AutoSize = true;
            this.lbl_sifre_giriniz_Ynt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifre_giriniz_Ynt.Location = new System.Drawing.Point(151, 224);
            this.lbl_sifre_giriniz_Ynt.Name = "lbl_sifre_giriniz_Ynt";
            this.lbl_sifre_giriniz_Ynt.Size = new System.Drawing.Size(75, 16);
            this.lbl_sifre_giriniz_Ynt.TabIndex = 7;
            this.lbl_sifre_giriniz_Ynt.Text = "Sifre giriniz:";
            // 
            // lbl_Yonetici_Idsi
            // 
            this.lbl_Yonetici_Idsi.AutoSize = true;
            this.lbl_Yonetici_Idsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Yonetici_Idsi.Location = new System.Drawing.Point(151, 152);
            this.lbl_Yonetici_Idsi.Name = "lbl_Yonetici_Idsi";
            this.lbl_Yonetici_Idsi.Size = new System.Drawing.Size(80, 16);
            this.lbl_Yonetici_Idsi.TabIndex = 6;
            this.lbl_Yonetici_Idsi.Text = "Yonetici Idsi";
            // 
            // btn_Geri_cik
            // 
            this.btn_Geri_cik.Location = new System.Drawing.Point(1, 1);
            this.btn_Geri_cik.Name = "btn_Geri_cik";
            this.btn_Geri_cik.Size = new System.Drawing.Size(75, 23);
            this.btn_Geri_cik.TabIndex = 11;
            this.btn_Geri_cik.Text = "Geri cik";
            this.btn_Geri_cik.UseVisualStyleBackColor = true;
            this.btn_Geri_cik.Click += new System.EventHandler(this.btn_Geri_cik_Click);
            // 
            // Yonetici_Girisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 543);
            this.Controls.Add(this.btn_Geri_cik);
            this.Controls.Add(this.btn_Giris_yap_Yon);
            this.Controls.Add(this.txt_Kullanici_Sifresi_Yon);
            this.Controls.Add(this.txt_Kullanici_Idsi_Yon);
            this.Controls.Add(this.lbl_sifre_giriniz_Ynt);
            this.Controls.Add(this.lbl_Yonetici_Idsi);
            this.Name = "Yonetici_Girisi";
            this.Text = "Yonetici Girisi ";
            this.Load += new System.EventHandler(this.Yonetici_Girisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Giris_yap_Yon;
        private System.Windows.Forms.TextBox txt_Kullanici_Sifresi_Yon;
        private System.Windows.Forms.TextBox txt_Kullanici_Idsi_Yon;
        private System.Windows.Forms.Label lbl_sifre_giriniz_Ynt;
        private System.Windows.Forms.Label lbl_Yonetici_Idsi;
        private System.Windows.Forms.Button btn_Geri_cik;
    }
}