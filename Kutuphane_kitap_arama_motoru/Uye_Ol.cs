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
using System.Net.Mail;
using System.Text.RegularExpressions;



namespace Kutuphane_kitap_arama_motoru
{

    
    public partial class Uye_Ol : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E76DIU4\\SQLEXPRESS;Initial Catalog=Kutuphane_bilgileri;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader oku;
      
        //Uye_Ol Uye_Ol_Formu = new Uye_Ol();

        public Uye_Ol()
        {
            InitializeComponent();
        }

        int yonetici_idsi;

        Regex Kontrol_mail = new Regex(@"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
   + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
   + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$");
        Regex Kontrol_telefon = new Regex(@"^((\d{9}))$");
        Yonetici_Sayfasi yonetici_Sayfasi_Formu = new Yonetici_Sayfasi();


        public void Yeni_Kullanici(string text, TextBox Adi, TextBox Soyadi, TextBox Id_numarasi, DateTimePicker dogum_tarihi, RadioButton Egitim_durumu, TextBox Mail, TextBox telefon, TextBox sifre, TextBox sifretekrari)
        {

            if (sifre.Text == sifretekrari.Text)
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;

                komut.CommandText = text;
                komut.Parameters.AddWithValue("@p1", Adi.Text);
                komut.Parameters.AddWithValue("@p2", Soyadi.Text);
                komut.Parameters.AddWithValue("@p3", Id_numarasi.Text);
                komut.Parameters.AddWithValue("@p4", Convert.ToDateTime(dogum_tarihi.Text));
                komut.Parameters.AddWithValue("@p5", Egitim_durumu.Text);
                komut.Parameters.AddWithValue("@p6", Mail.Text);
                komut.Parameters.AddWithValue("@p7", telefon.Text);
                komut.Parameters.AddWithValue("@p8", sifre.Text);

                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();

                baglanti.Close();
                Adi.Text = "";
                Soyadi.Text = "";
                Id_numarasi.Text = "";
                Mail.Text = "";
                telefon.Text = "";
                sifre.Text = "";
                sifretekrari.Text = "";


                MessageBox.Show("Uye eklendi !   ");


            }
            else
            {
                MessageBox.Show("Sifreler uyusmuyor!", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool Mail_Kont(TextBox mail)
        {
            if (Kontrol_mail.IsMatch(mail.Text))
            {
                return true;

            }
            else
            {
                MessageBox.Show("Lutfen mail adresinizi giriniz! ", "uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }
        public bool Telefon_Kontrol(TextBox telefon)
        {
            if (Kontrol_telefon.IsMatch(telefon.Text))
            {
                return true;

            }
            else
            {
                MessageBox.Show("Lutfen telefon numaranizi giriniz! ", "uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select Kullanici_Idsi from Kullanici_Bilgi where Id_numarasi = " + txt_Id_Num.Text + "", baglanti);
            if (Convert.ToInt32(komut2.ExecuteScalar()) == 0)
            {
                baglanti.Close();
                if (yonetici_Sayfasi_Formu.TcDogruMu(txt_Id_Num))
                {
                    string sorgu = "insert into Kullanici_Bilgi (Adi,Soyadi,Id_numarasi,Dogum_tarihi,Egitim_durumu,Mail_adresi,telefon_numarasi,sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                    if (Mail_Kont(txt_Mail_Adresi) && Telefon_Kontrol(txt_Telefon_Numarasi))
                    {
                        if (txt_Sifreniz.TextLength >= 6)
                        {
                            try
                            {
                                Yeni_Kullanici(sorgu, txt_Ad, txt_Soyadi, txt_Id_Num, dtp_Dogum_Tarihi, rdb_Ilkokul, txt_Mail_Adresi, txt_Telefon_Numarasi, txt_Sifreniz, txt_Sifre_Tekrari);

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
                        Ana_Sayfa Ana_Sayfa_Formu = new Ana_Sayfa();
                        Ana_Sayfa_Formu.Show();
                        this.Hide();

                    }
                }
            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Zaten bole bir kullanici mevcut ");
            }
            



        }

        

        private void btn_Geri_cik_Click(object sender, EventArgs e)
        {
            Ana_Sayfa Ana_Sayfa_Formu = new Ana_Sayfa();
            Ana_Sayfa_Formu.Show();
            this.Hide();

        }
        


        private void Uye_Ol_Load(object sender, EventArgs e)
        {
            
        }

       
        private void chb_Sifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Sifre.Checked)
            {

                txt_Sifreniz.PasswordChar = '\0';
            }

            else
            {
                txt_Sifreniz.PasswordChar = '#';
            }
        }

        private void chb_Sifre_tekrari_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Sifre_tekrari.Checked)
            {

                txt_Sifre_Tekrari.PasswordChar = '\0';
            }

            else
            {
                txt_Sifre_Tekrari.PasswordChar = '#';
            }
        }

        private void grb_Veri_girisi_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
