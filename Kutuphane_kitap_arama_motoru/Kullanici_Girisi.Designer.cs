namespace Kutuphane_kitap_arama_motoru
{
    partial class Kullanici_Girisi
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
            this.lbl_Kulaanici_idsi = new System.Windows.Forms.Label();
            this.lbl_sifre_giriniz = new System.Windows.Forms.Label();
            this.txt_Kullanici_Idsi = new System.Windows.Forms.TextBox();
            this.txt_Kullanici_Sifresi = new System.Windows.Forms.TextBox();
            this.btn_Giris_yap = new System.Windows.Forms.Button();
            this.btn_Geri_cik = new System.Windows.Forms.Button();
            this.chb_Sifre = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_Kulaanici_idsi
            // 
            this.lbl_Kulaanici_idsi.AutoSize = true;
            this.lbl_Kulaanici_idsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kulaanici_idsi.Location = new System.Drawing.Point(180, 131);
            this.lbl_Kulaanici_idsi.Name = "lbl_Kulaanici_idsi";
            this.lbl_Kulaanici_idsi.Size = new System.Drawing.Size(81, 16);
            this.lbl_Kulaanici_idsi.TabIndex = 0;
            this.lbl_Kulaanici_idsi.Text = "Kullanici Idsi";
            // 
            // lbl_sifre_giriniz
            // 
            this.lbl_sifre_giriniz.AutoSize = true;
            this.lbl_sifre_giriniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifre_giriniz.Location = new System.Drawing.Point(186, 202);
            this.lbl_sifre_giriniz.Name = "lbl_sifre_giriniz";
            this.lbl_sifre_giriniz.Size = new System.Drawing.Size(75, 16);
            this.lbl_sifre_giriniz.TabIndex = 1;
            this.lbl_sifre_giriniz.Text = "Sifre giriniz:";
            // 
            // txt_Kullanici_Idsi
            // 
            this.txt_Kullanici_Idsi.Location = new System.Drawing.Point(189, 166);
            this.txt_Kullanici_Idsi.Name = "txt_Kullanici_Idsi";
            this.txt_Kullanici_Idsi.Size = new System.Drawing.Size(169, 20);
            this.txt_Kullanici_Idsi.TabIndex = 3;
            // 
            // txt_Kullanici_Sifresi
            // 
            this.txt_Kullanici_Sifresi.Location = new System.Drawing.Point(189, 239);
            this.txt_Kullanici_Sifresi.Name = "txt_Kullanici_Sifresi";
            this.txt_Kullanici_Sifresi.PasswordChar = '#';
            this.txt_Kullanici_Sifresi.Size = new System.Drawing.Size(169, 20);
            this.txt_Kullanici_Sifresi.TabIndex = 4;
            // 
            // btn_Giris_yap
            // 
            this.btn_Giris_yap.Location = new System.Drawing.Point(384, 333);
            this.btn_Giris_yap.Name = "btn_Giris_yap";
            this.btn_Giris_yap.Size = new System.Drawing.Size(93, 23);
            this.btn_Giris_yap.TabIndex = 5;
            this.btn_Giris_yap.Text = "Giris yap ";
            this.btn_Giris_yap.UseVisualStyleBackColor = true;
            this.btn_Giris_yap.Click += new System.EventHandler(this.btn_Giris_yap_Click);
            // 
            // btn_Geri_cik
            // 
            this.btn_Geri_cik.Location = new System.Drawing.Point(1, 1);
            this.btn_Geri_cik.Name = "btn_Geri_cik";
            this.btn_Geri_cik.Size = new System.Drawing.Size(75, 23);
            this.btn_Geri_cik.TabIndex = 6;
            this.btn_Geri_cik.Text = "Geri cik";
            this.btn_Geri_cik.UseVisualStyleBackColor = true;
            this.btn_Geri_cik.Click += new System.EventHandler(this.btn_Geri_cik_Click);
            // 
            // chb_Sifre
            // 
            this.chb_Sifre.AutoSize = true;
            this.chb_Sifre.Location = new System.Drawing.Point(372, 242);
            this.chb_Sifre.Name = "chb_Sifre";
            this.chb_Sifre.Size = new System.Drawing.Size(15, 14);
            this.chb_Sifre.TabIndex = 7;
            this.chb_Sifre.UseVisualStyleBackColor = true;
            this.chb_Sifre.CheckedChanged += new System.EventHandler(this.chb_Sifre_CheckedChanged);
            // 
            // Kullanici_Girisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 543);
            this.Controls.Add(this.chb_Sifre);
            this.Controls.Add(this.btn_Geri_cik);
            this.Controls.Add(this.btn_Giris_yap);
            this.Controls.Add(this.txt_Kullanici_Sifresi);
            this.Controls.Add(this.txt_Kullanici_Idsi);
            this.Controls.Add(this.lbl_sifre_giriniz);
            this.Controls.Add(this.lbl_Kulaanici_idsi);
            this.Name = "Kullanici_Girisi";
            this.Text = "Kullanici girisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Kulaanici_idsi;
        private System.Windows.Forms.Label lbl_sifre_giriniz;
        private System.Windows.Forms.TextBox txt_Kullanici_Sifresi;
        private System.Windows.Forms.Button btn_Giris_yap;
        private System.Windows.Forms.Button btn_Geri_cik;
        private System.Windows.Forms.TextBox txt_Kullanici_Idsi;
        private System.Windows.Forms.CheckBox chb_Sifre;
    }
}