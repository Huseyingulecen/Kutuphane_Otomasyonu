using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Kutuphane_kitap_arama_motoru.Properties;
using System.Net;
using System.Net.Mail;

using System.Text;
using System.Windows.Controls;
using HtmlAgilityPack;
using System.Linq;
using System.Drawing;

namespace Kutuphane_kitap_arama_motoru
{
    public partial class Kullanici_Sayfasi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E76DIU4\\SQLEXPRESS;Initial Catalog=Kutuphane_bilgileri;Integrated Security=True;MultipleActiveResultSets=True");

        SqlCommand komut;
        SqlDataReader oku;
        SqlDataReader oku2;

        DataTable dataTab = new DataTable();
        DataTable dt = new DataTable();
        public string html = "";
        public Uri url;

        SqlDataAdapter dataAd;
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        //DataTable table2 = new DataTable();
        Kullanici_Girisi Kullanici_Girisi_Formu;
        string Mail_Adresi, Telefon_Numarasi, Sifre;

        int _userId;
        List<int> Kitap_idler = new List<int>();

        public Kullanici_Sayfasi(int id)
        {
            InitializeComponent();
            // Kullanici_Girisi Kullanici_Girisi_Formu = new Kullanici_Girisi();
            this._userId = id;

        }
        public static string Bas_harfi_buyut(string str)
        {
            string buyukstring;
            string bas_harf;
            string stringin_devami;
            bas_harf = str.Substring(0, 1).ToUpper();
            stringin_devami = str.Remove(0, 1);
            buyukstring = bas_harf.Insert(1, stringin_devami);
            return buyukstring;
        }

        private void Kullanici_Sayfasi_Load(object sender, EventArgs e)
        {

            MenuStripOgeleriEserKategoriler();

            MenuStripOgeleriEserTuru();
            this.BackColor = Settings.Default.Formrengi;
            this.Font = Settings.Default.YaziOzellikleri;
            MenuStrip_Secenekler.Font = Settings.Default.YaziOzellikleri;

            int maxSubMenuItems = 6;

            if (kategorilerToolStripMenuItem.DropDownItems.Count > maxSubMenuItems)
            {
                int maxHeight = kategorilerToolStripMenuItem.DropDownItems
                    .OfType<ToolStripMenuItem>()
                    .Take(maxSubMenuItems)
                    .Sum(itm => itm.Height);

                kategorilerToolStripMenuItem.DropDown.MaximumSize =
                   new Size(kategorilerToolStripMenuItem.DropDown.Width, maxHeight + (maxHeight / maxSubMenuItems));
            }

            if (eserlerToolStripMenuItem.DropDownItems.Count > maxSubMenuItems)
            {
                int maxHeight = eserlerToolStripMenuItem.DropDownItems
                    .OfType<ToolStripMenuItem>()
                    .Take(maxSubMenuItems)
                    .Sum(itm => itm.Height);

                eserlerToolStripMenuItem.DropDown.MaximumSize =
                   new Size(eserlerToolStripMenuItem.DropDown.Width, maxHeight + (maxHeight / maxSubMenuItems));
            }




            /*
             eserlerToolStripMenuItem
             */
            // kategorilerToolStripMenuItem
        }

