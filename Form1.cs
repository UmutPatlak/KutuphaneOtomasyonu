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
    public partial class PersonelGirisEkrani: Form
    {
        public PersonelGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitEkrani kayit = new KayitEkrani();
            kayit.Show(); 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeKayit uye = new UyeKayit();
            uye.Show(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
