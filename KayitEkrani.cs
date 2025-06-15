using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class KayitEkrani: Form
    {
        SqlConnection baglanti;
        SqlDataAdapter dat;
        SqlCommand komut;



        public KayitEkrani()
        {
            InitializeComponent();
        }



        private void KayitEkrani_Load(object sender, EventArgs e)
        {
            
            textBoxKitapAd.Text = KitapSinifi.kitapAdi;
            textBoxRafno.Text = KitapSinifi.kitapRafNo.ToString();
            textBoxSayfa.Text = KitapSinifi.kitapsayfasayisi.ToString();
            textBoxTur.Text = KitapSinifi.kitapTur;
            textBoxYayinevi.Text = KitapSinifi.kitapyayineviAdi;
            textBoxYazarAd.Text = KitapSinifi.kitapyazarAdi;
            maskedTextboxKitapKAyit.Text = KitapSinifi.kitapKayitTarihi;

            


        }
        void KitaplariGetir() {
            baglanti = new SqlConnection("Data Source=DESKTOP-HGGVOAC\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open(); 
            dat = new SqlDataAdapter("SELECT *FROM KITAPLAR", baglanti);
            DataTable table = new DataTable();
            dat.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close(); 


        }

        private void maskedTextboxKayitT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public static void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            KitaplariGetir(); 
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxKitapNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxKitapAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxYazarAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxYayinevi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxSayfa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxTur.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxRafno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            maskedTextboxKitapKAyit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO KITAPLAR(KITAPAD,YAZARAD,YAYINEVI,SAYFASAY,TUR,RAFNO,KITAPKAYIT)" +
                    "VALUES(@KITAPAD,@YAZARAD,@YAYINEVI,@SAYFASAY,@TUR,@RAFNO,@KITAPKAYIT)";
            komut = new SqlCommand(sorgu,baglanti) ;
            komut.Parameters.AddWithValue("@KITAPAD",textBoxKitapAd.Text);
            komut.Parameters.AddWithValue("@YAZARAD",textBoxYazarAd.Text);
            komut.Parameters.AddWithValue("@YAYINEVI",textBoxYayinevi.Text);
            komut.Parameters.AddWithValue("@SAYFASAY",textBoxSayfa.Text);
            komut.Parameters.AddWithValue("@TUR",textBoxTur.Text);
            komut.Parameters.AddWithValue("@RAFNO",textBoxRafno.Text);
            komut.Parameters.AddWithValue("@KITAPKAYIT",maskedTextboxKitapKAyit.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KitaplariGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM KITAPLAR WHERE KITAPID =@KITAPID ";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@KITAPID", Convert.ToInt32(textBoxKitapNo.Text) );
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            KitaplariGetir(); 

        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE KITAPLAR SET KITAPAD=@KITAPAD,YAZARAD=@YAZARAD,YAYINEVI=@YAYINEVI,SAYFASAY=@SAYFASAY,TUR=@TUR,RAFNO=@RAFNO,KITAPKAYIT=@KITAPKAYIT WHERE KITAPID = @KITAPID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KITAPID",Convert.ToInt32(textBoxKitapNo.Text));

            komut.Parameters.AddWithValue("@KITAPAD", textBoxKitapAd.Text);
            komut.Parameters.AddWithValue("@YAZARAD",textBoxYazarAd.Text);
            komut.Parameters.AddWithValue("@YAYINEVI", textBoxYayinevi.Text);
            komut.Parameters.AddWithValue("@SAYFASAY", textBoxSayfa.Text);
            komut.Parameters.AddWithValue("@TUR", textBoxTur.Text);
            komut.Parameters.AddWithValue("@RAFNO", textBoxRafno.Text);
            komut.Parameters.AddWithValue("@KITAPKAYIT", maskedTextboxKitapKAyit.Text);

            baglanti.Open();
            komut.ExecuteNonQuery(); 
            baglanti.Close();

            KitaplariGetir();
             

        }
    }
    
}