        void Kitap_Turu(string kitap_turu)
        {
            chec_list_box.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select Eserin_Adi from Kitap_Bilgileri where Eserin_Turu = '" + kitap_turu + "'", baglanti);

            oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                chec_list_box.Items.Add(oku[0]);

            }
            baglanti.Close();
            oku.Close();
        }
        void Kitap_Kategori(string kitap_Kategorisi)
        {
            chec_list_box.Items.Clear();            //baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select Eserin_Adi from Kitap_Bilgileri where Eserin_kategorisi = '" + kitap_Kategorisi + "'", baglanti);

            oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                chec_list_box.Items.Add(oku[0]);
            }
            baglanti.Close();
            oku.Close();
        }
        void MenuStripOgeleriEserTuru()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT DISTINCT Eserin_Turu FROM Kitap_Bilgileri", baglanti);

            dataAd = new SqlDataAdapter(komut);

            oku = komut.ExecuteReader();
            int sayi = 1;
            string id;
            while (oku.Read())
            {
                string a;
                id = "text" + "" + sayi.ToString();
                sayi++;
                var item = new System.Windows.Forms.ToolStripMenuItem()
                {
                    Name = id,
                    Text = Bas_harfi_buyut(oku[0].ToString()),
                    // Text = Bas_harfi_buyut(oku[0].ToString()),
                };
                eserlerToolStripMenuItem.DropDownItems.Add(Bas_harfi_buyut(oku[0].ToString()));

            }
            baglanti.Close();
            oku.Close();


        }
        void MenuStripOgeleriEserKategoriler()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select distinct Eserin_kategorisi from Kitap_Bilgileri", baglanti);

            dataAd = new SqlDataAdapter(komut);

            oku = komut.ExecuteReader();
            int sayi = 1;
            string id;
            while (oku.Read())
            {
                string a;
                id = "text" + "" + sayi.ToString();
                sayi++;
                var item = new System.Windows.Forms.ToolStripMenuItem()
                {
                    // Name = id,
                    // Text = Bas_harfi_buyut(oku[0].ToString()),
                    // Text = Bas_harfi_buyut(oku[0].ToString()),
                };
                kategorilerToolStripMenuItem.DropDownItems.Add(Bas_harfi_buyut(oku[0].ToString()));
            }
            baglanti.Close();
            oku.Close();
            

        }

        private void SubItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void İtem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
             
        }
      
        private void eserlerToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string text = e.ClickedItem.Text;
            Kitap_Turu(text);
            dgv_Sql_Verileri.Visible = false;
            chec_list_box.Visible = true;
            btn_Favorilere_Kaydet.Visible = true;
            btn_Okunacaklara_Kaydet.Visible = true;
            grp_Box_Guncelleme.Visible = false;
            txt_Kitap_Adi_Arama.Visible = false;
            lbl_Kitap_Adi.Visible = false;
            grp_Yazar_Arama.Visible = false;
            rch_tcb_Yazar_bilgileri.Visible = false;

        }

        private void btn_Geri_Cik_Click(object sender, EventArgs e)
        {
            Kullanici_Girisi Kullanici_Girisi_Formu = new Kullanici_Girisi();
            Kullanici_Girisi_Formu.BackColor = this.BackColor;
            Properties.Settings.Default.Kullanici_Idsi = 0;
            Settings.Default.Save();

            Kullanici_Girisi_Formu.Show();

            this.Hide();

        }

        private void btnm_Ana_Sayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa Ana_Sayfa_Formu = new Ana_Sayfa();
            Ana_Sayfa_Formu.Show();
            this.Hide();

        }
        
        private void btn_Favorilere_Kaydet_Click(object sender, EventArgs e)
        {
            foreach (string s in chec_list_box.CheckedItems)
            {
                baglanti.Open();

                string kmt;
                kmt = "select Kitap_Idsi from Kitap_Bilgileri where Eserin_Adi='" + s + "'";

                // Kullanici_Girisi_Formu = new Kullanici_Girisi();
                SqlCommand komut = new SqlCommand(kmt, baglanti);
                oku = komut.ExecuteReader();
                //oku.Close();

                int id = 0;

                while (oku.Read())
                {
                    id = (int)oku[0];
                }
                oku.Close();
                SqlCommand komut3 = new SqlCommand("select * from Cantamdaki_Favoriler where Kullanici_idsi=" + _userId + " and kitsp_Idsi=" + id + "",baglanti);
                if (Convert.ToInt32(komut3.ExecuteScalar()) == 0)
                {
                    SqlCommand komut2 = new SqlCommand("insert into Cantamdaki_Favoriler(Kullanici_idsi,kitsp_Idsi)values(" + _userId + "," + id + ")", baglanti);     // 2. sorguyu yap,mak icin ekledim 
                    komut2.ExecuteNonQuery();
                }

               

                baglanti.Close();
            }
        }

        private void btn_Okunacaklara_Kaydet_Click(object sender, EventArgs e)
        {
            foreach (string s in chec_list_box.CheckedItems)
            {
                baglanti.Open();

                string kmt;
                kmt = "select Kitap_Idsi from Kitap_Bilgileri where Eserin_Adi='" + s + "'";

                SqlCommand komut = new SqlCommand(kmt, baglanti);
                oku = komut.ExecuteReader();

                int id = 0;

                while (oku.Read())
                {
                    id = (int)oku[0];
                }
                oku.Close();
                SqlCommand komut3 = new SqlCommand("select * from Cantamdaki_Okunacaklar where Kullanici_Idsi="+ _userId + " and Kitap_Idsi="+id+"", baglanti);
                if (Convert.ToInt32(komut3.ExecuteScalar())==0)
                {
                    SqlCommand komut2 = new SqlCommand("insert into Cantamdaki_Okunacaklar(Kullanici_idsi,kitap_Idsi)values(" + _userId + "," + id + ")", baglanti);     // 2. sorguyu yap,mak icin ekledim 
                    komut2.ExecuteNonQuery();
                }
               
                //bool kontrol =
                

                baglanti.Close();
            }


        }

        private void okunacakListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            btn_Favorilere_Kaydet.Visible = false;
            btn_Okunacaklara_Kaydet.Visible = false;
            grp_Box_Guncelleme.Visible = false;
            txt_Kitap_Adi_Arama.Visible = false;
            lbl_Kitap_Adi.Visible = false;
            dgv_Sql_Verileri.Visible = true;
            grp_Yazar_Arama.Visible = false;
            rch_tcb_Yazar_bilgileri.Visible = false;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Kitap_Idsi from Cantamdaki_Okunacaklar where Kullanici_idsi= '" + _userId + "'", baglanti);
            oku = komut.ExecuteReader();
            int id = 0;
            while (oku.Read())
            {
                id = (int)oku[0];
                SqlCommand komut2 = new SqlCommand("select * from Kitap_Bilgileri where Kitap_Idsi='" + id + "'", baglanti);
                //komut2.ExecuteReader();
                SqlDataAdapter dataAdap = new SqlDataAdapter(komut2);
                dataAdap.Fill(table);
                dgv_Sql_Verileri.DataSource = table;
            }

            baglanti.Close();
            oku.Close();

            dgv_Sql_Verileri.Visible = true;
            chec_list_box.Visible = false;

        }

        private void favoriKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grp_Box_Guncelleme.Visible = false;
            btn_Favorilere_Kaydet.Visible = false;
            btn_Okunacaklara_Kaydet.Visible = false;
            txt_Kitap_Adi_Arama.Visible = false;
            lbl_Kitap_Adi.Visible = false;
            dgv_Sql_Verileri.Visible = true;
            grp_Yazar_Arama.Visible = false;
            rch_tcb_Yazar_bilgileri.Visible = false;


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Kitsp_Idsi from Cantamdaki_Favoriler where Kullanici_idsi= '" + _userId + "'", baglanti);
            oku = komut.ExecuteReader();

            int id = 0;
            while (oku.Read())
            {

                id = (int)oku[0];
                SqlCommand komut2 = new SqlCommand("select * from Kitap_Bilgileri where Kitap_Idsi='" + id + "'", baglanti);
                //komut2.ExecuteReader();
                SqlDataAdapter dataAdap = new SqlDataAdapter(komut2);


                dataAdap.Fill(table);
                dgv_Sql_Verileri.DataSource = table;
            }

            baglanti.Close();
            oku.Close();
            
            dgv_Sql_Verileri.Visible = true;
            chec_list_box.Visible = false;
        }

        private void temalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Favorilere_Kaydet.Visible = false;
            btn_Okunacaklara_Kaydet.Visible = false;
            grp_Box_Guncelleme.Visible = false;
            txt_Kitap_Adi_Arama.Visible = false;
            lbl_Kitap_Adi.Visible = false;
            grp_Yazar_Arama.Visible = false;
            rch_tcb_Yazar_bilgileri.Visible = false;
        }

        private void ıadeyeKalanSureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Favorilere_Kaydet.Visible = false;
            btn_Okunacaklara_Kaydet.Visible = false;
            grp_Box_Guncelleme.Visible = false;
            txt_Kitap_Adi_Arama.Visible = false;
            lbl_Kitap_Adi.Visible = false;
            grp_Yazar_Arama.Visible = false;
            rch_tcb_Yazar_bilgileri.Visible = false;


        }

        private void arkaPlanRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog RenkPenceresi = new ColorDialog();
            if (RenkPenceresi.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = RenkPenceresi.Color;
            }

            Settings.Default.Formrengi = RenkPenceresi.Color;
            Settings.Default.Save();

        }

        private void yaziTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FontPenceresi = new FontDialog();
            if (FontPenceresi.ShowDialog() == DialogResult.OK)
            {
                this.Font = FontPenceresi.Font;
                MenuStrip_Secenekler.Font = FontPenceresi.Font;
                Properties.Settings.Default.YaziOzellikleri = FontPenceresi.Font;
                Settings.Default.Save();
            }
        }

        private void Kullanici_Sayfasi_FormClosing(object sender, FormClosingEventArgs e)
         {
            Properties.Settings.Default.Kullanici_Idsi = _userId;
            Properties.Settings.Default.Save();

        }

        private void kategorilerToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string text = e.ClickedItem.Text;
            Kitap_Kategori(text);
            dgv_Sql_Verileri.Visible = false;
            chec_list_box.Visible = true;
            btn_Favorilere_Kaydet.Visible = true;
            btn_Okunacaklara_Kaydet.Visible = true;
            grp_Box_Guncelleme.Visible = false;
            txt_Kitap_Adi_Arama.Visible = false;
            lbl_Kitap_Adi.Visible = false;
            grp_Yazar_Arama.Visible = false;
            rch_tcb_Yazar_bilgileri.Visible = false;
        }

        private void eserAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_Kitap_Adi_Arama.Visible = true;
            lbl_Kitap_Adi.Visible = true;
            chec_list_box.Visible = false;
            dgv_Sql_Verileri.Visible = true;
            grp_Box_Guncelleme.Visible = false;
            grp_Yazar_Arama.Visible = false;
            rch_tcb_Yazar_bilgileri.Visible = false;


            DataTable dt = (DataTable)dgv_Sql_Verileri.DataSource;

            if (dt != null)
            {
                dt.Clear();

            }
        }

        private void txt_Kitap_Adi_Arama_TextChanged(object sender, EventArgs e)
        {
            //dgv_Sql_Verileri.Visible = true;


            List<Kitap> kitaplar = new List<Kitap>();
            baglanti.Open();
            do
            {
                dataTab.Clear();
            } while (dataTab.Rows.Count > 0);
            SqlDataAdapter AdapterS = new SqlDataAdapter("select Eserin_Adi, Eserin_Basim_Tarihi,Eserin_Yazari,Eserin_Turu,Eserin_kategorisi  from Kitap_Bilgileri where Eserin_Adi like '" + txt_Kitap_Adi_Arama.Text + "%'or Eserin_Adi like '" + txt_Kitap_Adi_Arama.Text + "%' or Eserin_Yazari like'" + txt_Kitap_Adi_Arama.Text + "%' or Eserin_kategorisi like '" + txt_Kitap_Adi_Arama.Text + "%' or Eserin_Turu like '" + txt_Kitap_Adi_Arama.Text + "%'", baglanti);

            AdapterS.Fill(dataTab);
            dgv_Sql_Verileri.DataSource = dataTab;

            oku.Close();
            baglanti.Close();
            
            

        }

        private void cantamdakilerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yazarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grp_Yazar_Arama.Visible = true;
            btn_Favorilere_Kaydet.Visible = false;
            btn_Okunacaklara_Kaydet.Visible = false;
            grp_Box_Guncelleme.Visible = false;
            dgv_Sql_Verileri.Visible = false;
            chec_list_box.Visible = false;
            txt_Kitap_Adi_Arama.Visible = false;
            lbl_Kitap_Adi.Visible = false;
            rch_tcb_Yazar_bilgileri.Visible = false;


        }

        private void btn_yazar_Ara_Click(object sender, EventArgs e)
        {
            lbl_Yazar_Kitap_Sayisi_Aciklama.Visible = false;
            lbl_Yazarin_kitap_Sayisi.Visible = false;
            btn_Yazarin_eserleri.Visible = false;
            try
            {
                rch_tcb_Yazar_bilgileri.Visible = true;

                Uri url = new Uri("https://tr.wikipedia.org/wiki/" + turkceharfleri_Degistirme(txt_Yazar_Ismi));
                WebClient client = new WebClient();
                //client.DownloadStringCompleted += client_DownloadStringCompleted;
                client.Encoding = Encoding.UTF8;
                System.Threading.Thread.Sleep(500);
                string html = client.DownloadString(url);

                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);

                var regextexts = GetTextFromHtml(html);


                rch_tcb_Yazar_bilgileri.Text = regextexts;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistemimizde bu isimde bir yazar yoktur!");

            }
            baglanti.Open();
            komut = new SqlCommand("select Kitap_Idsi from Kitap_Bilgileri where Eserin_Yazari ='"+txt_Yazar_Ismi.Text+"'", baglanti);
            oku = komut.ExecuteReader();
            

            while (oku.Read())
            {
                Kitap_idler.Add(Convert.ToInt32(oku[0]));

            }
            baglanti.Close();
            if (Kitap_idler.Count!=0)
            {
                lbl_Yazar_Kitap_Sayisi_Aciklama.Visible = true;
                lbl_Yazarin_kitap_Sayisi.Visible = true;
                btn_Yazarin_eserleri.Visible = true;

                lbl_Yazarin_kitap_Sayisi.Text = Convert.ToString(Kitap_idler.Count);


            }
            baglanti.Close();
            oku.Close();
            


        }
        private static string GetTextFromHtml(string html)
        {
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);


            if (string.IsNullOrEmpty(html))
                return "";


            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(html);
            return GetTextFromNodes(htmlDoc.DocumentNode.ChildNodes);
        }

        private static string GetTextFromNodes(HtmlNodeCollection nodes, int indent = 0)
        {
            StringBuilder texts = new StringBuilder();
            string[] linebreaks = { "p", "br", "th", "tr" };
            string[] indentTag = { "ul", "li" };
            foreach (var node in nodes)
            {
                //if (node.Name.ToLowerInvariant() == "//*[@id='content']")
                //    continue;
                if (node.Name.ToLowerInvariant() == "script")
                    continue;
                if (node.Name.ToLowerInvariant() == "table")
                    continue;
                if (node.Name.ToLowerInvariant() == "li")
                    continue;
                if (node.Name.ToLowerInvariant() == "ul")
                    continue;
                if (node.Name.ToLowerInvariant() == "tr")
                    continue;
                if (node.Name.ToLowerInvariant() == "sup")
                    continue;
                if (node.Name.ToLowerInvariant() == "span")
                    continue;

                if (node.Name.ToLowerInvariant() == "dd")
                    continue;
                if (node.Name.ToLowerInvariant() == "h1")
                    continue;
                if (node.Name.ToLowerInvariant() == "h2")
                    continue;
                if (node.Name.ToLowerInvariant() == "h3")
                    continue;
                if (node.Name.ToLowerInvariant() == "text")
                    continue;
                if (node.Name.ToLowerInvariant() == "role")
                    continue;

                if (node.HasChildNodes)
                {
                    if (indentTag.Contains(node.Name.ToLowerInvariant()))
                        texts.Append(GetTextFromNodes(node.ChildNodes, indent + 1));
                    else
                        texts.Append(GetTextFromNodes(node.ChildNodes, indent));
                }
                else
                {
                    var innerText = node.InnerText;
                    if (!string.IsNullOrWhiteSpace(innerText))
                    {
                        texts.Append(new String(' ', indent) + node.InnerText);
                    }
                }




                if (linebreaks.Contains(node.Name.ToLowerInvariant()))
                    texts.Append("\r\n");

            }

            return texts.ToString();
        }
        public string turkceharfleri_Degistirme(System.Windows.Forms.TextBox text)
        {
            string value = text.Text.ToString();
            // Console.WriteLine("BEFORE: " + value);

            // Store the result of Replace() in a variable.
            // ... All instances of the substring are replaced (not just the first).
            string modified = value.Replace("ı", "%C4%B1").Replace("İ", "%C4%B0").Replace("ç", "%C3%87").Replace("Ç", "%C3%87").Replace("ö", "%C3%96").Replace("Ö", "%C3%96").Replace("ş", "%C5%9E").Replace("Ş", "%C5%9E").Replace("ü", "%C3%BC").Replace("Ü", "%C3%BC").Replace("ğ", "%C4%9F").Replace("Ğ", "%C4%9F").Replace(" ", "_").Replace("ı", "%C4%B1");
            return modified;
            
        }

        private void btn_Yazarin_eserleri_Click(object sender, EventArgs e)
        {
            dgv_Sql_Verileri.Visible = true;
            grp_Yazar_Arama.Visible = false;
            
            
           
            baglanti.Open();
            
            komut = new SqlCommand("select * from Kitap_Bilgileri where Kitap_Idsi = @kitapidsi", baglanti);
            dataAd = new SqlDataAdapter(komut);

            for (int i = 0; i < Kitap_idler.Count; i++)
            {
                komut.Parameters.AddWithValue("@kitapidsi", Kitap_idler[i]);
                dataAd.Fill(table2);
                komut.Parameters.Clear();

                
                
            }
            
            dgv_Sql_Verileri.DataSource = table2;
            baglanti.Close();

            

        }

        private void bilgilerimiGuncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Favorilere_Kaydet.Visible = false;
            btn_Okunacaklara_Kaydet.Visible = false;
            grp_Box_Guncelleme.Visible = true;
            dgv_Sql_Verileri.Visible = false;
            chec_list_box.Visible = false;
            txt_Kitap_Adi_Arama.Visible = false;
            lbl_Kitap_Adi.Visible = false;
            grp_Yazar_Arama.Visible = false;
            rch_tcb_Yazar_bilgileri.Visible = false;

            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select Mail_adresi,telefon_numarasi,sifre from Kullanici_Bilgi where Kullanici_Idsi='" + _userId + "'";
            oku = komut.ExecuteReader();


            while (oku.Read())
            {
                txt_Mailadresi.Text = oku[0].ToString();
                Mail_Adresi = oku[0].ToString();
                txt_Telefonnumarasi.Text = oku[1].ToString();
                Telefon_Numarasi = oku[1].ToString();
                txt_Sifre.Text = oku[2].ToString();
                Sifre = oku[2].ToString();
                txt_Sifre_Tekrar.Text = oku[2].ToString();
            }

            baglanti.Close();
            oku.Close();
        }

        private void btn_grp_box_Guncelle_Click(object sender, EventArgs e)
        {

            int Mail_adresi_kontrol, Telefonnumarasi_kontrol, Sifre_kontrol;

            Mail_adresi_kontrol = string.Compare(Mail_Adresi, txt_Mailadresi.Text);
            Telefonnumarasi_kontrol = string.Compare(Telefon_Numarasi, txt_Telefonnumarasi.Text);
            Sifre_kontrol = string.Compare(Sifre, txt_Sifre.Text);
            Uye_Ol uye_OL_FOrmu = new Uye_Ol();

            ////// mail kklontol EKLEEEEEEEEEEEEEEEEEEEEEe
            if (!(Mail_adresi_kontrol == 0))
            {
                if (uye_OL_FOrmu.Mail_Kont(txt_Mailadresi))
                {
                    baglanti.Open();
                    komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "update Kullanici_Bilgi set Mail_adresi='" + txt_Mailadresi.Text + "' where Kullanici_Idsi ='" + _userId + "'";
                    oku = komut.ExecuteReader();


                    baglanti.Close();
                    oku.Close();

                }
               
            }

            if (!(Telefonnumarasi_kontrol == 0))
            {
                if (uye_OL_FOrmu.Telefon_Kontrol(txt_Telefonnumarasi))
                {
                    baglanti.Open();
                    komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "update Kullanici_Bilgi set telefon_numarasi='" + txt_Telefonnumarasi.Text + "' where Kullanici_Idsi ='" + _userId + "'";
                    oku = komut.ExecuteReader();
                    MessageBox.Show("hadi bakim numara degisti ");
                    baglanti.Close();

                }
                

            }

            if (!(Sifre_kontrol == 0))
            {
                if (txt_Sifre.Text == txt_Sifre_Tekrar.Text)
                {
                    baglanti.Open();
                    komut = new SqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "update Kullanici_Bilgi set sifre='" + txt_Sifre.Text + "' where Kullanici_Idsi ='" + _userId + "'";
                    oku = komut.ExecuteReader();
                    oku.Close();
                    baglanti.Close();


                    MessageBox.Show("hadi bakim sifre degisti ");
                }
                else
                {
                    MessageBox.Show("Sifreler uyusmuyor!", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        
    }
    class Kitap
    {
        //public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string BasimAdi { get; set; }
        public string KitabinYazari { get; set; }
        public string KitapTuru { get; set; }
        public string KitaKitapKategorisipAdi { get; set; }

    }

}
