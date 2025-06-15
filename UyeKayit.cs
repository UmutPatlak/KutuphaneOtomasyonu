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

namespace KutuphaneOtomasyonu
{
    public partial class UyeKayit: Form
    {

        public UyeKayit()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            UyeBilgileriSinifi.uyeAd = textBoxUyeAd.Text;
            UyeBilgileriSinifi.uyeAdres = textBoxUyeAdres.Text;

            kullaniciveri.uyeKullaniciAd = textBoxUyeKullaniciGiris.Text;
            kullaniciveri.uyeSifre = textBoxUyeSifre.Text;

            UyeBilgileriSinifi.uyeOkul = textBoxUyeOkul.Text;
            UyeBilgileriSinifi.uyeSoyAd = textBoxUyeSoyad.Text;
            UyeBilgileriSinifi.uyeTel = maskedTextboxUyeTelefon.Text;
            UyeBilgileriSinifi.uyeTC = maskedTextUyeTC.Text;
            UyeBilgileriSinifi.uyeDT = maskedTextboxuyeDT.Text;
            UyeBilgileriSinifi.uyeKayitTarihi = maskedTextBoxuyeKT.Text;

            MessageBox.Show("Uye Basariyla Kaydedildi..");

            this.Close();


        }

        private void UyeKayit_Load(object sender, EventArgs e)
        {



        }
    }
}
