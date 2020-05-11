namespace Kutuphane_kitap_arama_motoru
{
    partial class Ana_Sayfa
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
            this.lbl_Anasyf_Baslik = new System.Windows.Forms.Label();
            this.btn_Kullanici_Girisi = new System.Windows.Forms.Button();
            this.btn_Yonetici_girisi = new System.Windows.Forms.Button();
            this.btn_Uye_ol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Anasyf_Baslik
            // 
            this.lbl_Anasyf_Baslik.AutoSize = true;
            this.lbl_Anasyf_Baslik.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Anasyf_Baslik.Location = new System.Drawing.Point(158, 76);
            this.lbl_Anasyf_Baslik.Name = "lbl_Anasyf_Baslik";
            this.lbl_Anasyf_Baslik.Size = new System.Drawing.Size(224, 24);
            this.lbl_Anasyf_Baslik.TabIndex = 0;
            this.lbl_Anasyf_Baslik.Text = "Salihli halk kutuphanesi ";
            this.lbl_Anasyf_Baslik.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Kullanici_Girisi
            // 
            this.btn_Kullanici_Girisi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Kullanici_Girisi.Location = new System.Drawing.Point(188, 146);
            this.btn_Kullanici_Girisi.Name = "btn_Kullanici_Girisi";
            this.btn_Kullanici_Girisi.Size = new System.Drawing.Size(161, 40);
            this.btn_Kullanici_Girisi.TabIndex = 1;
            this.btn_Kullanici_Girisi.Text = "Kullanici girisi";
            this.btn_Kullanici_Girisi.UseVisualStyleBackColor = true;
            this.btn_Kullanici_Girisi.Click += new System.EventHandler(this.btn_Kullanici_Girisi_Click);
            // 
            // btn_Yonetici_girisi
            // 
            this.btn_Yonetici_girisi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yonetici_girisi.Location = new System.Drawing.Point(188, 218);
            this.btn_Yonetici_girisi.Name = "btn_Yonetici_girisi";
            this.btn_Yonetici_girisi.Size = new System.Drawing.Size(161, 40);
            this.btn_Yonetici_girisi.TabIndex = 2;
            this.btn_Yonetici_girisi.Text = "Yonetici girisi ";
            this.btn_Yonetici_girisi.UseVisualStyleBackColor = true;
            this.btn_Yonetici_girisi.Click += new System.EventHandler(this.btn_Yonetici_girisi_Click);
            // 
            // btn_Uye_ol
            // 
            this.btn_Uye_ol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Uye_ol.Location = new System.Drawing.Point(188, 299);
            this.btn_Uye_ol.Name = "btn_Uye_ol";
            this.btn_Uye_ol.Size = new System.Drawing.Size(161, 40);
            this.btn_Uye_ol.TabIndex = 3;
            this.btn_Uye_ol.Text = "Uye ol ";
            this.btn_Uye_ol.UseVisualStyleBackColor = true;
            this.btn_Uye_ol.Click += new System.EventHandler(this.btn_Uye_ol_Click);
            // 
            // Ana_Sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 543);
            this.Controls.Add(this.btn_Uye_ol);
            this.Controls.Add(this.btn_Yonetici_girisi);
            this.Controls.Add(this.btn_Kullanici_Girisi);
            this.Controls.Add(this.lbl_Anasyf_Baslik);
            this.Name = "Ana_Sayfa";
            this.Text = "Ana Sayfa ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Anasyf_Baslik;
        private System.Windows.Forms.Button btn_Kullanici_Girisi;
        private System.Windows.Forms.Button btn_Yonetici_girisi;
        private System.Windows.Forms.Button btn_Uye_ol;
    }
}

