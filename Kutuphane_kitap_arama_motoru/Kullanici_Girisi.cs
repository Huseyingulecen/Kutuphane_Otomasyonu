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

namespace Kutuphane_kitap_arama_motoru
{
    
    public partial class Kullanici_Girisi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E76DIU4\\SQLEXPRESS;Initial Catalog=Kutuphane_bilgileri;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader oku;
        // SqlDataAdapter dataA = new SqlDataAdapter();

        Kullanici_Sayfasi Kullanici_Sayfasi_Formu;


        Ana_Sayfa Ana_Sayfa_Formu = new Ana_Sayfa();
        string Kullanici_Idsi_Key;
        ////Kullanici_Sayfasi Kulklanici_Formu222 = new Kullanici_Sayfasi();




        public Kullanici_Girisi()
        {
            InitializeComponent();
            
            


        }

        public int Kullanici_Primer_Idsi()
        {
            SqlCommand komut2 = new SqlCommand();
            komut2.Connection = baglanti;
            komut2.CommandText = "select Kullanici_Idsi from Kullanici_Bilgi where Id_numarasi= '" + txt_Kullanici_Idsi.Text + "' ";
            SqlDataReader oku2;
            oku2 = komut2.ExecuteReader();
            int kullaniciPremier_IDSI;
            kullaniciPremier_IDSI = Convert.ToInt32(oku2[0]);


            return kullaniciPremier_IDSI;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = 
            //this.BackColor = Settings.Default.Formrengi;
            this.BackColor = Properties.Settings.Default.Formrengi;
            this.Font = Properties.Settings.Default.YaziOzellikleri;
            lbl_Kulaanici_idsi.Font = Properties.Settings.Default.YaziOzellikleri;
            lbl_sifre_giriniz.Font = Properties.Settings.Default.YaziOzellikleri;

        }

        private SqlDataReader kullanici_Giris(TextBox kullaniciadi, TextBox sifre)
        {
            ////////////////////////////if (!(Properties.Settings.Default.Kullanici_Idsi==null))
            ////////////////////////////{
            ////////////////////////////    ////Kullanici_Sayfasi_Formu.Show();
            ////////////////////////////    ////this.Hide();

            ////////////////////////////}
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from Kullanici_Bilgi where Id_numarasi ='" + kullaniciadi.Text + "'";
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                if (sifre.Text.Trim() == oku["sifre"].ToString().Trim())
                {


                    MessageBox.Show("Giris basarili");
                    Kullanici_Sayfasi_Formu = new Kullanici_Sayfasi((int)oku["Kullanici_Idsi"]);


                    // Kullanici_Primer_Idsi();






                    Kullanici_Sayfasi_Formu.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Sifrenizi kontrol ediniz ", "Hata1");
                    this.Show();

                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz !", "Hata 2 ");
                this.Show();


            }
            baglanti.Close();
            return oku;



        }

        private void btn_Giris_yap_Click(object sender, EventArgs e)
        {
            try
            {

                Kullanici_Girisi Kullanici_Girisi_Formu = new Kullanici_Girisi();
                Kullanici_Girisi_Formu.kullanici_Giris(txt_Kullanici_Idsi, txt_Kullanici_Sifresi);

                this.Hide();

            }
            catch
            {
                MessageBox.Show("Islem yapoilirken bir hata olustu. \n Kullanici idsi bolumune id numaranizi girmelisiniz. Lutfen kontrol ediniz!");

            }

        }
        public string kullanici_Idsi_okuma()
        {

            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select Kullanici_Idsi from Kullanici_Bilgi where Id_numarasi='" + txt_Kullanici_Idsi.Text + "'";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Kullanici_Idsi_Key = oku[0].ToString();

            }
            baglanti.Close();

            return Kullanici_Idsi_Key;



        }

        private void btn_Geri_cik_Click(object sender, EventArgs e)
        {
            Ana_Sayfa_Formu.Show();
            this.Hide();


        }
        
        private void chb_Sifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Sifre.Checked)
            {

                txt_Kullanici_Sifresi.PasswordChar = '\0';
            }

            else
            {
                txt_Kullanici_Sifresi.PasswordChar = '#';
            }
        }
        
        
    }
}
