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
    public partial class KayitEkrani: Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }



        private void KayitEkrani_Load(object sender, EventArgs e)
        {
            KitapSinifi kitapsinifi = new KitapSinifi();
            textBoxKitapAd.Text = kitapsinifi.kitapAdi;
            textBoxRafno.Text = kitapsinifi.kitapRafNo.ToString();
            textBoxSayfa.Text = kitapsinifi.kitapsayfasayisi.ToString();
            textBoxTur.Text = kitapsinifi.kitapTur;
            textBoxYayinevi.Text = kitapsinifi.kitapyayineviAdi;
            textBoxYazarAd.Text = kitapsinifi.kitapyazarAdi;
            maskedTextboxKitapKAyit.Text = kitapsinifi.kitapKayitTarihi; 


               
        }

        private void maskedTextboxKayitT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
