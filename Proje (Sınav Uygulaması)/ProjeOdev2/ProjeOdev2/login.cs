/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje 1
**				ÖĞRENCİ ADI............: TAHA YAĞMA
**				ÖĞRENCİ NUMARASI.......: S211210167
**              DERSİN ALINDIĞI GRUP...: 1.Öğretim A
****************************************************************************/

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
        //public static string[] SinavaGirenler = new string[SinavHazirla.sinavlar[SinavGir.aktifSınav].ogrenciler.Length];
        public static string[] SinavaGirenler = new string[1];
        static int c = 0;//sayaç
        private void GirisYap_Click(object sender, EventArgs e)
        {   
            
            bool durum = false;
            //sinavlar içinden girilmek istenen sınavın öğrenci listesini geziyor
            foreach(int i in SinavHazirla.sinavlar[SinavGir.aktifSınav].ogrenciler)
            {
                if (OgrenciDosya.ogr[i].getTC() == TCgir.Text && OgrenciDosya.ogr[i].getPassword() == SifreGir.Text) 
                {
                    durum = true;
                    break;
                }
            }
            // eğer durum doğru ise yani şifre ve tc doğru girildi ise
            if (durum)
            {
                // eğer sinavagirenler dizinde varsa öğrenci daha önce girmiştir. Uyarı ver
                if (SinavaGirenler.Contains(TCgir.Text))
                {
                    loginAlert.ForeColor = System.Drawing.Color.Red;
                    loginAlert.Text = "Sınav hakkınız bitmiştir !";
                }
                // yoksa öğrenciye girenler listesine ekle ve sınav sayfasını aç
                else
                {
                    TCGirLabel = TCgir.Text;
                    if (c < SinavaGirenler.Length)
                    {
                        SinavaGirenler[c] = TCgir.Text;
                        c += 1;
                    }
                    else
                    {
                        string[] temp = new string[SinavaGirenler.Length*2];
                        for(int i = 0;i< SinavaGirenler.Length; i++)
                        {
                            temp[i] = SinavaGirenler[i];
                        }
                        temp[c++] = TCgir.Text;
                        SinavaGirenler = temp;
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
