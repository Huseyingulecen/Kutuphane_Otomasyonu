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
using System.Net;
using System.Net.Mail;
using Microsoft.Win32;
using System.Drawing;


namespace Kutuphane_kitap_arama_motoru
{
    public partial class Yonetici_Sayfasi : Form
    {



        public Yonetici_Sayfasi(int yon_Id)
        {
            InitializeComponent();
            yonetici_Id = yon_Id;

        }
        public Yonetici_Sayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E76DIU4\\SQLEXPRESS;Initial Catalog=Kutuphane_bilgileri;Integrated Security=True;MultipleActiveResultSets=True");
        SqlCommand komut;
        SqlCommand komut2;
        SqlCommand komut3;

        string eserin_Adi;

        string kullanici_mail;
        string kullanici_tel;
        string resimPath;
        string resimPathSorgu;
        System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();

        SqlDataReader oku;

        SqlDataAdapter dataAd;
        bool Kullanici_id_Konrol;
        int yonetici_Id;
        int gun_sayisi;
        string Mail_adresi_kontrol, Telefonnumarasi_kontrol, Sifre_kontrol;
        
        private void eserKaydetmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grb_Eser_Kaydetme.Visible = true;
            grb_Eser_Verme.Visible = false;
            grb_Kullanici_Sorgu.Visible = false;
            grb_Yonetici_Kayit.Visible = false;
            grb_Zamaninda_Gelmeyen_kitaplar.Visible = false;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = " insert into Kitap_Bilgileri (Eserin_Adi,Eserin_Basim_Tarihi,Eserin_Yazari,Eserin_Turu,Eserin_kategorisi,kitap_adedi,Fotograf) values (@Adi, @Yazar, @Basim,@Kategorisi, @turu, @kitapadedi,@Fotograf)";
            komut.Parameters.AddWithValue("@Adi", txt_Eserin_Adi.Text);
            komut.Parameters.AddWithValue("@Yazar", txt_Eserin_Yazari.Text);
            komut.Parameters.AddWithValue("@Basim", txt_Eserin_Basim_Tarihi.Text);
            komut.Parameters.AddWithValue("@Kategorisi", txt_Eserin_Kategorisi.Text);
            komut.Parameters.AddWithValue("@turu", txt_Eserin_Turu.Text);
            komut.Parameters.AddWithValue("@kitapadedi", txt_Eserin_Adedi.Text);
            if (!String.IsNullOrEmpty(resimPath))
            {
                komut.Parameters.AddWithValue("@Fotograf", resimPath);
                
            }
            else
            {
                komut.Parameters.AddWithValue("@Fotograf", null);
            }

            baglanti.Open();

            komut.ExecuteNonQuery();
            baglanti.Close();
            string Kitap_idsi;

            
           

            baglanti.Open();

            komut = new SqlCommand("Select MAX(Kitap_Idsi) FROM Kitap_Bilgileri ", baglanti);

            oku = komut.ExecuteReader();

            if (oku.Read())
            {
                Kitap_idsi = oku[0].ToString();
                MessageBox.Show(Kitap_idsi);
            }

            baglanti.Close();

            this.Show();

        }

