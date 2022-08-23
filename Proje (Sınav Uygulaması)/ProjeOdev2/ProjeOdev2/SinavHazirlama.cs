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
    public partial class SinavHazirlama : Form
    {
        public SinavHazirlama()
        {
            InitializeComponent();
        }
        //public static SinavHazirla[] sinavlar = new SinavHazirla[1];
        public static int[] KayitliOgrIndis;// sınav öğrenci listesini tutmak için
  
        private void SinavHazirlaListeleBtn_Click(object sender, EventArgs e) // Öğrenci Listeleme
        {
            OgrSınavcheckedList.Items.Clear();
            foreach (Ogrenci og in OgrenciDosya.ogr) // ogr dizi üzerinde tek tek gez bilgiler bastır
            {
                if (og == null)
                {
                    label7.ForeColor = System.Drawing.Color.Red;
                    label7.Text = "Liste boş !";
                    break;
                }
                else
                {
                    OgrSınavcheckedList.Items.Add(og.getTC() + " " + og.getAdiSoyadi());
                }
            }


        }

        private void SinavOlusturBtn_Click(object sender, EventArgs e) // Sınav Olusturma
        {
            if(SinavAdBox.Text == "" || SınavSureBox.Text == ""|| GecmePuaniBox.Text == ""|| SayiBox.Text == "" || OgrSınavcheckedList.CheckedItems.Count == 0)
            {
                SinavHazirlaAlert.ForeColor = System.Drawing.Color.Red;
                SinavHazirlaAlert.Text = "( * ) Doldurulması zorunlu alanlar ! ";
            }
            else if(int.TryParse(SınavSureBox.Text,out _) == false || int.TryParse(SayiBox.Text, out _) == false || int.TryParse(GecmePuaniBox.Text, out _) == false)
            {
                SinavHazirlaAlert.ForeColor = System.Drawing.Color.Red;
                SinavHazirlaAlert.Text = "Sınav Süresi , Soru Sayısı, Geçme Puanı numeric değerler olmalı  ! ";
            }
            else if (Convert.ToInt32(SayiBox.Text) > SoruBanka.sorular.Length)
            {
                SinavHazirlaAlert.ForeColor = System.Drawing.Color.Red;
                SinavHazirlaAlert.Text = "Soru bankasında yeteri kadar soru yok !";
            }
            else
            {
                KayitliOgrIndis = new int[OgrSınavcheckedList.CheckedItems.Count];// sinav listesi olusturmak için öğrenci indis
                for (int i = 0; i < KayitliOgrIndis.Length; i++)
                {
                    KayitliOgrIndis[i] = OgrSınavcheckedList.CheckedIndices[i];
                    // checkedlist içindeki seçilen her öğrencinin indis değeri diziye kaydediliyor
                }
                SinavHazirla tmp = new SinavHazirla();
                tmp.olustur(SinavAdBox.Text,
                    Convert.ToInt32(SayiBox.Text),
                    Convert.ToInt32(GecmePuaniBox.Text),
                    Convert.ToInt32(SınavSureBox.Text),
                    dateTimePicker1.Value, KayitliOgrIndis);
                SinavHazirlaAlert.ForeColor = System.Drawing.Color.Green;
                SinavHazirlaAlert.Text = "Sınav oluşturuldu. ";
                Clear();
            }
            
        }//
        private void Clear()
        {
            SinavAdBox.Text = null;
            SayiBox.Text = null;
            GecmePuaniBox.Text = null;
            SınavSureBox.Text = null;
            OgrSınavcheckedList.Items.Clear();
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            checkedListBox1.Items.Clear();
            foreach (Ogrenci og in OgrenciDosya.ogr)
            {
                if (og == null)
                {
                    label9.ForeColor = System.Drawing.Color.Red;
                    label9.Text = " Öğrenci listesi boş !";
                    break;
                }
                else
                {
                    checkedListBox1.Items.Add(og.getTC() + " " + og.getAdiSoyadi());
                }
            }
        }
        // sınavları listele
        private void button1_Click(object sender, EventArgs e)
        {

            checkedListBox2.Items.Clear();
            foreach (SinavHazirla sn in SinavHazirla.sinavlar)
            {
                if (sn == null)
                {
                    label9.ForeColor = System.Drawing.Color.Red;
                    label9.Text = "Tanımlı sınav yok !";
                    break;
                }
                else
                {
                    checkedListBox2.Items.Add(sn.SinavAdi + " " + sn.SinavTarihi);
                    label9.Text = "";
                }
            }
        }//

        //Var Olan sınava Öğrenci Eklemek
        private int[] arttir(int[] ogrListe,int value)
        {
            int[] tmp = new int[ogrListe.Length+1];
            for(int i = 0; i < ogrListe.Length; i++)
            {
                
                tmp[i] = ogrListe[i];
            }
            tmp[tmp.Length-1] = value;
            return tmp;
        }//

        //var Olan sınavdan Öğrenci Sil
        private int[] azalt(int[] ogrListe, int value)
        {
            int counter = 0;
            int[] tmp = new int[ogrListe.Length - 1];
            for (int i = 0; i < ogrListe.Length; i++)
            {
                if(ogrListe[i] != value)
                {
                    tmp[counter++] = ogrListe[i]; 
                }
            }
            return tmp;
        }//

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            EkleSilEvent(btn.Name);
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            EkleSilEvent(btn.Name);
        }//

        private void EkleSilEvent(string btnname)
        {
            int[] ogrenciler = new int[checkedListBox1.CheckedItems.Count];
            // ogrenci list box içindeki verilerin indislerini ogrenciler adındaki atıyor atıyor
            int counter  = 0;
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
                ogrenciler[counter++] = indexChecked;
            counter = 0;
            int[] sınavlar = new int[checkedListBox2.CheckedItems.Count];
            // sınavlar list box içindeki seçilen sınavların indislerini sınavlar adlı diziye atıyor
            foreach (int indexChecked in checkedListBox2.CheckedIndices)
                sınavlar[counter++] = indexChecked;

            // sınavlar üzeriden gezinip o sınavın öğrenci listesini alıyor.
            for (int i = 0; i < sınavlar.Length; i++)
            {
                SinavHazirla aktifSınav = SinavHazirla.sinavlar[i];
                int[] ogrnc = aktifSınav.ogrenciler;
                // çekilen öğrenci listesinde silinmek istenen öğrencinin olup olmadığı sorgulanıyor
                for (int j = 0; j < ogrenciler.Length; j++)
                {
                    // ekle butonu çağrıldı
                    if(btnname == "EkleBtn")
                    {
                        // eğer listede öğrenci varsa zaten kayıtlı diye uyarı veriyor
                        if (ogrnc.Contains(ogrenciler[j]))
                        {
                            label9.ForeColor = Color.Red;
                            label9.Text = OgrenciDosya.ogr[ogrenciler[j]].getAdiSoyadi() + " " + aktifSınav.SinavAdi + " sınav listesinde kayıtlı";
                        }
                        else
                        {   // yoksa aktif sınav öğrenci listesi arttir metodundan dönecek olan liste ile güncelleniyor
                            SinavHazirla.sinavlar[i].ogrenciler = arttir(ogrnc, ogrenciler[j]);
                            label9.ForeColor = Color.Green;
                            label9.Text = OgrenciDosya.ogr[ogrenciler[j]].getAdiSoyadi() + " adlı öğrenci " + aktifSınav.SinavAdi + " sınav listesine eklendi";
                        }

                    }
                    // demek ki sil butonu çağrıldı
                    else
                    {
                        if (ogrnc.Contains(ogrenciler[j]))
                        {
                            SinavHazirla.sinavlar[i].ogrenciler = azalt(ogrnc, ogrenciler[j]);
                            label9.ForeColor = Color.Green;
                            label9.Text = OgrenciDosya.ogr[ogrenciler[j]].getAdiSoyadi() + " adlı öğrenci " + aktifSınav.SinavAdi + " sınav listesinden silindi";

                        }
                        else
                        {   // öğrenci listede yoksa öğrenci yok diye uyarı veriyor.
                            label9.ForeColor = Color.Red;
                            label9.Text = OgrenciDosya.ogr[ogrenciler[j]].getAdiSoyadi() + " adlı öğrenci " + aktifSınav.SinavAdi + " sınav listesinde yok";
                        }
                    }
                    
                }

            }


        }
    }
}
