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




namespace Kutuphane_kitap_arama_motoru
{
    
    public partial class Ana_Sayfa : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E76DIU4\\SQLEXPRESS;Initial Catalog=Kutuphane_bilgileri;Integrated Security=True;MultipleActiveResultSets=true");
        Kullanici_Sayfasi Kullanici_Sayfasi_Formu;
        SqlCommand komut;
        SqlCommand komut2;

        SqlDataReader oku;
        SqlDataReader oku2;
        // int sonuc;
        int gun_sayisi;
        string kullanici_Idsi;


        public Ana_Sayfa()
        {
            InitializeComponent();
            
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.Formrengi;
            this.Font = Properties.Settings.Default.YaziOzellikleri;
            //lbl_Anasyf_Baslik.Font= Properties.Settings.Default.YaziOzellikleri;
            btn_Kullanici_Girisi.Font = Properties.Settings.Default.YaziOzellikleri;
            btn_Uye_ol.Font = Properties.Settings.Default.YaziOzellikleri;
            btn_Yonetici_girisi.Font = Properties.Settings.Default.YaziOzellikleri;
            //Mail_gonder();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Kullanici_Girisi_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Kullanici_Idsi != 0)
            {
                Kullanici_Sayfasi_Formu = new Kullanici_Sayfasi(Convert.ToInt32(Properties.Settings.Default.Kullanici_Idsi));
                Kullanici_Sayfasi_Formu.Show();
                this.Hide();
            }
            else
            {
                Kullanici_Girisi Kullanici_Girisi_Formu = new Kullanici_Girisi();
                Kullanici_Girisi_Formu.Show();
                this.Hide();
            }
        }

        private void btn_Yonetici_girisi_Click(object sender, EventArgs e)
        {
            Yonetici_Girisi Yoneticiformu = new Yonetici_Girisi();
            Yoneticiformu.Show();
            this.Hide();

        }

        private void btn_Uye_ol_Click(object sender, EventArgs e)
        {
            Uye_Ol UyeFormu = new Uye_Ol();
            UyeFormu.Show();
            this.Hide();

        }
        private void Mail_gonder()
        {
            //DateTime now = DateTime.Today;
            baglanti.Open();
            komut = new SqlCommand("select Kitabin_KullanicidanAlindigi_tarih,Kitabin_kullanicidan_Verildigi_Tarih,Kullanici_Idsi from Kitap_Degistirme_bilgileri ", baglanti);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (string.IsNullOrEmpty(oku[0].ToString()) && Properties.Settings.Default.Mail_kontrol != DateTime.Today)
                {
                    bool aaa = string.IsNullOrEmpty(oku[0].ToString());
                    bool kk = Properties.Settings.Default.Mail_kontrol != DateTime.Today;
                    string AA = oku[0].ToString();
                    string KK = Properties.Settings.Default.Mail_kontrol.ToString();



                    TimeSpan sonuc = Convert.ToDateTime(DateTime.Today) - Convert.ToDateTime(oku[1].ToString());
                    gun_sayisi = sonuc.Days;
                    gun_sayisi = gun_sayisi - 1;
                    // bool gunsayisi_kontrol = gun_sayisi % 5 == 0;
                    if (gun_sayisi >= 15 && gun_sayisi % 5 == 0)
                    {
                        // oku2 = new SqlDataReader();

                        kullanici_Idsi = oku[2].ToString();
                        //oku.Close();
                        komut2 = new SqlCommand("select Mail_adresi from Kullanici_Bilgi where Id_numarasi= '" + kullanici_Idsi.ToString() + "'", baglanti);
                        /////////////komut2.ExecuteNonQuery();

                        oku2 = komut2.ExecuteReader();
                        while (oku2.Read())
                        {
                            MailMessage ePosta = new MailMessage();
                            ePosta.From = new MailAddress("hsanfettah06@gmail.com");
                            ePosta.To.Add(oku2[0].ToString());
                            ePosta.Subject = "kitap getirme!!!";
                            //ePosta.IsBodyHtml = true;
                            ePosta.Body = "Bu bir uyari  mesaijidir. kutuphanemizden almis oldugunuz kitabi getirme tarihni gecirmis bulunuyorsunuz getirmenizi rica ederiz !\n Bir takim itisel sakalar BILGISAYAR KORSANLIGINA DOGRU =)";
                            SmtpClient smtp = new SmtpClient();
                            smtp.Credentials = new NetworkCredential("hsanfettah06@gmail.com", "POLONYA45");
                            ///	hsanfettah06@gmail.com POLONYA45
                            ///	"tahatan4545@yandex.com", "Taha1998"
                            smtp.Port = 587;
                            smtp.Host = "smtp.gmail.com";
                            smtp.EnableSsl = true;

                            // smtp.SendAsync(ePosta, (object)ePosta);
                            smtp.Send(ePosta);

                        }

                    }


                }

            }
            baglanti.Close();

            Properties.Settings.Default.Mail_kontrol = Convert.ToDateTime("12/01/2011");
            Properties.Settings.Default.Save();






        }
    }
}
