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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void OgrenciDosyasiBtn_Click(object sender, EventArgs e)
        {
            uyari.Text = "";
            Ogrenci_Dosyasi OgrDosya = new Ogrenci_Dosyasi();
            OgrDosya.Show();
        }

        private void SoruBankasiBtn_Click(object sender, EventArgs e)
        {
            uyari.Text = "";
            SoruBankasi sorubnk = new SoruBankasi();
            sorubnk.Show();
        }

        private void SinavGirBtn_Click(object sender, EventArgs e)
        {
            uyari.Text = "";
            //oluşturulan sınav var mı yok mu diye kontrol ediliyor
            if (SinavHazirla.sinavlar[0]== null)
            {
                uyari.ForeColor = System.Drawing.Color.Red;
                uyari.Text = "Sınav oluşturulmadı.";
            }
            else
            {
                SinavGir sg = new SinavGir();
                sg.Show();

            }
            
        }

        private void SinavHazirlaBtn_Click(object sender, EventArgs e)
        {
            uyari.Text = "";
            //soru bankasına soru eklendi mi diye kontrol ediliyor
            if (SoruBanka.sorular[0] == null)
            {
                uyari.ForeColor = System.Drawing.Color.Red;
                uyari.Text = "Sınav oluşturmak için yeteri kadar soru yok !";
            }
            else
            {
                SinavHazirlama sh = new SinavHazirlama();
                sh.Show();
            }
            
        }

        private void RaporlarBtn_Click(object sender, EventArgs e)
        {
            uyari.Text = "";
            // raporlar boş mu diye kontrol ediliyor boş ise uyarı ver değilse pencereyi aç 
            if (Raporlar.rapor[0] == null)
            {
                uyari.ForeColor = System.Drawing.Color.Red;
                uyari.Text = "Gösterilecek rapor yok";
            }
            else
            {
                Rapor rp = new Rapor();
                rp.Show();
            }
        }
    }
}
