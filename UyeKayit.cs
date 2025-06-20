using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace KutuphaneOtomasyonu
{
    public partial class UyeKayit: Form
    {
        SqlCommand komut;
        SqlDataAdapter data;
        SqlConnection baglanti;
        public UyeKayit()
        {
          


            InitializeComponent();
        }

        void UyeleriGetir() {

            baglanti = new SqlConnection("Data Source=DESKTOP-HGGVOAC\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();
            data = new SqlDataAdapter("SELECT *FROM UYEKAYIT",baglanti);
            DataTable datatable = new DataTable();
            data.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {


            string sorgu = "INSERT INTO UYEKAYIT(UYEAD,UYESOYAD,UYEDT,UYEKAYITTARIHI,UYEOKUL,UYEKULLANICIAD,UYESIFRE,UYEADRES,UYETC,UYETEL)" +
                "VALUES(@UYEAD,@UYESOYAD,@UYEDT,@UYEKAYITTARIHI,@UYEOKUL,@UYEKULLANICIAD,@UYESIFRE,@UYEADRES,@UYETC,@UYETEL)";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@UYEAD", textBoxUyeAd.Text);
            komut.Parameters.AddWithValue("@UYESOYAD", textBoxUyeSoyad.Text);
            komut.Parameters.AddWithValue("@UYEDT", maskedTextboxuyeDT.Text);
            komut.Parameters.AddWithValue("@UYEKAYITTARIHI", maskedTextBoxuyeKT.Text);
            komut.Parameters.AddWithValue("@UYEOKUL", textBoxUyeOkul.Text);
            komut.Parameters.AddWithValue("@UYEKULLANICIAD", textBoxUyeKullaniciGiris.Text);
            komut.Parameters.AddWithValue("@UYESIFRE", textBoxUyeSifre.Text);
            komut.Parameters.AddWithValue("@UYEADRES", textBoxUyeAdres.Text);
            komut.Parameters.AddWithValue("@UYETC", maskedTextUyeTC.Text);
            komut.Parameters.AddWithValue("@UYETEL", maskedTextboxUyeTelefon.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            UyeleriGetir();

            MessageBox.Show("Üye başarıyla kaydedildi.");





            UyeBilgileriSinifi.uyeAd = textBoxUyeAd.Text;
            UyeBilgileriSinifi.uyeAdres = textBoxUyeAdres.Text;

            UyeBilgileriSinifi.uyeKullaniciAd = textBoxUyeKullaniciGiris.Text;
            UyeBilgileriSinifi.uyeSifre = textBoxUyeSifre.Text;

            UyeBilgileriSinifi.uyeOkul = textBoxUyeOkul.Text;
            UyeBilgileriSinifi.uyeSoyAd = textBoxUyeSoyad.Text;
            UyeBilgileriSinifi.uyeTel = maskedTextboxUyeTelefon.Text;
            UyeBilgileriSinifi.uyeTC = maskedTextUyeTC.Text;
            UyeBilgileriSinifi.uyeDT = maskedTextboxuyeDT.Text;
            UyeBilgileriSinifi.uyeKayitTarihi = maskedTextBoxuyeKT.Text;

            MessageBox.Show("Uye Basariyla Kaydedildi..");


        }

        private void UyeKayit_Load(object sender, EventArgs e)
        {
            UyeleriGetir();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeleriGetir();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM UYEKAYIT WHERE UYEID = @UYEID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@UYEID", Convert.ToInt32(textBoxUYEID.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            UyeleriGetir();

        }
        
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUYEID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();        
            textBoxUyeAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();           
            textBoxUyeSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();       
            maskedTextboxuyeDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();     
            maskedTextBoxuyeKT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();      
            textBoxUyeOkul.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();         
            textBoxUyeKullaniciGiris.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxUyeSifre.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();        
            textBoxUyeAdres.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();       
            maskedTextUyeTC.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();         
            maskedTextboxUyeTelefon.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE UYEKAYIT SET UYEAD=@UYEAD,UYESOYAD=@UYESOYAD,UYEDT=@UYEDT,UYEKAYITTARIHI=@UYEKAYITTARIHI,UYEOKUL=@UYEOKUL,UYEKULLANICIAD=@UYEKULLANICIAD,UYESIFRE=@UYESIFRE,UYEADRES=@UYEADRES,UYETC=@UYETC,UYETEL=@UYETEL";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@UYEAD", textBoxUyeAd.Text);
            komut.Parameters.AddWithValue("@UYESOYAD", textBoxUyeSoyad.Text);
            komut.Parameters.AddWithValue("@UYEDT", maskedTextboxuyeDT.Text);
            komut.Parameters.AddWithValue("@UYEKAYITTARIHI", maskedTextBoxuyeKT.Text);
            komut.Parameters.AddWithValue("@UYEOKUL", textBoxUyeOkul.Text);
            komut.Parameters.AddWithValue("@UYEKULLANICIAD", textBoxUyeKullaniciGiris.Text);
            komut.Parameters.AddWithValue("@UYESIFRE", textBoxUyeSifre.Text);
            komut.Parameters.AddWithValue("@UYEADRES", textBoxUyeAdres.Text);
            komut.Parameters.AddWithValue("@UYETC", maskedTextUyeTC.Text);
            komut.Parameters.AddWithValue("@UYETEL", maskedTextboxUyeTelefon.Text);


            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            UyeleriGetir();
        }
    }
}
