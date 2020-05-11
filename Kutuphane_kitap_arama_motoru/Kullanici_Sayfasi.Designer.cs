namespace Kutuphane_kitap_arama_motoru
{
    partial class Kullanici_Sayfasi
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
            this.MenuStrip_Secenekler = new System.Windows.Forms.MenuStrip();
            this.eserlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantamdakilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okunacakListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eserAramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkaPlanRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgilerimiGuncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Sql_Verileri = new System.Windows.Forms.DataGridView();
            this.chec_list_box = new System.Windows.Forms.CheckedListBox();
            this.btn_Geri_Cik = new System.Windows.Forms.Button();
            this.btnm_Ana_Sayfa = new System.Windows.Forms.Button();
            this.btn_Favorilere_Kaydet = new System.Windows.Forms.Button();
            this.btn_Okunacaklara_Kaydet = new System.Windows.Forms.Button();
            this.grp_Box_Guncelleme = new System.Windows.Forms.GroupBox();
            this.btn_grp_box_Guncelle = new System.Windows.Forms.Button();
            this.lbl_Sifre_Tekrar = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_Mailadresi = new System.Windows.Forms.Label();
            this.txt_Sifre_Tekrar = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_Telefonnumarasi = new System.Windows.Forms.TextBox();
            this.txt_Mailadresi = new System.Windows.Forms.TextBox();
            this.txt_Kitap_Adi_Arama = new System.Windows.Forms.TextBox();
            this.lbl_Kitap_Adi = new System.Windows.Forms.Label();
            this.lbl_Yazar_Ismi = new System.Windows.Forms.Label();
            this.txt_Yazar_Ismi = new System.Windows.Forms.TextBox();
            this.grp_Yazar_Arama = new System.Windows.Forms.GroupBox();
            this.btn_Yazarin_eserleri = new System.Windows.Forms.Button();
            this.lbl_Yazarin_kitap_Sayisi = new System.Windows.Forms.Label();
            this.lbl_Yazar_Kitap_Sayisi_Aciklama = new System.Windows.Forms.Label();
            this.btn_yazar_Ara = new System.Windows.Forms.Button();
            this.rch_tcb_Yazar_bilgileri = new System.Windows.Forms.RichTextBox();
            this.MenuStrip_Secenekler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sql_Verileri)).BeginInit();
            this.grp_Box_Guncelleme.SuspendLayout();
            this.grp_Yazar_Arama.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_Secenekler
            // 
            this.MenuStrip_Secenekler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eserlerToolStripMenuItem,
            this.kategorilerToolStripMenuItem,
            this.yazarlarToolStripMenuItem,
            this.cantamdakilerToolStripMenuItem,
            this.eserAramaToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.MenuStrip_Secenekler.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Secenekler.Name = "MenuStrip_Secenekler";
            this.MenuStrip_Secenekler.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip_Secenekler.TabIndex = 0;
            this.MenuStrip_Secenekler.UseWaitCursor = true;
            // 
            // eserlerToolStripMenuItem
            // 
            this.eserlerToolStripMenuItem.Name = "eserlerToolStripMenuItem";
            this.eserlerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.eserlerToolStripMenuItem.Text = "Eser turu";
            this.eserlerToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.eserlerToolStripMenuItem_DropDownItemClicked);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.kategorilerToolStripMenuItem_DropDownItemClicked);
            // 
            // yazarlarToolStripMenuItem
            // 
            this.yazarlarToolStripMenuItem.Name = "yazarlarToolStripMenuItem";
            this.yazarlarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.yazarlarToolStripMenuItem.Text = "Yazarlar ";
            this.yazarlarToolStripMenuItem.Click += new System.EventHandler(this.yazarlarToolStripMenuItem_Click);
            // 
            // cantamdakilerToolStripMenuItem
            // 
            this.cantamdakilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okunacakListesiToolStripMenuItem,
            this.favoriKitaplarToolStripMenuItem});
            this.cantamdakilerToolStripMenuItem.Name = "cantamdakilerToolStripMenuItem";
            this.cantamdakilerToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.cantamdakilerToolStripMenuItem.Text = "Cantamdakiler";
            this.cantamdakilerToolStripMenuItem.Click += new System.EventHandler(this.cantamdakilerToolStripMenuItem_Click);
            // 
            // okunacakListesiToolStripMenuItem
            // 
            this.okunacakListesiToolStripMenuItem.Name = "okunacakListesiToolStripMenuItem";
            this.okunacakListesiToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.okunacakListesiToolStripMenuItem.Text = "Okunacak listesi ";
            this.okunacakListesiToolStripMenuItem.Click += new System.EventHandler(this.okunacakListesiToolStripMenuItem_Click);
            // 
            // favoriKitaplarToolStripMenuItem
            // 
            this.favoriKitaplarToolStripMenuItem.Name = "favoriKitaplarToolStripMenuItem";
            this.favoriKitaplarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.favoriKitaplarToolStripMenuItem.Text = "Favori Kitaplar ";
            this.favoriKitaplarToolStripMenuItem.Click += new System.EventHandler(this.favoriKitaplarToolStripMenuItem_Click);
            // 
            // eserAramaToolStripMenuItem
            // 
            this.eserAramaToolStripMenuItem.Name = "eserAramaToolStripMenuItem";
            this.eserAramaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.eserAramaToolStripMenuItem.Text = "Eser arama ";
            this.eserAramaToolStripMenuItem.Click += new System.EventHandler(this.eserAramaToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaziTipiToolStripMenuItem,
            this.arkaPlanRengiToolStripMenuItem,
            this.bilgilerimiGuncellemeToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar ";
            // 
            // yaziTipiToolStripMenuItem
            // 
            this.yaziTipiToolStripMenuItem.Name = "yaziTipiToolStripMenuItem";
            this.yaziTipiToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.yaziTipiToolStripMenuItem.Text = "Yazi Ozellikleri ";
            this.yaziTipiToolStripMenuItem.Click += new System.EventHandler(this.yaziTipiToolStripMenuItem_Click);
            // 
            // arkaPlanRengiToolStripMenuItem
            // 
            this.arkaPlanRengiToolStripMenuItem.Name = "arkaPlanRengiToolStripMenuItem";
            this.arkaPlanRengiToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.arkaPlanRengiToolStripMenuItem.Text = "Arka plan rengi ";
            this.arkaPlanRengiToolStripMenuItem.Click += new System.EventHandler(this.arkaPlanRengiToolStripMenuItem_Click);
            // 
            // bilgilerimiGuncellemeToolStripMenuItem
            // 
            this.bilgilerimiGuncellemeToolStripMenuItem.Name = "bilgilerimiGuncellemeToolStripMenuItem";
            this.bilgilerimiGuncellemeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.bilgilerimiGuncellemeToolStripMenuItem.Text = "Bilgilerimi guncelleme ";
            this.bilgilerimiGuncellemeToolStripMenuItem.Click += new System.EventHandler(this.bilgilerimiGuncellemeToolStripMenuItem_Click);
            // 
            // dgv_Sql_Verileri
            // 
            this.dgv_Sql_Verileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Sql_Verileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sql_Verileri.Location = new System.Drawing.Point(58, 141);
            this.dgv_Sql_Verileri.Name = "dgv_Sql_Verileri";
            this.dgv_Sql_Verileri.Size = new System.Drawing.Size(567, 259);
            this.dgv_Sql_Verileri.TabIndex = 1;
            this.dgv_Sql_Verileri.Visible = false;
            // 
            // chec_list_box
            // 
            this.chec_list_box.FormattingEnabled = true;
            this.chec_list_box.Location = new System.Drawing.Point(152, 154);
            this.chec_list_box.Name = "chec_list_box";
            this.chec_list_box.Size = new System.Drawing.Size(385, 229);
            this.chec_list_box.TabIndex = 2;
            this.chec_list_box.Visible = false;
            // 
            // btn_Geri_Cik
            // 
            this.btn_Geri_Cik.Location = new System.Drawing.Point(694, 363);
            this.btn_Geri_Cik.Name = "btn_Geri_Cik";
            this.btn_Geri_Cik.Size = new System.Drawing.Size(75, 23);
            this.btn_Geri_Cik.TabIndex = 3;
            this.btn_Geri_Cik.Text = "Cikis yap ";
            this.btn_Geri_Cik.UseVisualStyleBackColor = true;
            this.btn_Geri_Cik.Click += new System.EventHandler(this.btn_Geri_Cik_Click);
            // 
            // btnm_Ana_Sayfa
            // 
            this.btnm_Ana_Sayfa.Location = new System.Drawing.Point(694, 412);
            this.btnm_Ana_Sayfa.Name = "btnm_Ana_Sayfa";
            this.btnm_Ana_Sayfa.Size = new System.Drawing.Size(75, 23);
            this.btnm_Ana_Sayfa.TabIndex = 4;
            this.btnm_Ana_Sayfa.Text = "Ana sayfa ";
            this.btnm_Ana_Sayfa.UseVisualStyleBackColor = true;
            this.btnm_Ana_Sayfa.Click += new System.EventHandler(this.btnm_Ana_Sayfa_Click);
            // 
            // btn_Favorilere_Kaydet
            // 
            this.btn_Favorilere_Kaydet.Location = new System.Drawing.Point(529, 464);
            this.btn_Favorilere_Kaydet.Name = "btn_Favorilere_Kaydet";
            this.btn_Favorilere_Kaydet.Size = new System.Drawing.Size(103, 23);
            this.btn_Favorilere_Kaydet.TabIndex = 5;
            this.btn_Favorilere_Kaydet.Text = "Favorilere ekle";
            this.btn_Favorilere_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Favorilere_Kaydet.Visible = false;
            this.btn_Favorilere_Kaydet.Click += new System.EventHandler(this.btn_Favorilere_Kaydet_Click);
            // 
            // btn_Okunacaklara_Kaydet
            // 
            this.btn_Okunacaklara_Kaydet.Location = new System.Drawing.Point(655, 464);
            this.btn_Okunacaklara_Kaydet.Name = "btn_Okunacaklara_Kaydet";
            this.btn_Okunacaklara_Kaydet.Size = new System.Drawing.Size(114, 23);
            this.btn_Okunacaklara_Kaydet.TabIndex = 6;
            this.btn_Okunacaklara_Kaydet.Text = "Okunacaklara ekle ";
            this.btn_Okunacaklara_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Okunacaklara_Kaydet.Visible = false;
            this.btn_Okunacaklara_Kaydet.Click += new System.EventHandler(this.btn_Okunacaklara_Kaydet_Click);
            // 
            // grp_Box_Guncelleme
            // 
            this.grp_Box_Guncelleme.Controls.Add(this.btn_grp_box_Guncelle);
            this.grp_Box_Guncelleme.Controls.Add(this.lbl_Sifre_Tekrar);
            this.grp_Box_Guncelleme.Controls.Add(this.lbl_Sifre);
            this.grp_Box_Guncelleme.Controls.Add(this.lbl_Telefon);
            this.grp_Box_Guncelleme.Controls.Add(this.lbl_Mailadresi);
            this.grp_Box_Guncelleme.Controls.Add(this.txt_Sifre_Tekrar);
            this.grp_Box_Guncelleme.Controls.Add(this.txt_Sifre);
            this.grp_Box_Guncelleme.Controls.Add(this.txt_Telefonnumarasi);
            this.grp_Box_Guncelleme.Controls.Add(this.txt_Mailadresi);
            this.grp_Box_Guncelleme.Location = new System.Drawing.Point(78, 130);
            this.grp_Box_Guncelleme.Name = "grp_Box_Guncelleme";
            this.grp_Box_Guncelleme.Size = new System.Drawing.Size(532, 305);
            this.grp_Box_Guncelleme.TabIndex = 7;
            this.grp_Box_Guncelleme.TabStop = false;
            this.grp_Box_Guncelleme.Visible = false;
            // 
            // btn_grp_box_Guncelle
            // 
            this.btn_grp_box_Guncelle.Location = new System.Drawing.Point(272, 234);
            this.btn_grp_box_Guncelle.Name = "btn_grp_box_Guncelle";
            this.btn_grp_box_Guncelle.Size = new System.Drawing.Size(150, 23);
            this.btn_grp_box_Guncelle.TabIndex = 9;
            this.btn_grp_box_Guncelle.Text = "Bilgilerimi Guncelle";
            this.btn_grp_box_Guncelle.UseVisualStyleBackColor = true;
            this.btn_grp_box_Guncelle.Click += new System.EventHandler(this.btn_grp_box_Guncelle_Click);
            // 
            // lbl_Sifre_Tekrar
            // 
            this.lbl_Sifre_Tekrar.AutoSize = true;
            this.lbl_Sifre_Tekrar.Location = new System.Drawing.Point(157, 187);
            this.lbl_Sifre_Tekrar.Name = "lbl_Sifre_Tekrar";
            this.lbl_Sifre_Tekrar.Size = new System.Drawing.Size(65, 13);
            this.lbl_Sifre_Tekrar.TabIndex = 7;
            this.lbl_Sifre_Tekrar.Text = "Sifre Tekrar:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(191, 152);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(31, 13);
            this.lbl_Sifre.TabIndex = 6;
            this.lbl_Sifre.Text = "Sifre:";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(131, 113);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(91, 13);
            this.lbl_Telefon.TabIndex = 5;
            this.lbl_Telefon.Text = "Telefon numarasi:";
            // 
            // lbl_Mailadresi
            // 
            this.lbl_Mailadresi.AutoSize = true;
            this.lbl_Mailadresi.Location = new System.Drawing.Point(162, 67);
            this.lbl_Mailadresi.Name = "lbl_Mailadresi";
            this.lbl_Mailadresi.Size = new System.Drawing.Size(60, 13);
            this.lbl_Mailadresi.TabIndex = 4;
            this.lbl_Mailadresi.Text = "Mail adresi:";
            // 
            // txt_Sifre_Tekrar
            // 
            this.txt_Sifre_Tekrar.Location = new System.Drawing.Point(239, 183);
            this.txt_Sifre_Tekrar.Name = "txt_Sifre_Tekrar";
            this.txt_Sifre_Tekrar.Size = new System.Drawing.Size(100, 20);
            this.txt_Sifre_Tekrar.TabIndex = 3;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(239, 149);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_Sifre.TabIndex = 2;
            // 
            // txt_Telefonnumarasi
            // 
            this.txt_Telefonnumarasi.Location = new System.Drawing.Point(239, 109);
            this.txt_Telefonnumarasi.Name = "txt_Telefonnumarasi";
            this.txt_Telefonnumarasi.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefonnumarasi.TabIndex = 1;
            // 
            // txt_Mailadresi
            // 
            this.txt_Mailadresi.Location = new System.Drawing.Point(239, 64);
            this.txt_Mailadresi.Name = "txt_Mailadresi";
            this.txt_Mailadresi.Size = new System.Drawing.Size(100, 20);
            this.txt_Mailadresi.TabIndex = 0;
            // 
            // txt_Kitap_Adi_Arama
            // 
            this.txt_Kitap_Adi_Arama.Location = new System.Drawing.Point(152, 45);
            this.txt_Kitap_Adi_Arama.Name = "txt_Kitap_Adi_Arama";
            this.txt_Kitap_Adi_Arama.Size = new System.Drawing.Size(222, 20);
            this.txt_Kitap_Adi_Arama.TabIndex = 8;
            this.txt_Kitap_Adi_Arama.Visible = false;
            this.txt_Kitap_Adi_Arama.TextChanged += new System.EventHandler(this.txt_Kitap_Adi_Arama_TextChanged);
            // 
            // lbl_Kitap_Adi
            // 
            this.lbl_Kitap_Adi.AutoSize = true;
            this.lbl_Kitap_Adi.Location = new System.Drawing.Point(55, 48);
            this.lbl_Kitap_Adi.Name = "lbl_Kitap_Adi";
            this.lbl_Kitap_Adi.Size = new System.Drawing.Size(91, 13);
            this.lbl_Kitap_Adi.TabIndex = 9;
            this.lbl_Kitap_Adi.Text = "Kitap adini giriniz: ";
            this.lbl_Kitap_Adi.Visible = false;
            // 
            // lbl_Yazar_Ismi
            // 
            this.lbl_Yazar_Ismi.AutoSize = true;
            this.lbl_Yazar_Ismi.Location = new System.Drawing.Point(41, 31);
            this.lbl_Yazar_Ismi.Name = "lbl_Yazar_Ismi";
            this.lbl_Yazar_Ismi.Size = new System.Drawing.Size(60, 13);
            this.lbl_Yazar_Ismi.TabIndex = 10;
            this.lbl_Yazar_Ismi.Text = "Yazar ismi: ";
            // 
            // txt_Yazar_Ismi
            // 
            this.txt_Yazar_Ismi.Location = new System.Drawing.Point(107, 28);
            this.txt_Yazar_Ismi.Name = "txt_Yazar_Ismi";
            this.txt_Yazar_Ismi.Size = new System.Drawing.Size(100, 20);
            this.txt_Yazar_Ismi.TabIndex = 11;
            // 
            // grp_Yazar_Arama
            // 
            this.grp_Yazar_Arama.Controls.Add(this.btn_Yazarin_eserleri);
            this.grp_Yazar_Arama.Controls.Add(this.lbl_Yazarin_kitap_Sayisi);
            this.grp_Yazar_Arama.Controls.Add(this.lbl_Yazar_Kitap_Sayisi_Aciklama);
            this.grp_Yazar_Arama.Controls.Add(this.btn_yazar_Ara);
            this.grp_Yazar_Arama.Controls.Add(this.lbl_Yazar_Ismi);
            this.grp_Yazar_Arama.Controls.Add(this.txt_Yazar_Ismi);
            this.grp_Yazar_Arama.Controls.Add(this.rch_tcb_Yazar_bilgileri);
            this.grp_Yazar_Arama.Location = new System.Drawing.Point(73, 84);
            this.grp_Yazar_Arama.Name = "grp_Yazar_Arama";
            this.grp_Yazar_Arama.Size = new System.Drawing.Size(552, 351);
            this.grp_Yazar_Arama.TabIndex = 13;
            this.grp_Yazar_Arama.TabStop = false;
            this.grp_Yazar_Arama.Visible = false;
            // 
            // btn_Yazarin_eserleri
            // 
            this.btn_Yazarin_eserleri.Location = new System.Drawing.Point(108, 305);
            this.btn_Yazarin_eserleri.Name = "btn_Yazarin_eserleri";
            this.btn_Yazarin_eserleri.Size = new System.Drawing.Size(145, 32);
            this.btn_Yazarin_eserleri.TabIndex = 17;
            this.btn_Yazarin_eserleri.Text = "Yazarlarin eserlerini goster";
            this.btn_Yazarin_eserleri.UseVisualStyleBackColor = true;
            this.btn_Yazarin_eserleri.Visible = false;
            this.btn_Yazarin_eserleri.Click += new System.EventHandler(this.btn_Yazarin_eserleri_Click);
            // 
            // lbl_Yazarin_kitap_Sayisi
            // 
            this.lbl_Yazarin_kitap_Sayisi.AutoSize = true;
            this.lbl_Yazarin_kitap_Sayisi.Location = new System.Drawing.Point(240, 289);
            this.lbl_Yazarin_kitap_Sayisi.Name = "lbl_Yazarin_kitap_Sayisi";
            this.lbl_Yazarin_kitap_Sayisi.Size = new System.Drawing.Size(13, 13);
            this.lbl_Yazarin_kitap_Sayisi.TabIndex = 16;
            this.lbl_Yazarin_kitap_Sayisi.Text = "0";
            this.lbl_Yazarin_kitap_Sayisi.Visible = false;
            // 
            // lbl_Yazar_Kitap_Sayisi_Aciklama
            // 
            this.lbl_Yazar_Kitap_Sayisi_Aciklama.AutoSize = true;
            this.lbl_Yazar_Kitap_Sayisi_Aciklama.Location = new System.Drawing.Point(114, 286);
            this.lbl_Yazar_Kitap_Sayisi_Aciklama.Name = "lbl_Yazar_Kitap_Sayisi_Aciklama";
            this.lbl_Yazar_Kitap_Sayisi_Aciklama.Size = new System.Drawing.Size(111, 13);
            this.lbl_Yazar_Kitap_Sayisi_Aciklama.TabIndex = 15;
            this.lbl_Yazar_Kitap_Sayisi_Aciklama.Text = "Yazara ait kitap sayisi:";
            this.lbl_Yazar_Kitap_Sayisi_Aciklama.Visible = false;
            // 
            // btn_yazar_Ara
            // 
            this.btn_yazar_Ara.Location = new System.Drawing.Point(440, 302);
            this.btn_yazar_Ara.Name = "btn_yazar_Ara";
            this.btn_yazar_Ara.Size = new System.Drawing.Size(75, 23);
            this.btn_yazar_Ara.TabIndex = 13;
            this.btn_yazar_Ara.Text = "Ara";
            this.btn_yazar_Ara.UseVisualStyleBackColor = true;
            this.btn_yazar_Ara.Click += new System.EventHandler(this.btn_yazar_Ara_Click);
            // 
            // rch_tcb_Yazar_bilgileri
            // 
            this.rch_tcb_Yazar_bilgileri.Location = new System.Drawing.Point(44, 69);
            this.rch_tcb_Yazar_bilgileri.Name = "rch_tcb_Yazar_bilgileri";
            this.rch_tcb_Yazar_bilgileri.Size = new System.Drawing.Size(471, 198);
            this.rch_tcb_Yazar_bilgileri.TabIndex = 14;
            this.rch_tcb_Yazar_bilgileri.Text = "";
            this.rch_tcb_Yazar_bilgileri.Visible = false;
            // 
            // Kullanici_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.chec_list_box);
            this.Controls.Add(this.grp_Box_Guncelleme);
            this.Controls.Add(this.grp_Yazar_Arama);
            this.Controls.Add(this.dgv_Sql_Verileri);
            this.Controls.Add(this.lbl_Kitap_Adi);
            this.Controls.Add(this.txt_Kitap_Adi_Arama);
            this.Controls.Add(this.btn_Okunacaklara_Kaydet);
            this.Controls.Add(this.btn_Favorilere_Kaydet);
            this.Controls.Add(this.btnm_Ana_Sayfa);
            this.Controls.Add(this.btn_Geri_Cik);
            this.Controls.Add(this.MenuStrip_Secenekler);
            this.MainMenuStrip = this.MenuStrip_Secenekler;
            this.Name = "Kullanici_Sayfasi";
            this.Text = "Kullanici sayfasi ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kullanici_Sayfasi_FormClosing);
            this.Load += new System.EventHandler(this.Kullanici_Sayfasi_Load);
            this.MenuStrip_Secenekler.ResumeLayout(false);
            this.MenuStrip_Secenekler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sql_Verileri)).EndInit();
            this.grp_Box_Guncelleme.ResumeLayout(false);
            this.grp_Box_Guncelleme.PerformLayout();
            this.grp_Yazar_Arama.ResumeLayout(false);
            this.grp_Yazar_Arama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Secenekler;
        private System.Windows.Forms.ToolStripMenuItem eserlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantamdakilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okunacakListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eserAramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arkaPlanRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgilerimiGuncellemeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_Sql_Verileri;
        private System.Windows.Forms.CheckedListBox chec_list_box;
        private System.Windows.Forms.Button btn_Geri_Cik;
        private System.Windows.Forms.Button btnm_Ana_Sayfa;
        private System.Windows.Forms.Button btn_Favorilere_Kaydet;
        private System.Windows.Forms.Button btn_Okunacaklara_Kaydet;
        private System.Windows.Forms.GroupBox grp_Box_Guncelleme;
        private System.Windows.Forms.Label lbl_Sifre_Tekrar;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_Mailadresi;
        private System.Windows.Forms.TextBox txt_Sifre_Tekrar;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_Telefonnumarasi;
        private System.Windows.Forms.TextBox txt_Mailadresi;
        private System.Windows.Forms.Button btn_grp_box_Guncelle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txt_Kitap_Adi_Arama;
        private System.Windows.Forms.Label lbl_Kitap_Adi;
        private System.Windows.Forms.Label lbl_Yazar_Ismi;
        private System.Windows.Forms.TextBox txt_Yazar_Ismi;
        private System.Windows.Forms.GroupBox grp_Yazar_Arama;
        private System.Windows.Forms.Button btn_yazar_Ara;
        private System.Windows.Forms.RichTextBox rch_tcb_Yazar_bilgileri;
        private System.Windows.Forms.Button btn_Yazarin_eserleri;
        private System.Windows.Forms.Label lbl_Yazarin_kitap_Sayisi;
        private System.Windows.Forms.Label lbl_Yazar_Kitap_Sayisi_Aciklama;
    }
}