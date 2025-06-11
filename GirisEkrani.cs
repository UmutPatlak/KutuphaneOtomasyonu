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
            PersonelGirisEkrani frm1 = new PersonelGirisEkrani();
            frm1.Show(); 

        }

        private void GirisEKrani_Load(object sender, EventArgs e)
        {
            panelpersonel.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelpersonel.Visible = false; 

            panelogrenci.Visible = true;
            panelogrenci.BringToFront();



        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            panelogrenci.Visible = false;

            panelpersonel.Visible = true;
            panelpersonel.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelGirisEkrani frm1 = new PersonelGirisEkrani();
            frm1.Show(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {

            UyeKitaplar uye = new UyeKitaplar();
            uye.Show();

        }
    }
}
