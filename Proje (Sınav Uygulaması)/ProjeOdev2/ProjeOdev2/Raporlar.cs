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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeOdev2
{
    public class Raporlar
    {
        string TC;
        public string SinavAdi;
        public double Puan;
        public string Durum;
        

        public Raporlar()
        {
            TC = "";
            SinavAdi = "";
            Puan = 0;
            Durum = "";
            
        }
        public Raporlar(string TC, string SinavAdi, double Puan,string Durum)
        {
            this.TC = TC;
            this.SinavAdi = SinavAdi;
            this.Puan = Puan;
            this.Durum = Durum;
        }
        public string getTC() { return TC; }
        public static Raporlar[] rapor = new Raporlar[1];
        public void RaporEkle(string TC, string SinavAdi, double Puan,int aktifSınav)
        {
            string durum;// geçti kaldı durumunu belirtmek için 
            if (Puan >= SinavHazirla.sinavlar[aktifSınav].GecmePuani)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı ";
            }
            if (rapor[rapor.Length - 1] != null) // raporlar dizisi boş değilse
            {
                Raporlar[] tmp = new Raporlar[rapor.Length + 1]; // boyut+1 yapılır yeni bir dizi oluşturuluyor
                for (int i = 0; i < rapor.Length; i++) // eski veriler gecici diziye kopyalanıyor
                {
                    tmp[i] = rapor[i];
                }
                tmp[tmp.Length - 1] = new Raporlar(TC,SinavAdi,Puan,durum);// gecici dizinin sonuna gelen raporu ekledik

                rapor = tmp; // gecici dizi eski rapor dizisine atandı
            }
            else
            {
                rapor[rapor.Length - 1] = new Raporlar(TC, SinavAdi, Puan,durum);
            }

        }
    }

    
    
}
