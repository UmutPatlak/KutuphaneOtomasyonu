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
    public partial class PersonelBilgileri: Form
    {
        public PersonelBilgileri()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PersonelBilgileri_Load(object sender, EventArgs e)
        {
            
            textAd.Text = PersonelBilgileriSinifi.persoad;
            textAdres.Text = PersonelBilgileriSinifi.persoAdres;
            textBoxEmail.Text = PersonelBilgileriSinifi.persoeMail;
            textBoxKullanciAdi.Text = PersonelBilgileriSinifi.persokullaniciAdi;
            textBoxSifre.Text = PersonelBilgileriSinifi.persosifre;
            comboBox1.SelectedItem = PersonelBilgileriSinifi.persoDurum; 
            maskedTextTel.Text = PersonelBilgileriSinifi.persoTel;
            maskedTextTC.Text = PersonelBilgileriSinifi.persotc;
            maskedTextboxKayitT.Text = PersonelBilgileriSinifi.persokayitTarihi;
            textSoyad.Text = PersonelBilgileriSinifi.persosoyAd; 




        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
