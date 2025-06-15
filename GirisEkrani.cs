using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class GirisEkrani: Form
    {
        
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
            PersonelGiris giris = new PersonelGiris();
            giris.Show(); 


        }
      
        public void button2_Click(object sender, EventArgs e)
        {
            string girilenKullanici = textBoxKullOgrenci.Text;
            string girilenSifre = textBoxSifreOgrenci.Text;

            if (girilenKullanici == kullaniciveri.uyeKullaniciAd &&
                girilenSifre == kullaniciveri.uyeSifre)
            {
                MessageBox.Show("Giriş başarılı!");

                UyeProfilBilgileri bilgi = new UyeProfilBilgileri();
                bilgi.Show(); 
                    

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }


        private void panelpersonel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelogrenci_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
