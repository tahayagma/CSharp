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
using System.Windows.Forms;

namespace ProjeOdev2
{
    public partial class Ogrenci_Dosyasi : Form
    {
      
        public Ogrenci_Dosyasi()
        {
            InitializeComponent();
        }
     
        
        private void OgrenciEkleBtn_Click(object sender, EventArgs e) // Öğrenci Ekleme
        {
            bool isNumeric = long.TryParse(OgrTc.Text, out _);
            if(OgrTc.Text.Length != 11 || isNumeric == false)
            {
                OgrenciEkleAlert.ForeColor = System.Drawing.Color.Red;
                OgrenciEkleAlert.Text = "TC yanlış veya eksik !";
            }
            // tC daha önce kayıt edildi mi diye kontrol ediliyor
            else if (VarMı(OgrTc.Text))
            {
                OgrenciEkleAlert.ForeColor = System.Drawing.Color.Red;
                OgrenciEkleAlert.Text = "TC kayıtlı ! Lütfen yeni bir TC ile deneyin";
            }
            else if(OgrAdSoyad.Text == "" || OgrSifre.Text == "")
            {
                OgrenciEkleAlert.ForeColor = System.Drawing.Color.Red;
                OgrenciEkleAlert.Text = "Ad Soyad veya Şifre boş bırakılamaz !";
            }
            else
            {
                OgrenciDosya tmp = new OgrenciDosya();
                tmp.OgrenciEkle(OgrTc.Text, OgrAdSoyad.Text, OgrSifre.Text);
                OgrenciEkleAlert.ForeColor = System.Drawing.Color.Green;
                OgrenciEkleAlert.Text = "Öğrenci Eklendi. ";
                OgrTc.Text = null;
                OgrAdSoyad.Text = null;
                OgrSifre.Text = null;
            }

           
        }
     

        private void OgrListeleBtn_Click(object sender, EventArgs e)// Öğrencileri Listeleme
        {

            listBox1.Items.Clear();
            //ogrenci listesinde üzerinde geziniyor
            foreach (Ogrenci og in OgrenciDosya.ogr)
            {   if(og == null)
                {
                    label5.ForeColor = System.Drawing.Color.Red;
                    label5.Text = "Liste boş !";
                    break;
                }
                else
                {
                    listBox1.Items.Add(og.getTC()+" "+og.getAdiSoyadi());
                }
                
           
            }
            
        }

        private void OgrenciSilBtn_Click(object sender, EventArgs e) // Öğrenci Silme
        {
            if (OgrenciDosya.ogr[0] == null)
            {
                silindiAlert.ForeColor = System.Drawing.Color.Red;
                silindiAlert.Text = "Öğrenci listesi boş";
            }
            else if (OgrencSilTxt.Text == "")
            {
                silindiAlert.ForeColor = System.Drawing.Color.Red;
                silindiAlert.Text = "( * ) Doldurulması zorunlu alanlar !";
            }
            else
            {
                if (OgrenciDosya.OgrenciSil(OgrencSilTxt.Text))
                {
                    silindiAlert.ForeColor = System.Drawing.Color.Green;
                    silindiAlert.Text = "Öğrenci Silindi";

                }
                else
                {
                    silindiAlert.ForeColor = System.Drawing.Color.Red;
                    silindiAlert.Text = OgrencSilTxt.Text + " TC numarasına ait öğrenci bulunamadı !";
                }

            }
        }// öğrenci sil

        private bool VarMı(string tc) // Girilen TC no kayıtlı mı değil mi  sorgulaması yapar
        {
            bool result = false;
            if (OgrenciDosya.ogr[0] != null)
            {
                foreach (Ogrenci og in OgrenciDosya.ogr)
                {

                    if (tc == og.getTC())
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
