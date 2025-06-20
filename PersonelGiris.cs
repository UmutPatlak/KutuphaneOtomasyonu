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
    public partial class PersonelGiris: Form
    {
        SqlConnection baglanti;
        SqlDataReader oku;
        SqlCommand komut; 

        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitEkrani kayit = new KayitEkrani();
            kayit.Show();
        }

        private void UyeKAyit_Click(object sender, EventArgs e)
        {
            UyeKayit uye = new UyeKayit();
            uye.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelBilgileri bilgi = new PersonelBilgileri();
            bilgi.Show();
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HGGVOAC\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();

            komut = new SqlCommand("SELECT TOP 1 PERSONELAD, PERSONELSOYAD FROM PERSONEL", baglanti); 
            oku = komut.ExecuteReader();

            if (oku.Read()) 
            {
                adlabel.Text = oku["PERSONELAD"].ToString();
                soyadlabel.Text = oku["PERSONELSOYAD"].ToString();
            }

            oku.Close();
            baglanti.Close();

        }

        private void adlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
