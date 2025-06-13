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
    public partial class UyeKayit: Form
    {
        public UyeKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UyeKayit_Load(object sender, EventArgs e)
        {
            UyeBilgileriSinifi uyebilgilerisinifi = new UyeBilgileriSinifi();

            textBoxUyeAd.Text = uyebilgilerisinifi.uyeKullaniciAd;
            textBoxUyeAdres.Text = uyebilgilerisinifi.uyeAdres;
            textBoxUyeKullaniciGiris.Text = uyebilgilerisinifi.uyeKullaniciAd;
            textBoxUyeSifre.Text = uyebilgilerisinifi.uyeSifre; 
            textBoxUyeOkul.Text = uyebilgilerisinifi.uyeOkul;
            textBoxUyeSoyad.Text = uyebilgilerisinifi.uyeSoyAd;
            maskedTextboxUyeTelefon.Text = uyebilgilerisinifi.uyeTel;
            maskedTextUyeTC.Text = uyebilgilerisinifi.uyeTC;
            maskedTextboxuyeDT.Text= uyebilgilerisinifi.uyeDT;
            maskedTextBoxuyeKT.Text = uyebilgilerisinifi.uyeKayitTarihi; 


        }
    }
}
