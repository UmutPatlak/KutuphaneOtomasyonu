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
            PersonelBilgileriSinifi personelsinifi = new PersonelBilgileriSinifi();
            textAd.Text = personelsinifi.persoad;
            textAdres.Text = personelsinifi.persoAdres;
            textBoxEmail.Text = personelsinifi.persoeMail;
            textBoxKullanciAdi.Text = personelsinifi.persokullaniciAdi;
            textBoxSifre.Text = personelsinifi.persosifre;
            comboBox1.SelectedItem = personelsinifi.persoDurum; 
            maskedTextTel.Text = personelsinifi.persoTel;
            maskedTextTC.Text = personelsinifi.persotc;
            maskedTextboxKayitT.Text = personelsinifi.persokayitTarihi;
            textSoyad.Text = personelsinifi.persosoyAd; 




        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
