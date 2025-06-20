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

namespace KutuphaneOtomasyonu
{
    public partial class GirisEkrani: Form
    {
            SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader okuma; 

        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void GirisEKrani_Load(object sender, EventArgs e)
        {
            panelpersonel.Visible = false;


           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelogrenci.BringToFront();

            panelpersonel.Visible = false; 

            panelogrenci.Visible = true;



        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            panelpersonel.BringToFront();

            panelogrenci.Visible = false;

            panelpersonel.Visible = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            baglanti = new SqlConnection("Data Source=DESKTOP-HGGVOAC\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();
            komut = new SqlCommand("SELECT * FROM PERSONEL WHERE PERSONELKULLANICIAD=@PKAD AND PERSONELSIFRE=@PSIFRE" ,baglanti);
            komut.Parameters.AddWithValue("@PKAD" ,textBox3.Text);
            komut.Parameters.AddWithValue("@PSIFRE" ,textBox4.Text);


            okuma = komut.ExecuteReader();

            if (okuma.Read())
            {
                PersonelGiris p  = new  PersonelGiris();
                p.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
            }

            baglanti.Close();

        }

        public void button2_Click(object sender, EventArgs e)
        {
             baglanti = new SqlConnection("Data Source=DESKTOP-HGGVOAC\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();

             komut = new SqlCommand("SELECT * FROM UYEKAYIT WHERE UYEKULLANICIAD=@KAD AND UYESIFRE=@SIFRE", baglanti);
            komut.Parameters.AddWithValue("@KAD", textBoxKullOgrenci.Text);
            komut.Parameters.AddWithValue("@SIFRE", textBoxSifreOgrenci.Text);

             okuma = komut.ExecuteReader();

            if (okuma.Read())
            {
                UyeProfilBilgileri u = new UyeProfilBilgileri();
                u.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
            }

            baglanti.Close(); 


        }


        private void panelpersonel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelogrenci_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
