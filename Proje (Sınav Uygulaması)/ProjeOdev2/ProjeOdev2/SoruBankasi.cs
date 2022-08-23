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
    public partial class SoruBankasi : Form
    {
        public SoruBankasi()
        {
            InitializeComponent();
        }

        private void GorselEkleBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Resim Ekle";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            dlg.Filter = "jpg files (*.jpg)|*.jpg |All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(dlg.OpenFile());
            }
            dlg.Dispose();
        }

        public void SoruEkleBtn_Click(object sender, EventArgs e)// soru ekle
        {

            string sık = CevapText.Text.ToLower();
            if (SoruIcerik.Text == "" || CevapText.Text == "" || PuanTextBox.Text ==""|| ArichText.Text == "" || BrichText.Text == "" || CrichText.Text == "")
            {
                SoruEkleAlert.ForeColor = System.Drawing.Color.Red;
                SoruEkleAlert.Text = "(*) Doldurulması Zorunlu Alanlar ! ";
            }
            else if(int.TryParse(PuanTextBox.Text, out _) == false)
            {
                SoruEkleAlert.ForeColor = System.Drawing.Color.Red;
                SoruEkleAlert.Text = "Sınav puanı sayısal değer olmalı ! ";
            }
            else if(sık != "a" || sık != "b" || sık != "c" || sık != "d" || sık != "e")
            {
                SoruEkleAlert.ForeColor = System.Drawing.Color.Red;
                SoruEkleAlert.Text = "Lütfen cevap şıkkını kontrol edin ! ";
            }
            else
            {
                double puan = Convert.ToDouble(PuanTextBox.Text);
                string[] secenekler = { ArichText.Text, BrichText.Text, CrichText.Text, DrichText.Text, ErichText.Text };
                SoruBanka tmp = new SoruBanka();
                tmp.SoruEkle(SoruIcerik.Text, secenekler, CevapText.Text, puan, ZorlukSeviyeBox.Text, pictureBox1.Image);
                SoruEkleAlert.ForeColor = System.Drawing.Color.Green;
                SoruEkleAlert.Text = "Soru Eklendi.\n\nSoruID: " + Convert.ToString(SoruBanka.sorular.Length-1);
        
                Clear();
            }
            
           
  
        }//
        private void Clear()
        {
            SoruIcerik.Text = null;
            CevapText.Text = null;
            PuanTextBox.Text = null;
            ArichText.Text = null;
            BrichText.Text = null;
            CrichText.Text = null;
            DrichText.Text = null;
            ErichText.Text = null;
            ZorlukSeviyeBox.Text = null;
            pictureBox1.Image = null;
        }

        private void SoruSilBtn_Click(object sender, EventArgs e)
        {
            if (SoruBanka.sorular[0] == null) // sorular dizisi boş ise
            {
                SoruSilAlert.ForeColor = System.Drawing.Color.Red;
                SoruSilAlert.Text = "Soru bankası boş";
            }
            else if (SoruSilBox.Text == "")
            {
                SoruSilAlert.ForeColor = System.Drawing.Color.Red;
                SoruSilAlert.Text = "( * ) Doldurulması zorunlu alanlar !";
            }
            else
            {
                if (SoruBanka.SoruSil(Convert.ToInt32(SoruSilBox.Text)))
                {
                    SoruSilAlert.ForeColor = System.Drawing.Color.Green;
                    SoruSilAlert.Text = "Soru Silindi";

                }
                else
                {
                    SoruSilAlert.ForeColor = System.Drawing.Color.Red;
                    SoruSilAlert.Text = SoruSilBox.Text+" ID li  soru bulunamadı !";
                }

            }
            
        }
    }// soru bankasi class end
}
