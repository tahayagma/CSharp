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
    public partial class SinavSayfa : Form
    {
        int _ticks;
        public SinavSayfa()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            
        }
        
        SinavHazirla sınav1 = SinavHazirla.sinavlar[SinavGir.aktifSınav];// sınav seçildi.


        public static double ToplananPuan = 0;
        private void SinavSayfa_Load(object sender, EventArgs e)
        {
            SinavAdiLabel.Text = sınav1.SinavAdi;
            toplamSoruSayisi.Text = Convert.ToString(sınav1.SoruSayisi);
            TimerDakika.Text = Convert.ToString(sınav1.SinavSuresi-1);
            OgrenciBilgiLabel.Text = login.TCGirLabel;
            

            Soru s1 = sınav1.sorular[Sindis];// sorular kısmından ilk soru seçildi. Artan bir şekilde devam eder
            pictureBox1.Image = s1.resim;
            IcerikrichText.Text = s1.soruText;
            ARichText.Text = s1.secenekler[0];
            BRichText.Text = s1.secenekler[1];
            CRichText.Text = s1.secenekler[2];
            DRichTex.Text = s1.secenekler[3];
            ERichText.Text = s1.secenekler[4];
            Puanlabel.Text = Convert.ToString(s1.puan);
            SoruId.Text = "SoruID: " + Convert.ToString(s1.SoruID);
            seviye.Text = "Seviye: "+s1.ZorlukSeviye;

            _ticks++;
            if (TimerDakika.Text == "0" && TimerSaniye.Text == "0")
            {

                timer1.Stop();
                bitir();
            }
            else if(_ticks>=0 && _ticks <=60)
            {
                TimerSaniye.Text = Convert.ToString(Convert.ToInt32(TimerSaniye.Text) - 1);
            }  
            else if(Convert.ToInt32(TimerSaniye.Text)==0)
            {
                TimerDakika.Text = Convert.ToString(Convert.ToInt32(TimerDakika.Text) - 1);
                _ticks = 1;
                TimerSaniye.Text = "59";
                
            }


        }
        public int Sindis = 0;
        private void sonrakiBtn_Click(object sender, EventArgs e)
        {   
            if(SoruSayisi.Text == toplamSoruSayisi.Text)
            {
                sonrakiBtn.Text = "Bitir";
                bitir();
                this.Close();
            }
            else
            {
                PuanHesapla();
                Sindis = Convert.ToInt32(SoruSayisi.Text);
                SoruSayisi.Text = Convert.ToString(Convert.ToInt32(SoruSayisi.Text) + 1);
                Soru s1 = sınav1.sorular[Sindis];// sorular kısmından ikinci soru seçildi. Artan bir şekilde devam eder
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = s1.resim;
                IcerikrichText.Text = s1.soruText;
                ARichText.Text = s1.secenekler[0];
                BRichText.Text = s1.secenekler[1];
                CRichText.Text = s1.secenekler[2];
                DRichTex.Text = s1.secenekler[3];
                ERichText.Text = s1.secenekler[4];
                Puanlabel.Text = Convert.ToString(s1.puan);
                SoruId.Text = "SoruID: " + Convert.ToString(s1.SoruID);
                seviye.Text = "Seviye: "+s1.ZorlukSeviye;
                
            }
            
        }
        private void PuanHesapla()
        {
            
            double  p = sınav1.sorular[Sindis].puan;
            string c = sınav1.sorular[Sindis].cevap;

            if (c == AradioButton.Text && AradioButton.Checked == true)
            {
                ToplananPuan += p;
            }
            else if (c == BradioButton.Text && BradioButton.Checked == true)
            {
                ToplananPuan += p;
            }
            else if (c == CradioButton.Text && CradioButton.Checked == true)
            {
                ToplananPuan += p;
            }
            else if (c == DradioButton.Text && DradioButton.Checked == true)
            {
                ToplananPuan += p;
            }
            else if (c == EradioButton.Text && EradioButton.Checked == true)
            {
                ToplananPuan += p;
            }
            else
            {
                ToplananPuan += 0;
            }
        }// PuanHesapla end

        public void bitir()
        {
            PuanHesapla();
            Raporlar tmp = new Raporlar();
            tmp.RaporEkle(OgrenciBilgiLabel.Text, sınav1.SinavAdi, ToplananPuan,SinavGir.aktifSınav);
            ToplananPuan = 0;
            this.Close();
        }

        private void btrBtn_Click(object sender, EventArgs e)
        {
            bitir();
        }

    }
}
