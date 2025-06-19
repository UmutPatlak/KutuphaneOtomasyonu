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
    public partial class PersonelBilgileri: Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter dt; 

      
        public PersonelBilgileri()
        {


            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        void PersonelleriGetir()
        {

            baglanti = new SqlConnection("Data Source=DESKTOP-HGGVOAC\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();
            dt = new SqlDataAdapter("SELECT * FROM PERSONEL", baglanti);
            DataTable datatable = new DataTable();
            dt.Fill(datatable);
            dataGridView1.DataSource = datatable;

            baglanti.Close();

        }

        private void PersonelBilgileri_Load(object sender, EventArgs e)
        {


            textAd.Text = PersonelBilgileriSinifi.persoad;
            textAdres.Text = PersonelBilgileriSinifi.persoAdres;
            textBoxEmail.Text = PersonelBilgileriSinifi.persoeMail;
            textBoxKullanciAdi.Text = PersonelBilgileriSinifi.persokullaniciAdi;
            textBoxSifre.Text = PersonelBilgileriSinifi.persosifre;
            comboBoxDurum.SelectedItem = PersonelBilgileriSinifi.persoDurum; 
            maskedTextTel.Text = PersonelBilgileriSinifi.persoTel;
            maskedTextTC.Text = PersonelBilgileriSinifi.persotc;
            maskedTextboxKayitT.Text = PersonelBilgileriSinifi.persokayitTarihi;
            textSoyad.Text = PersonelBilgileriSinifi.persosoyAd; 

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelleriGetir();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textboxid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxKullanciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextTC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            textAd.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textSoyad.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBoxDurum.SelectedItem = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            maskedTextboxKayitT.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO PERSONEL(PERSONELKULLANICIAD,PERSONELSIFRE,PERSONELTC,PERSONELTEL,PERSONELADRES,PERSONELMAIL,PERSONELAD,PERSONELSOYAD,PERSONELDURUM,PERSONELKAYITTARIHI) " +
                "VALUES(@PERSONELKULLANICIAD,@PERSONELSIFRE,@PERSONELTC,@PERSONELTEL,@PERSONELADRES,@PERSONELMAIL,@PERSONELAD,@PERSONELSOYAD,@PERSONELDURUM,@PERSONELKAYITTARIHI)";

            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@PERSONELKULLANICIAD",textBoxKullanciAdi.Text);
            komut.Parameters.AddWithValue("@PERSONELSIFRE", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@PERSONELTC", maskedTextTC.Text);
            komut.Parameters.AddWithValue("@PERSONELTEL", maskedTextTel.Text);
            komut.Parameters.AddWithValue("@PERSONELADRES", textAdres.Text);
            komut.Parameters.AddWithValue("@PERSONELMAIL", textBoxEmail.Text);
            komut.Parameters.AddWithValue("@PERSONELAD", textAd.Text);
            komut.Parameters.AddWithValue("@PERSONELSOYAD", textSoyad.Text);
            komut.Parameters.AddWithValue("@PERSONELDURUM", comboBoxDurum.SelectedItem);
            komut.Parameters.AddWithValue("@PERSONELKAYITTARIHI", maskedTextboxKayitT.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            PersonelleriGetir();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM PERSONEL WHERE PERSONELID=@PERSONELID ";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@PERSONELID", Convert.ToInt32(textboxid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            PersonelleriGetir();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE PERSONEL SET PERSONELKULLANICIAD=@PERSONELKULLANICIAD,PERSONELSIFRE=@PERSONELSIFRE,PERSONELTC=@PERSONELTC,PERSONELTEL=@PERSONELTEL,PERSONELADRES=@PERSONELADRES,PERSONELMAIL=@PERSONELMAIL,PERSONELAD=@PERSONELAD,PERSONELSOYAD=@PERSONELSOYAD,PERSONELDURUM=@PERSONELDURUM,PERSONELKAYITTARIHI=@PERSONELKAYITTARIHI WHERE PERSONELID=@PERSONELID";


            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@PERSONELID", Convert.ToInt32(textboxid.Text));

            komut.Parameters.AddWithValue("@PERSONELKULLANICIAD", textBoxKullanciAdi.Text);
            komut.Parameters.AddWithValue("@PERSONELSIFRE", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@PERSONELTC", maskedTextTC.Text);
            komut.Parameters.AddWithValue("@PERSONELTEL", maskedTextTel.Text);
            komut.Parameters.AddWithValue("@PERSONELADRES", textAdres.Text);
            komut.Parameters.AddWithValue("@PERSONELMAIL", textBoxEmail.Text);
            komut.Parameters.AddWithValue("@PERSONELAD", textAd.Text);
            komut.Parameters.AddWithValue("@PERSONELSOYAD", textSoyad.Text);
            komut.Parameters.AddWithValue("@PERSONELDURUM", comboBoxDurum.SelectedItem);
            komut.Parameters.AddWithValue("@PERSONELKAYITTARIHI", maskedTextboxKayitT.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            PersonelleriGetir();

        }
    }
}