        private void kullanicilaraKitabVermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grb_Eser_Kaydetme.Visible = false;
            grb_Eser_Verme.Visible = true;
            grb_Kullanici_Sorgu.Visible = false;
            grb_Yonetici_Kayit.Visible = false;
            grb_Zamaninda_Gelmeyen_kitaplar.Visible = false;
            if (!String.IsNullOrEmpty(txt_Kitap_Idsi.Text.ToString()) && !String.IsNullOrEmpty(txt_Kullanici_Idsi.Text.ToString()))
            {
                btn_Kitabi_Ver.Enabled = true;
                btn_Kitap_Alma.Enabled = true;

            }


        }

        private void Yonetici_Sayfasi_Load(object sender, EventArgs e)
        {
            

        }

        private void txt_Kullanici_Idsi_TextChanged(object sender, EventArgs e)
        {
            txt_Kitap_Idsi.Enabled = true;
            btn_Kitabi_Ver.Enabled = true;
            btn_Kitap_Alma.Enabled = true;

            //if(txt_Kitap_Idsi.TextLength<=11)
            if (!String.IsNullOrEmpty(txt_Kullanici_Idsi.Text))
            {
                baglanti.Open();
                komut = new SqlCommand("select * from Kullanici_Bilgi where Id_numarasi = '" + txt_Kullanici_Idsi.Text + "'", baglanti);
                oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    Kullanici_id_Konrol = true;

                }
                else
                {
                    Kullanici_id_Konrol = false;


                }

                baglanti.Close();
                if (Kullanici_id_Konrol == false)
                {
                    txt_Kitap_Idsi.Enabled = false;
                    btn_Kitabi_Ver.Enabled = false;
                    btn_Kitap_Alma.Enabled = false;


                }

            }


        }

        private void btn_Kitabi_Ver_Click(object sender, EventArgs e)
        {
            if (TcDogruMu(txt_Kullanici_Idsi))
            {
                int kitap_adedi;
                //DateTime 
                baglanti.Open();
                komut = new SqlCommand("select kitap_adedi from Kitap_Bilgileri where Kitap_Idsi = '" + txt_Kitap_Idsi.Text + "'", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    kitap_adedi = Convert.ToInt32(oku[0]);
                    if (kitap_adedi == 0)
                    {
                        MessageBox.Show("Bu kitap kullanicilarda lutfen baska kitap seciniz ");
                        return;
                    }
                    else
                    {
                        komut2 = new SqlCommand("insert into Kitap_Degistirme_bilgileri (Kitap_Idsi,Kitabin_kullanicidan_Verildigi_Tarih,Kitabi_Veren_Gorevli,Kullanici_Idsi) values(@VerilenKitap,@kitabinverildigi_tarih,@kitabiverengorevli,@Kullanici_idsi)", baglanti);
                        komut2.Parameters.AddWithValue("@VerilenKitap", txt_Kitap_Idsi.Text);
                        komut2.Parameters.AddWithValue("@kitabinverildigi_tarih", DateTime.Today);


                        komut2.Parameters.AddWithValue("@kitabiverengorevli", yonetici_Id);
                        komut2.Parameters.AddWithValue("@Kullanici_idsi", txt_Kullanici_Idsi.Text);

                        komut2.ExecuteNonQuery();
                        kitap_adedi = kitap_adedi - 1;

                        komut3 = new SqlCommand("update Kitap_Bilgileri set kitap_adedi = '" + kitap_adedi + "'  where Kitap_Idsi = '" + txt_Kitap_Idsi.Text + "'", baglanti);
                        komut3.ExecuteNonQuery();


                        MessageBox.Show("Kitap verme islemi gerceklesmistir");

                    }

                }

                baglanti.Close();

            }



        }

        private void btn_Kitap_Alma_Click(object sender, EventArgs e)
        {


            if (TcDogruMu(txt_Kullanici_Idsi))
            {
                int kitap_adedi;
                baglanti.Open();
                komut = new SqlCommand("select kitap_adedi from Kitap_Bilgileri where Kitap_Idsi = '" + txt_Kitap_Idsi.Text + "'", baglanti);
                oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    kitap_adedi = Convert.ToInt32(oku[0]);
                    kitap_adedi = kitap_adedi + 1;

                    komut3 = new SqlCommand("update Kitap_Bilgileri set kitap_adedi = '" + kitap_adedi + "'  where Kitap_Idsi = '" + txt_Kitap_Idsi.Text + "'", baglanti);
                    komut3.ExecuteNonQuery();

                }
                //////hatam var !!! convert hatasi veriyor dene 
                komut2 = new SqlCommand("update Kitap_Degistirme_bilgileri set Kitabin_KullanicidanAlindigi_tarih = @Kullanici_alinan_tarih where Kitap_Idsi = @Kitap_Idsi and Kullanici_Idsi = @Kullanici_Idsi", baglanti);
                komut2.Parameters.AddWithValue("@Kullanici_alinan_tarih", DateTime.Today);
                komut2.Parameters.AddWithValue("@Kitap_Idsi", txt_Kitap_Idsi.Text);
                komut2.Parameters.AddWithValue("@Kullanici_Idsi", txt_Kullanici_Idsi.Text);

                komut2.ExecuteNonQuery();
                MessageBox.Show("Kitap alma islemi gerceklesmistir");

                baglanti.Close();
            }

        }

        private void yeniYoneticiEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grb_Eser_Kaydetme.Visible = false;
            grb_Eser_Verme.Visible = false;
            grb_Yonetici_Kayit.Visible = true;
            grb_Kullanici_Sorgu.Visible = false;
            grb_Zamaninda_Gelmeyen_kitaplar.Visible = false;

        }

        private void btn_Gorevli_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select Yonetici_Idsi from Yoneticilerin_Bilgisi where Id_Numarasi = "+txt_Yon_Idi.Text+"",baglanti);
            if (Convert.ToInt32(komut4.ExecuteScalar()) == 0)
            {
                baglanti.Close();
                Uye_Ol Uye_Ol_Formu = new Uye_Ol();
                string sorgu = "insert into Yoneticilerin_Bilgisi(Adi, Soyadi, Id_Numarasi, Dogum_Tarihi, Egitim_Durumu, Mail_Adresi, Telefon_Numarasi, Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                if (TcDogruMu(txt_Yon_Idi))
                {
                    if (Uye_Ol_Formu.Mail_Kont(txt_Yon_Mail) && Uye_Ol_Formu.Telefon_Kontrol(txt_Yon_Tel_No))
                    {
                        if (txt_Yon_Tel_No.TextLength >= 6)
                        {
                            try
                            {
                                Uye_Ol_Formu.Yeni_Kullanici(sorgu, txt_Yon_Adi, txt_Yon_Soyadi, txt_Yon_Idi, dtp_Yon_Dogum_Tarihi, rdb_Lise, txt_Yon_Mail, txt_Yon_Tel_No, txt_Yon_Sifre, txt_Yon_Sifre_Tekrar);
                            }
                            catch
                            {
                                MessageBox.Show("Islem yapoilirken bir hata olustu. \n  Butun bilgilerin doldurulmus oldugundan emin olunuz!! ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sifreniz en az 6 karakter olmalidir!!", "uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }

                }

            }
            else
            {
                baglanti.Close();
                MessageBox.Show("lutfen TC nizi kontrol ediniz! ");
            }
                
            

        }

        private void btn_Ara_Sorgu_Click(object sender, EventArgs e)
        {
            if (TcDogruMu(txt_Kullanici_idi_Sorgu))
            {
                baglanti.Open();
                komut = new SqlCommand("select Adi,Soyadi,Mail_adresi,telefon_numarasi from Kullanici_Bilgi where Id_numarasi = '" + txt_Kullanici_idi_Sorgu.Text + "'", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txt_Kullanici_Adi.Text = oku[0].ToString();
                    txt_Kullanici_Soyadi.Text = oku[1].ToString();
                    txt_Kullanici_Mail.Text = oku[2].ToString();
                    kullanici_mail = oku[2].ToString();
                    txt_Kullanici_Tel.Text = oku[3].ToString();
                    kullanici_tel = oku[3].ToString();

                }

                txt_Kullanici_Adi.Enabled = false;
                txt_Kullanici_Soyadi.Enabled = false;
                baglanti.Close();

            }


        }

        

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
           /* Mail_adresi_kontrol = string.Compare(Mail_Adresi, txt_Mailadresi.Text);
            Telefonnumarasi_kontrol = string.Compare(Telefon_Numarasi, txt_Telefonnumarasi.Text);
            Sifre_kontrol = string.Compare(Sifre, txt_Sifre.Text);*/
           /// Mail_adresi_kontrol = string.Compare()
            Uye_Ol Uye_Ol_Formu = new Uye_Ol();

            //if (TcDogruMu(txt_Kullanici_idi_Sorgu))
            if (TcDogruMu(txt_Kullanici_idi_Sorgu))
            {
                if (kullanici_mail.ToString() != txt_Kullanici_Mail.Text)
                {

                    if (Uye_Ol_Formu.Mail_Kont(txt_Kullanici_Mail))
                    {
                        baglanti.Open();
                        komut = new SqlCommand("update Kullanici_Bilgi set mail_adresi= '" + txt_Kullanici_Mail.Text + "' where Id_numarasi='" + txt_Kullanici_idi_Sorgu.Text + "'", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                    }
                    else
                        MessageBox.Show("Girdiginiz ifadenin mail olmasi gereklidir");
                }
                if (kullanici_tel.ToString() != txt_Kullanici_Tel.Text)
                {
                    if (Uye_Ol_Formu.Telefon_Kontrol(txt_Kullanici_Tel))
                    {
                        baglanti.Open();
                        komut = new SqlCommand("update Kullanici_Bilgi set telefon_numarasi= '" + txt_Kullanici_Tel.Text + "' where Id_numarasi='" + txt_Kullanici_idi_Sorgu.Text + "'", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                         MessageBox.Show("Girdiginz ifade 9 haneli telfon numarasi olmalidir ");



                }

            }
           

        }


        public bool TcDogruMu(TextBox tekstboxadi)
        {
            string kimlikno = tekstboxadi.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                errorProvider1.SetError(tekstboxadi, "TC numarasi 11 basamakli olmalidir!");
                // MessageBox.Show("TC Kimlik Numaranızı eksik girdiniz!\nLütfen tekrar deneyin.");
                tekstboxadi.Clear();

                return false;
            }
            int[] sayilar = new int[11];
            for (int i = 0; i < kimlikno.Length; i++)
            {
                sayilar[i] = Int32.Parse(kimlikno[i].ToString());
            }
            int toplam = 0;
            for (int i = 0; i < kimlikno.Length - 1; i++)
            {
                toplam += sayilar[i];
            }
            if (toplam.ToString()[1].ToString() == sayilar[10].ToString() & sayilar[10] % 2 == 0)
            {
                return true;
            }
            else
            {
                errorProvider1.SetError(tekstboxadi, "TC numarasi 11 basamakli olmalidir");
                //MessageBox.Show("Girilen Tc Kimlik No yanlıştır!\nLütfen kontrol ediniz.");
                return false;
            }
        }

        private void kitabiZamanindaGetirmeyenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            grb_Eser_Kaydetme.Visible = false;
            grb_Eser_Verme.Visible = false;
            grb_Yonetici_Kayit.Visible = false;
            grb_Kullanici_Sorgu.Visible = false;
            grb_Zamaninda_Gelmeyen_kitaplar.Visible = true;
            dtg_Zamaninda_Gelmeyen_Kitaplar.Visible = true;


            baglanti.Open();
            komut = new SqlCommand("select Kitabin_KullanicidanAlindigi_tarih,Kitabin_kullanicidan_Verildigi_Tarih,Kullanici_Idsi,Kitap_Idsi from Kitap_Degistirme_bilgileri", baglanti);

            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (string.IsNullOrEmpty(oku[0].ToString()))
                {
                    dtg_Zamaninda_Gelmeyen_Kitaplar.ColumnCount = 3;
                    dtg_Zamaninda_Gelmeyen_Kitaplar.Columns[0].Name = "Kitabn Verildigi tarih ";
                    dtg_Zamaninda_Gelmeyen_Kitaplar.Columns[1].Name = "Kullanici Idsi";
                    dtg_Zamaninda_Gelmeyen_Kitaplar.Columns[2].Name = "Kitap Idsi";
                    dtg_Zamaninda_Gelmeyen_Kitaplar.Rows.Add(Convert.ToDateTime(oku[1]).ToShortDateString(), oku[2], oku[3]);
                    //TimeSpan sonuc = Convert.ToDateTime(DateTime.Today) - Convert.ToDateTime(oku[1].ToString());
                    //gun_sayisi = sonuc.Days;
                }

            }
            baglanti.Close();


            for (int i = 0; i < dtg_Zamaninda_Gelmeyen_Kitaplar.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                ///TimeSpan sonuc_2 = Convert.ToDateTime(DateTime.Today) - Convert.ToDateTime(dtg_Zamaninda_Gelmeyen_Kitaplar.Rows[i].Cells["Kitabn Verildigi tarih "].Value);



                if ((Convert.ToDateTime(DateTime.Today) - Convert.ToDateTime(dtg_Zamaninda_Gelmeyen_Kitaplar.Rows[i].Cells["Kitabn Verildigi tarih "].Value)).Days > 15)
                {
                    dtg_Zamaninda_Gelmeyen_Kitaplar.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if ((Convert.ToDateTime(DateTime.Today) - Convert.ToDateTime(dtg_Zamaninda_Gelmeyen_Kitaplar.Rows[i].Cells["Kitabn Verildigi tarih "].Value)).Days <= 15)
                {
                    dtg_Zamaninda_Gelmeyen_Kitaplar.Rows[i].DefaultCellStyle.BackColor = Color.DeepSkyBlue;

                }
                // dtg_Zamaninda_Gelmeyen_Kitaplar.Rows[i].DefaultCellStyle.BackColor = renk;

            }



        }

        private void pct_box_Eser_Fotografi_Click(object sender, EventArgs e)
        {

        }

        private void btn_Resim_Ekleme_Click(object sender, EventArgs e)
        {

            //string dosyayolu = dia
            pcr_Eser_Fotosu_ekleme.Visible = true;
            
            dialog.Title = "Resim Ac ";
            dialog.Filter = "Jpeg dosyası (*.jpg)|*.jpg|Gif Dosyası(*.gif)|*.gif|Png Dosyası(*.png)|*.png|Tif Dosyası (*.tif)|*.tif ";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                pcr_Eser_Fotosu_ekleme.Image = Image.FromFile(dialog.FileName);
                resimPath = dialog.FileName.ToString();

            }


        }

        private void txt_Kitap_Idsi_TextChanged(object sender, EventArgs e)
        {
            //resimPathSorgu = " ";#

            pct_box_Eser_Fotografi_Show.Visible = false;
            lbl_Esrin_Adi_Kon.Visible = false;
            eserin_Adi = " ";

            if (!String.IsNullOrEmpty(txt_Kitap_Idsi.Text))
            {
                baglanti.Open();
                komut2 = new SqlCommand("select Fotograf from Kitap_Bilgileri where Kitap_Idsi='" + txt_Kitap_Idsi.Text + "'", baglanti);
                oku = komut2.ExecuteReader();
                while (oku.Read())
                {
                    resimPathSorgu = oku[0].ToString();

                }
                baglanti.Close();

            }
            if (!String.IsNullOrEmpty(resimPathSorgu))
            {

                pct_box_Eser_Fotografi_Show.Image = Image.FromFile(resimPathSorgu);
                pct_box_Eser_Fotografi_Show.Visible = true;

            }
            else
            {
                

                baglanti.Open();
                komut2 = new SqlCommand("select Eserin_Adi from Kitap_Bilgileri where Kitap_Idsi='" + txt_Kitap_Idsi.Text + "'", baglanti);
                oku = komut2.ExecuteReader();
                while(oku.Read())
                {
                    eserin_Adi = oku[0].ToString();

                }
                baglanti.Close();
                if (!String.IsNullOrEmpty(eserin_Adi))
                {
                    lbl_Esrin_Adi_Kon.Text = eserin_Adi;
                    lbl_Esrin_Adi_Kon.Visible = true;


                }
            }
            //resimPathSorgu = null;


        }

        private void grb_Zamaninda_Gelmeyen_kitaplar_Enter(object sender, EventArgs e)
        {

        }

        private void kullaniciBilgileriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            grb_Eser_Kaydetme.Visible = false;
            grb_Eser_Verme.Visible = false;
            grb_Yonetici_Kayit.Visible = false;
            grb_Kullanici_Sorgu.Visible = true;
            grb_Zamaninda_Gelmeyen_kitaplar.Visible = false;
        }
    }
}
