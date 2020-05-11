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
    public partial class Yonetici_Girisi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E76DIU4\\SQLEXPRESS;Initial Catalog=Kutuphane_bilgileri;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader oku;
        Yonetici_Sayfasi Yonetici_Sayfasi_Formu;
        Ana_Sayfa Ana_Sayfa_Formu = new Ana_Sayfa();




        public Yonetici_Girisi()
        {
            InitializeComponent();
           

        }
        private SqlDataReader yonetici_Giris(TextBox kullaniciadi, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from Yoneticilerin_Bilgisi where Id_Numarasi='" + kullaniciadi.Text + "'";
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                if (sifre.Text.Trim() == oku["Sifre"].ToString().Trim())
                {
                    MessageBox.Show("Giris basarili");
                    Yonetici_Sayfasi_Formu = new Yonetici_Sayfasi(Convert.ToInt32(txt_Kullanici_Idsi_Yon.Text));
                    Yonetici_Sayfasi_Formu.Show();
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
        private void Yonetici_Girisi_Load(object sender, EventArgs e)
        {

        }


        

        private void btn_Giris_yap_Click(object sender, EventArgs e)
        {
            try
            {
                yonetici_Giris(txt_Kullanici_Idsi_Yon, txt_Kullanici_Sifresi_Yon);


            }
            catch
            {
                MessageBox.Show("Islem yapoilirken bir hata olustu. \n Uye idsi bolumune id numaranizi girmelisiniz. Lutfen kontrol ediniz!");
            }


        }

        private void btn_Geri_cik_Click(object sender, EventArgs e)
        {
            Ana_Sayfa_Formu.Show();
            this.Hide();


        }
        
    }
}
