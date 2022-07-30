using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static string TCGirLabel;
        public static string[] SinavaGirenler = new string[SinavHazirla.sinavlar[SinavGir.aktifSınav].ogrenciler.Length];
        private void GirisYap_Click(object sender, EventArgs e)
        {   
            int c = 0;
            bool durum = false;
            foreach(int i in SinavHazirla.sinavlar[SinavGir.aktifSınav].ogrenciler)
            {
                if (OgrenciDosya.ogr[i].getTC() == TCgir.Text && OgrenciDosya.ogr[i].getPassword() == SifreGir.Text) 
                {
                    durum = true;
                    break;
                }
            }
            if (durum)
            {
                if (SinavaGirenler.Contains(TCgir.Text))
                {
                    loginAlert.ForeColor = System.Drawing.Color.Red;
                    loginAlert.Text = "Sınav hakkınız bitmiştir !";
                }
                else
                {
                    TCGirLabel = TCgir.Text;
                    if (c < SinavaGirenler.Length)
                    {
                        SinavaGirenler[c] = TCgir.Text;
                        c += 1;
                    }
                        
                    SinavSayfa sf = new SinavSayfa();
                    sf.Show();
                    this.Hide();
                }
                
            }
            else
            {
                bool v = false;
                foreach(Ogrenci og in OgrenciDosya.ogr)
                {
                    if(og.getTC() == TCgir.Text && og.getPassword() == SifreGir.Text)
                    {
                        v = true;
                    }
                }
                if (v)
                {
                    loginAlert.ForeColor = System.Drawing.Color.Red;
                    loginAlert.Text = SinavHazirla.sinavlar[SinavGir.aktifSınav].SinavAdi + " sınav listesine kayıtlı değilsiniz !";
                }
                else
                {
                    loginAlert.ForeColor = System.Drawing.Color.Red;
                    loginAlert.Text = "Lütfen bilgilerinizi kontrol edin !";

                }
                
            }
        }
    }
}
