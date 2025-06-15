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



    public partial class UyeProfilBilgileri: Form
    {

        public UyeProfilBilgileri()
        {
           

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.Show(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UyeProfilBilgileri_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

             


        }
    }
}
